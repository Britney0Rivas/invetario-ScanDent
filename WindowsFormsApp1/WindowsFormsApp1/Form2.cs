using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private const string TABLE = "dbo.inv_scandent";

        private bool _loading = false;
        private byte[] fotoBytes = null;


        private enum Mode { View, New, Edit }
        private Mode _mode = Mode.View;

        public Form2()
        {
            InitializeComponent();

            this.Load += Form2_Load;

            // ✅ Buscar
            txt_buscar.TextChanged += (s, e) => LoadGrid(txt_buscar.Text.Trim());

            // ✅ Selección del grid
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

            // ✅ Botones
            btn_guardar.Click += BtnGuardar_Click;
            btn_modificar.Click += BtnModificar_Click;

            HookNuevoButton();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SetMode(Mode.View);
            LoadGrid("");
        }

        /* =========================
           Enganchar botón "Nuevo"
        ========================= */
        private void HookNuevoButton()
        {
            // 1) Por Name recomendado
            var btn = FindControlByName<System.Windows.Forms.Button>(this, "btn_nuevo");

            // 2) Si no existe, lo buscamos por Text (Nuevo)
            if (btn == null)
            {
                btn = FindAllControls<System.Windows.Forms.Button>(this)
                    .FirstOrDefault(b => string.Equals(b.Text?.Trim(), "Nuevo", StringComparison.OrdinalIgnoreCase));
            }

            if (btn != null)
            {
                btn.Click += BtnNuevo_Click; // ✅ handler claro
            }
        }

        private static T FindControlByName<T>(Control root, string name) where T : Control
        {
            foreach (Control c in root.Controls)
            {
                if (c is T t && string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase))
                    return t;

                var child = FindControlByName<T>(c, name);
                if (child != null) return child;
            }
            return null;
        }

        private static System.Collections.Generic.IEnumerable<T> FindAllControls<T>(Control root) where T : Control
        {
            foreach (Control c in root.Controls)
            {
                if (c is T t) yield return t;
                foreach (var child in FindAllControls<T>(c)) yield return child;
            }
        }

        /* =========================
           Estado UI
        ========================= */
        private void SetMode(Mode mode)
        {
            _mode = mode;

            bool enableInputs = (mode == Mode.New || mode == Mode.Edit);
            SetInputsEnabled(enableInputs);

            // ID siempre bloqueado (PK)
            txt_id.Enabled = false;

            // Guardar solo en modo New
            btn_guardar.Enabled = (mode == Mode.New);

            // Modificar solo en modo Edit
            btn_modificar.Enabled = (mode == Mode.Edit);
        }

        private void SetInputsEnabled(bool enabled)
        {
            // OJO: dejo txt_id bloqueado aparte
            txt_nom.Enabled = enabled;   // nombre_producto
            txt_categ.Enabled = enabled;   // categoria
            txt_descrip.Enabled = enabled;  // descripcion
            txt_cant.Enabled = enabled;   // cantidad
            txt_prec.Enabled = enabled;   // precio
            txt_ubi.Enabled = enabled;   // ubicacion
            txt_prove.Enabled = enabled;  // proveedor
            txt_feing.Enabled = enabled;   // fecha_ingreso
            txt_est.Enabled = enabled;   // estado
            txt_resp.Enabled = enabled;   // responsable

        }

        private void ClearInputs()
        {
            txt_id.Clear();
            txt_nom.Clear();
            txt_categ.Clear();
            txt_descrip.Clear();
            txt_cant.Clear();
            txt_prec.Clear();
            txt_ubi.Clear();
            txt_prove.Clear();
            txt_feing.Clear();
            txt_est.Clear();
            txt_resp.Clear();
        }

        /* =========================
           NUEVO
        ========================= */
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ClearInputs();
            SetMode(Mode.New);

            btn_guardar.Visible = true;     // 👈 IMPORTANTE
            btn_guardar.Enabled = true;

            btn_modificar.Visible = true;   // opcional
            btn_modificar.Enabled = false;

            // Si tu botón se llama btn_nuevo (no "BtnNuevo")
            BtnNuevo.Enabled = false;      // 👈 ajusta al nombre real

            btn_guardar.BringToFront();     // 👈 por si estaba tapado
            txt_nom.Focus();

            btn_CargarFoto.Enabled = true;
            btn_CargarFoto.Visible = true;

        }


        /* =========================
           GRID: cargar / buscar
        ========================= */
        private void LoadGrid(string search)
        {
            try
            {
                _loading = true;

                using (SqlConnection con = Db.GetConnection())
                using (SqlCommand cmd = new SqlCommand($@"
                    SELECT
                        id_identificador,
                        nombre_producto,
                        categoria,
                        descripcion,
                        cantidad,
                        precio,
                        ubicacion,
                        proveedor,
                        fecha_ingreso,
                        estado,
                        responsable,
                        foto_producto
                    FROM {TABLE}
                    WHERE (@q = '' OR
                           nombre_producto LIKE '%' + @q + '%' OR
                           categoria LIKE '%' + @q + '%' OR
                           proveedor LIKE '%' + @q + '%' OR
                           CAST(id_identificador AS NVARCHAR(30)) LIKE '%' + @q + '%')
                    ORDER BY id_identificador DESC;", con))
                {
                    cmd.Parameters.Add("@q", SqlDbType.NVarChar, 100).Value = search ?? "";

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                        dataGridView1.ReadOnly = true;
                        dataGridView1.MultiSelect = false;
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }

                if (dataGridView1.Rows.Count == 0)
                {
                    SetMode(Mode.View);
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("💥 Error cargando inventario: " + ex.Message, "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _loading = false;
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            if (dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow.DataBoundItem == null) return;

            var row = dataGridView1.CurrentRow;

            txt_id.Text = row.Cells["id_identificador"].Value?.ToString() ?? "";
            txt_nom.Text = row.Cells["nombre_producto"].Value?.ToString() ?? "";
            txt_categ.Text = row.Cells["categoria"].Value?.ToString() ?? "";
            txt_descrip.Text = row.Cells["descripcion"].Value?.ToString() ?? "";
            txt_cant.Text = row.Cells["cantidad"].Value?.ToString() ?? "";
            txt_prec.Text = row.Cells["precio"].Value?.ToString() ?? "";
            txt_ubi.Text = row.Cells["ubicacion"].Value?.ToString() ?? "";
            txt_prove.Text = row.Cells["proveedor"].Value?.ToString() ?? "";
            txt_feing.Text = FormatDate(row.Cells["fecha_ingreso"].Value);
            txt_est.Text = row.Cells["estado"].Value?.ToString() ?? "";
            txt_resp.Text = row.Cells["responsable"].Value?.ToString() ?? "";
            pb_foto.Text = row.Cells["foto_producto"].Value?.ToString() ?? "";

            SetMode(Mode.Edit);
        }

        private string FormatDate(object value)
        {
            if (value == null || value == DBNull.Value) return "";
            if (value is DateTime dt) return dt.ToString("yyyy-MM-dd");
            return value.ToString();
        }

        /* =========================
           VALIDACIÓN OBLIGATORIA
        ========================= */
        private bool ValidateRequired(out string msg)
        {
            msg = "";

            if (string.IsNullOrWhiteSpace(txt_nom.Text)) return Fail("Falta Nombre del producto.", out msg);
            if (string.IsNullOrWhiteSpace(txt_categ.Text)) return Fail("Falta Categoría.", out msg);
            if (string.IsNullOrWhiteSpace(txt_descrip.Text)) return Fail("Falta Descripción.", out msg);
            if (string.IsNullOrWhiteSpace(txt_cant.Text)) return Fail("Falta Cantidad.", out msg);
            if (string.IsNullOrWhiteSpace(txt_prec.Text)) return Fail("Falta Precio.", out msg);
            if (string.IsNullOrWhiteSpace(txt_ubi.Text)) return Fail("Falta ubicacion.", out msg);
            if (string.IsNullOrWhiteSpace(txt_prove.Text)) return Fail("Falta Proveedor.", out msg);
            if (string.IsNullOrWhiteSpace(txt_feing.Text)) return Fail("Falta Fecha de ingreso.", out msg);
            if (string.IsNullOrWhiteSpace(txt_est.Text)) return Fail("Falta Estado.", out msg);
            if (string.IsNullOrWhiteSpace(txt_resp.Text)) return Fail("Falta Responsable.", out msg);
            if (pb_foto.Image == null) return Fail("Falta Imagen", out msg);



            if (!int.TryParse(txt_cant.Text.Trim(), out int cant) || cant <= 0)
                return Fail("Cantidad inválida (número > 0).", out msg);

            if (!TryParseDecimal(txt_prec.Text.Trim(), out decimal precio) || precio <= 0)
                return Fail("Precio inválido (número > 0).", out msg);

            if (!DateTime.TryParse(txt_feing.Text.Trim(), out _))
                return Fail("Fecha inválida. Usa yyyy-MM-dd (ej: 2026-02-03).", out msg);

            return true;
        }

        private bool Fail(string text, out string msg)
        {
            msg = text;
            return false;
        }

        /* =========================
           GUARDAR: INSERT + ID AUTO
        ========================= */
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (_mode != Mode.New) return;

            if (!ValidateRequired(out string msg))
            {
                MessageBox.Show("⚠️ " + msg, "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryReadInputs(out var p, out string msg2))
            {
                MessageBox.Show("⚠️ " + msg2, "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = Db.GetConnection())
                using (SqlCommand cmd = new SqlCommand($@"
                    INSERT INTO {TABLE}
                    (nombre_producto, categoria, descripcion, cantidad, precio, ubicacion, proveedor, fecha_ingreso, estado, responsable, foto_producto)
                    VALUES
                    (@nombre, @categoria, @descripcion, @cantidad, @precio, @ubicacion, @proveedor, @fecha, @estado, @responsable @foto_producto);

                    SELECT CAST(SCOPE_IDENTITY() AS INT);", con))
                {
                    FillParams(cmd, p);

                    con.Open();
                    int newId = (int)cmd.ExecuteScalar(); // ✅ ID generado
                    txt_id.Text = newId.ToString();
                }

                MessageBox.Show("✅ Producto guardado.", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SetMode(Mode.View);
                LoadGrid(txt_buscar.Text.Trim());
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("💥 Error al guardar: " + ex.Message, "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* =========================
           MODIFICAR: UPDATE
        ========================= */
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (_mode != Mode.Edit) return;

            if (!int.TryParse(txt_id.Text.Trim(), out int id) || id <= 0)
            {
                MessageBox.Show("⚠️ Selecciona un producto válido.", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateRequired(out string msg))
            {
                MessageBox.Show("⚠️ " + msg, "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryReadInputs(out var p, out string msg2))
            {
                MessageBox.Show("⚠️ " + msg2, "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = Db.GetConnection())
                using (SqlCommand cmd = new SqlCommand($@"
                    UPDATE {TABLE}
                    SET
                        nombre_producto = @nombre,
                        categoria = @categoria,
                        descripcion = @descripcion,
                        cantidad = @cantidad,
                        precio = @precio,
                        ubicacion = @ubicacion,
                        proveedor = @proveedor,
                        fecha_ingreso = @fecha,
                        estado = @estado,
                        responsable = @responsable,
                        pb_foto = @foto_producto
                    WHERE id_identificador = @id;", con))
                {
                    FillParams(cmd, p);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows == 0)
                    {
                        MessageBox.Show("⚠️ No se encontró el producto.", "ScanDent",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                MessageBox.Show("✅ Producto modificado.", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SetMode(Mode.View);
                LoadGrid(txt_buscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("💥 Error al modificar: " + ex.Message, "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* =========================
           Inputs -> Modelo
        ========================= */
        private sealed class ProductInput
        {
            public string Nombre;
            public string Categoria;
            public string Descripcion;
            public int Cantidad;
            public decimal Precio;
            public string ubicacion;
            public string Proveedor;
            public DateTime FechaIngreso;
            public string Estado;
            public string Responsable;
            public string pb_foto;
        }

        private bool TryReadInputs(out ProductInput p, out string error)
        {
            p = new ProductInput();
            error = "";

            p.Nombre = txt_nom.Text.Trim();
            p.Categoria = txt_categ.Text.Trim();
            p.Descripcion = txt_descrip.Text.Trim();
            p.ubicacion = txt_ubi.Text.Trim();
            p.Proveedor = txt_prove.Text.Trim();
            p.Estado = txt_est.Text.Trim();
            p.Responsable = txt_resp.Text.Trim();
            p.pb_foto = pb_foto.Text.Trim();

            if (!int.TryParse(txt_cant.Text.Trim(), out int cant))
            {
                error = "Cantidad inválida.";
                return false;
            }
            p.Cantidad = cant;

            if (!TryParseDecimal(txt_prec.Text.Trim(), out decimal precio))
            {
                error = "Precio inválido.";
                return false;
            }
            p.Precio = precio;

            if (!DateTime.TryParse(txt_feing.Text.Trim(), out DateTime fin))
            {
                error = "Fecha inválida.";
                return false;
            }
            p.FechaIngreso = fin.Date;

            return true;
        }

        private static bool TryParseDecimal(string s, out decimal value)
        {
            if (decimal.TryParse(s, NumberStyles.Number, CultureInfo.CurrentCulture, out value))
                return true;

            return decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out value);
        }

        private void FillParams(SqlCommand cmd, ProductInput p)
        {
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = p.Nombre;
            cmd.Parameters.Add("@categoria", SqlDbType.VarChar, 50).Value = p.Categoria;
            cmd.Parameters.Add("@descripcion", SqlDbType.Text).Value = p.Descripcion;
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = p.Cantidad;

            var parPrecio = cmd.Parameters.Add("@precio", SqlDbType.Decimal);
            parPrecio.Value = p.Precio;
            parPrecio.Precision = 10;
            parPrecio.Scale = 2;

            cmd.Parameters.Add("@ubicacion", SqlDbType.VarChar, 100).Value = p.ubicacion;
            cmd.Parameters.Add("@proveedor", SqlDbType.VarChar, 100).Value = p.Proveedor;
            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = p.FechaIngreso;
            cmd.Parameters.Add("@estado", SqlDbType.VarChar, 30).Value = p.Estado;
            cmd.Parameters.Add("@responsable", SqlDbType.VarChar, 100).Value = p.Responsable;
            cmd.Parameters.Add("@foto_producto", SqlDbType.VarBinary, fotoBytes.Length).Value = fotoBytes;

        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_loading) return;
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            txt_id.Text = row.Cells["id_identificador"].Value?.ToString() ?? "";
            txt_nom.Text = row.Cells["nombre_producto"].Value?.ToString() ?? "";
            txt_categ.Text = row.Cells["categoria"].Value?.ToString() ?? "";
            txt_descrip.Text = row.Cells["descripcion"].Value?.ToString() ?? "";
            txt_cant.Text = row.Cells["cantidad"].Value?.ToString() ?? "";
            txt_prec.Text = row.Cells["precio"].Value?.ToString() ?? "";
            txt_ubi.Text = row.Cells["ubicacion"].Value?.ToString() ?? "";
            txt_prove.Text = row.Cells["proveedor"].Value?.ToString() ?? "";
            txt_feing.Text = FormatDate(row.Cells["fecha_ingreso"].Value);
            txt_est.Text = row.Cells["estado"].Value?.ToString() ?? "";
            txt_resp.Text = row.Cells["responsable"].Value?.ToString() ?? "";
            pb_foto.Text = row.Cells["foto_producto"].Value?.ToString() ?? "";


            // 🔒 MODO SOLO LECTURA
            _mode = Mode.View;
            SetInputsEnabled(false);

            // 🎛 Botones
            btn_modificar.Enabled = true;
            btn_modificar.Visible = true;

            btn_guardar.Visible = false;
            BtnNuevo.Visible = false;
            btn_limpiar.Enabled = false;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
           btn_limpiar.Enabled = true;
            btn_limpiar.Visible = true;
            BtnNuevo.Enabled = false;


        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btn_actulizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_id.Text))
            {
                MessageBox.Show("Selecciona un producto primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _mode = Mode.Edit;

            // ✨ Habilitar edición
            SetInputsEnabled(true);

            // 🎛 Botones
            btn_actulizar.Visible = true;
            btn_guardar.Visible = false;

            btn_modificar.Enabled = false;
            btn_limpiar.Enabled = true;

            txt_nom.Focus();

            if (_mode != Mode.Edit) return;

            // AQUÍ VA TU UPDATE SQL
            // UpdateProducto();

            MessageBox.Show("Producto actualizado correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 🔒 Volver a solo lectura
            _mode = Mode.View;
            SetInputsEnabled(false);

            btn_actulizar.Visible = false;
            btn_modificar.Enabled = true;
            btn_limpiar.Enabled = false;

            // Refrescar grid si quieres
            // CargarProductos();

        }
        

        private void btn_CargarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imágenes|*.jpg;*.jpeg;*.png";
            openFileDialog1.Title = "Selecciona una imagen";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(openFileDialog1.FileName);

                // Máx 3MB
                if (fi.Length > 3 * 1024 * 1024)
                {
                    MessageBox.Show("La imagen no debe superar 3 MB",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                pb_foto.Image = Image.FromFile(openFileDialog1.FileName);
                fotoBytes = File.ReadAllBytes(openFileDialog1.FileName);
            }
        }

    }
}
