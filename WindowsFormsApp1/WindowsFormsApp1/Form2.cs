using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private const string TABLE = "dbo.inv_scandent";

        private bool _loading = false;
        private byte[] _fotoBytes = null;

        private enum Mode { View, New, Edit }
        private Mode _mode = Mode.View;

        // ✅ Tipos para pestañas (1 = consumibles, 2 = no consumibles)
        private enum TipoInventario : byte
        {
            Consumibles = 1,
            NoConsumibles = 2
        }

        private TipoInventario _tipoActual = TipoInventario.Consumibles;

        public Form2()
        {
            InitializeComponent();

            // ✅ eventos (sin duplicar)
            this.Load += Form2_Load;

            txt_buscar.TextChanged += (s, e) => LoadGrid(txt_buscar.Text.Trim());

            dataGridView1.CellClick += dataGridView1_CellClick;

            BtnNuevo.Click += BtnNuevo_Click;
            btn_guardar.Click += BtnGuardar_Click;

            // ✅ Un solo botón: si estás en View -> entra a Edit; si ya estás en Edit -> actualiza
            btn_actulizar.Click += BtnEditarOActualizar_Click;

            btn_limpiar.Click += (s, e) =>
            {
                ClearInputs();
                SetMode(Mode.View);
            };

            pb_foto.Click += PbFoto_Click;

            // ✅ pestañas: esto SIEMPRE funciona aunque no aparezca en eventos
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Textos bonitos
            if (tabControl1.TabPages.Count >= 2)
            {
                tabControl1.TabPages[0].Text = "Consumibles";
                tabControl1.TabPages[1].Text = "No consumibles";
            }

            ApplyTipoFromTab();
            SetMode(Mode.View);
            LoadGrid("");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyTipoFromTab();
            ClearInputs();
            SetMode(Mode.View);
            LoadGrid(txt_buscar.Text.Trim());
        }

        private void ApplyTipoFromTab()
        {
            _tipoActual = (tabControl1.SelectedIndex == 0)
                ? TipoInventario.Consumibles
                : TipoInventario.NoConsumibles;
        }

        private void SetTabByTipo(byte tipo)
        {
            if (tipo == (byte)TipoInventario.NoConsumibles)
                tabControl1.SelectedIndex = 1;
            else
                tabControl1.SelectedIndex = 0;

            ApplyTipoFromTab();
        }

        /* =========================
           MODOS UI
        ========================= */
        private void SetMode(Mode mode)
        {
            _mode = mode;

            bool edit = (mode == Mode.New || mode == Mode.Edit);

            txt_id.Enabled = false;

            txt_nom.Enabled = edit;
            txt_categ.Enabled = edit;
            txt_ubi.Enabled = edit;
            txt_cant.Enabled = edit;
            txt_prec.Enabled = edit;

            txt_prov_prod.Enabled = edit;
            txt_Protel.Enabled = edit;
            txt_prov_dir.Enabled = edit;

            txt_feing.Enabled = edit;
            txt_fechaegre.Enabled = edit;

            txt_est.Enabled = edit;
            txt_resp.Enabled = edit;

            pb_foto.Enabled = edit;

            // ✅ botones
            BtnNuevo.Enabled = (mode != Mode.New);
            btn_guardar.Enabled = (mode == Mode.New);

            // btn_actulizar siempre disponible si hay selección o si estás editando
            btn_actulizar.Enabled = (mode != Mode.New);
        }

        private void ClearInputs()
        {
            txt_id.Clear();
            txt_nom.Clear();
            txt_categ.Clear();
            txt_ubi.Clear();

            txt_cant.Clear();
            txt_prec.Clear();

            txt_prov_prod.Clear();
            txt_Protel.Clear();
            txt_prov_dir.Clear();

            txt_feing.Clear();
            txt_fechaegre.Clear();

            txt_est.Clear();
            txt_resp.Clear();

            pb_foto.Image = null;
            _fotoBytes = null;
        }

        /* =========================
           GRID
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
                        ubicacion,
                        descripcion,
                        cantidad,
                        precio,
                        proveedor,
                        proveedor_telefono,
                        proveedor_direccion,
                        proveedor_producto,
                        fecha_ingreso,
                        fecha_egreso,
                        estado,
                        responsable,
                        foto_producto,
                        knu,
                        tipo_inventario
                    FROM {TABLE}
                    WHERE tipo_inventario = @tipo
                      AND (@q = '' OR
                           nombre_producto LIKE '%' + @q + '%' OR
                           categoria LIKE '%' + @q + '%' OR
                           proveedor LIKE '%' + @q + '%' OR
                           CAST(id_identificador AS NVARCHAR(30)) LIKE '%' + @q + '%')
                    ORDER BY id_identificador DESC;", con))
                {
                    cmd.Parameters.Add("@q", SqlDbType.NVarChar, 100).Value = search ?? "";
                    cmd.Parameters.Add("@tipo", SqlDbType.TinyInt).Value = (byte)_tipoActual;

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_loading) return;
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            txt_id.Text = row.Cells["id_identificador"].Value?.ToString() ?? "";
            txt_nom.Text = row.Cells["nombre_producto"].Value?.ToString() ?? "";
            txt_categ.Text = row.Cells["categoria"].Value?.ToString() ?? "";
            txt_ubi.Text = row.Cells["ubicacion"].Value?.ToString() ?? "";

            txt_cant.Text = row.Cells["cantidad"].Value?.ToString() ?? "";
            txt_prec.Text = row.Cells["precio"].Value?.ToString() ?? "";

            txt_prov_prod.Text = row.Cells["proveedor"].Value?.ToString() ?? "";
            txt_Protel.Text = row.Cells["proveedor_telefono"].Value?.ToString() ?? "";
            txt_prov_dir.Text = row.Cells["proveedor_direccion"].Value?.ToString() ?? "";

            txt_feing.Text = FormatDate(row.Cells["fecha_ingreso"].Value);
            txt_fechaegre.Text = FormatDate(row.Cells["fecha_egreso"].Value);

            txt_est.Text = row.Cells["estado"].Value?.ToString() ?? "";
            txt_resp.Text = row.Cells["responsable"].Value?.ToString() ?? "";

            // ✅ si la fila trae tipo, ajusta la pestaña (pro)
            if (row.Cells["tipo_inventario"].Value != null && row.Cells["tipo_inventario"].Value != DBNull.Value)
            {
                byte tipo = Convert.ToByte(row.Cells["tipo_inventario"].Value);
                SetTabByTipo(tipo);
            }

            // foto_producto VARBINARY -> Image
            object bin = row.Cells["foto_producto"].Value;
            if (bin != null && bin != DBNull.Value)
            {
                _fotoBytes = (byte[])bin;
                pb_foto.Image = BytesToImageSafe(_fotoBytes);
            }
            else
            {
                _fotoBytes = null;
                pb_foto.Image = null;
            }

            SetMode(Mode.View);
        }

        private string FormatDate(object value)
        {
            if (value == null || value == DBNull.Value) return "";
            if (value is DateTime dt) return dt.ToString("yyyy-MM-dd");
            return value.ToString();
        }

        private Image BytesToImageSafe(byte[] bytes)
        {
            try
            {
                if (bytes == null || bytes.Length == 0) return null;
                using (var ms = new MemoryStream(bytes))
                    return Image.FromStream(ms);
            }
            catch { return null; }
        }

        /* =========================
           BOTONES
        ========================= */
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ClearInputs();
            ApplyTipoFromTab();
            SetMode(Mode.New);

            // opcional: fecha ingreso por default
            if (string.IsNullOrWhiteSpace(txt_feing.Text))
                txt_feing.Text = DateTime.Now.ToString("yyyy-MM-dd");

            txt_nom.Focus();
        }

        private void BtnEditarOActualizar_Click(object sender, EventArgs e)
        {
            // Si no hay selección
            if (!int.TryParse(txt_id.Text.Trim(), out int id) || id <= 0)
            {
                MessageBox.Show("⚠️ Selecciona un producto primero.", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si estoy en View -> paso a Edit
            if (_mode == Mode.View)
            {
                SetMode(Mode.Edit);
                txt_nom.Focus();
                return;
            }

            // Si estoy en Edit -> hago UPDATE
            if (_mode == Mode.Edit)
            {
                Actualizar(id);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (_mode != Mode.New) return;

            if (!ValidateRequired(out string msg))
            {
                MessageBox.Show("⚠️ " + msg, "ScanDent", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string knu = GenerateKnu(txt_nom.Text, txt_categ.Text, txt_prov_prod.Text);

            try
            {
                using (SqlConnection con = Db.GetConnection())
                using (SqlCommand cmd = new SqlCommand($@"
                    INSERT INTO {TABLE}
                    (nombre_producto, categoria, ubicacion, descripcion, cantidad, precio,
                     proveedor, proveedor_telefono, proveedor_direccion, proveedor_producto,
                     fecha_ingreso, fecha_egreso, estado, responsable, foto_producto, knu, tipo_inventario)
                    VALUES
                    (@nombre, @categoria, @ubicacion, @descripcion, @cantidad, @precio,
                     @proveedor, @prov_tel, @prov_dir, @prov_prod,
                     @feing, @fegre, @estado, @responsable, @foto, @knu, @tipo);

                    SELECT CAST(SCOPE_IDENTITY() AS INT);", con))
                {
                    FillParams(cmd, knu);

                    con.Open();
                    int newId = Convert.ToInt32(cmd.ExecuteScalar());
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

        private void Actualizar(int id)
        {
            if (!ValidateRequired(out string msg))
            {
                MessageBox.Show("⚠️ " + msg, "ScanDent", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si ya existe un knu en BD, lo respetamos; si no, lo generamos
            string knu = GenerateKnu(txt_nom.Text, txt_categ.Text, txt_prov_prod.Text);

            try
            {
                using (SqlConnection con = Db.GetConnection())
                using (SqlCommand cmd = new SqlCommand($@"
                    UPDATE {TABLE}
                    SET
                        nombre_producto      = @nombre,
                        categoria            = @categoria,
                        ubicacion            = @ubicacion,
                        descripcion          = @descripcion,
                        cantidad             = @cantidad,
                        precio               = @precio,
                        proveedor            = @proveedor,
                        proveedor_telefono   = @prov_tel,
                        proveedor_direccion  = @prov_dir,
                        proveedor_producto   = @prov_prod,
                        fecha_ingreso        = @feing,
                        fecha_egreso         = @fegre,
                        estado               = @estado,
                        responsable          = @responsable,
                        foto_producto        = @foto,
                        knu                  = @knu,
                        tipo_inventario      = @tipo
                    WHERE id_identificador = @id;", con))
                {
                    FillParams(cmd, knu);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✅ Producto actualizado.", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SetMode(Mode.View);
                LoadGrid(txt_buscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("💥 Error al actualizar: " + ex.Message, "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* =========================
           VALIDACIÓN + PARAMS
        ========================= */
        private bool ValidateRequired(out string msg)
        {
            msg = "";

            if (string.IsNullOrWhiteSpace(txt_nom.Text)) return Fail("Falta Producto.", out msg);
            if (string.IsNullOrWhiteSpace(txt_categ.Text)) return Fail("Falta Categoría.", out msg);
            if (string.IsNullOrWhiteSpace(txt_ubi.Text)) return Fail("Falta Ubicación.", out msg);

            if (string.IsNullOrWhiteSpace(txt_cant.Text)) return Fail("Falta Stock/Cantidad.", out msg);
            if (string.IsNullOrWhiteSpace(txt_prec.Text)) return Fail("Falta Precio.", out msg);

            if (string.IsNullOrWhiteSpace(txt_prov_prod.Text)) return Fail("Falta Proveedor.", out msg);
            if (string.IsNullOrWhiteSpace(txt_feing.Text)) return Fail("Falta Fecha ingreso.", out msg);
            if (string.IsNullOrWhiteSpace(txt_est.Text)) return Fail("Falta Estado.", out msg);
            if (string.IsNullOrWhiteSpace(txt_resp.Text)) return Fail("Falta Responsable.", out msg);

            if (!int.TryParse(txt_cant.Text.Trim(), out int cant) || cant <= 0)
                return Fail("Cantidad inválida.", out msg);

            if (!TryParseDecimal(txt_prec.Text.Trim(), out decimal precio) || precio <= 0)
                return Fail("Precio inválido.", out msg);

            if (!DateTime.TryParse(txt_feing.Text.Trim(), out _))
                return Fail("Fecha ingreso inválida (yyyy-MM-dd).", out msg);

            if (_fotoBytes == null || _fotoBytes.Length == 0)
                return Fail("Falta foto (da click en la imagen).", out msg);

            return true;
        }

        private bool Fail(string text, out string msg) { msg = text; return false; }

        private static bool TryParseDecimal(string s, out decimal value)
        {
            // intenta con cultura actual y con Invariant (por si usas punto/coma)
            if (decimal.TryParse(s, NumberStyles.Number, CultureInfo.CurrentCulture, out value))
                return true;
            return decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out value);
        }

        private void FillParams(SqlCommand cmd, string knu)
        {
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar, 150).Value = txt_nom.Text.Trim();
            cmd.Parameters.Add("@categoria", SqlDbType.NVarChar, 100).Value = txt_categ.Text.Trim();
            cmd.Parameters.Add("@ubicacion", SqlDbType.NVarChar, 100).Value = txt_ubi.Text.Trim();

            // ✅ si no tienes textbox descripción, dejamos vacío
            cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar, 300).Value = "";

            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = int.Parse(txt_cant.Text.Trim());

            // decimal robusto
            if (!TryParseDecimal(txt_prec.Text.Trim(), out decimal precio)) precio = 0;
            var pPrecio = cmd.Parameters.Add("@precio", SqlDbType.Decimal);
            pPrecio.Precision = 10;
            pPrecio.Scale = 2;
            pPrecio.Value = precio;

            // ✅ proveedor (si luego separas tablas, aquí cambiaremos a proveedor_id)
            cmd.Parameters.Add("@proveedor", SqlDbType.NVarChar, 100).Value = txt_prov_prod.Text.Trim();
            cmd.Parameters.Add("@prov_tel", SqlDbType.NVarChar, 30).Value = (object)txt_Protel.Text.Trim() ?? DBNull.Value;
            cmd.Parameters.Add("@prov_dir", SqlDbType.NVarChar, 200).Value = (object)txt_prov_dir.Text.Trim() ?? DBNull.Value;

            // por ahora lo dejamos igual al proveedor (si luego haces textbox separado, lo conectamos)
            cmd.Parameters.Add("@prov_prod", SqlDbType.NVarChar, 100).Value = txt_prov_prod.Text.Trim();

            cmd.Parameters.Add("@feing", SqlDbType.Date).Value = DateTime.Parse(txt_feing.Text.Trim()).Date;

            if (DateTime.TryParse(txt_fechaegre.Text.Trim(), out var feg))
                cmd.Parameters.Add("@fegre", SqlDbType.Date).Value = feg.Date;
            else
                cmd.Parameters.Add("@fegre", SqlDbType.Date).Value = DBNull.Value;

            cmd.Parameters.Add("@estado", SqlDbType.NVarChar, 50).Value = txt_est.Text.Trim();
            cmd.Parameters.Add("@responsable", SqlDbType.NVarChar, 100).Value = txt_resp.Text.Trim();

            cmd.Parameters.Add("@knu", SqlDbType.NVarChar, 30).Value = (object)knu ?? DBNull.Value;

            // foto varbinary(max)
            cmd.Parameters.Add("@foto", SqlDbType.VarBinary, -1).Value =
                (_fotoBytes == null || _fotoBytes.Length == 0) ? (object)DBNull.Value : _fotoBytes;

            // tipo inventario por pestaña
            cmd.Parameters.Add("@tipo", SqlDbType.TinyInt).Value = (byte)_tipoActual;
        }

        /* =========================
           FOTO
        ========================= */
        private void PbFoto_Click(object sender, EventArgs e)
        {
            if (_mode == Mode.View)
            {
                MessageBox.Show("Ponlo en Nuevo o Editar para cambiar la foto 😉", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            openFileDialog1.Filter = "Imágenes|*.jpg;*.jpeg;*.png";
            openFileDialog1.Title = "Selecciona una imagen";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(openFileDialog1.FileName);

                if (fi.Length > 3 * 1024 * 1024)
                {
                    MessageBox.Show("La imagen no debe superar 3 MB", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                pb_foto.Image = Image.FromFile(openFileDialog1.FileName);
                _fotoBytes = File.ReadAllBytes(openFileDialog1.FileName);
            }
        }

        /* =========================
           KNU
        ========================= */
        private string GenerateKnu(string nombre, string categoria, string proveedor)
        {
            string n = TakeLetters(nombre, 2);
            string c = TakeLetters(categoria, 2);
            string p = TakeLetters(proveedor, 1);

            string baseKnu = (n + c + p).ToUpperInvariant();
            if (baseKnu.Length < 5) baseKnu = baseKnu.PadRight(5, 'X');

            // si ya existe, le agregamos 2 dígitos random
            string knu = baseKnu;
            int tries = 0;
            var rnd = new Random();

            while (KnuExists(knu) && tries < 30)
            {
                knu = baseKnu + rnd.Next(10, 99).ToString();
                tries++;
            }

            return knu;
        }

        private string TakeLetters(string s, int count)
        {
            if (string.IsNullOrWhiteSpace(s)) return new string('X', count);
            var letters = new string(s.Where(char.IsLetter).ToArray());
            if (letters.Length == 0) return new string('X', count);
            letters = letters.ToUpperInvariant();
            return letters.Length >= count ? letters.Substring(0, count) : letters.PadRight(count, 'X');
        }

        private bool KnuExists(string knu)
        {
            try
            {
                using (var con = Db.GetConnection())
                using (var cmd = new SqlCommand($"SELECT COUNT(1) FROM {TABLE} WHERE knu = @k", con))
                {
                    cmd.Parameters.Add("@k", SqlDbType.NVarChar, 30).Value = knu;
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch { return false; }
        }
    }
}