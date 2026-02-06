namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prec = new System.Windows.Forms.TextBox();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.txt_ubi = new System.Windows.Forms.TextBox();
            this.txt_categ = new System.Windows.Forms.TextBox();
            this.txt_resp = new System.Windows.Forms.TextBox();
            this.txt_est = new System.Windows.Forms.TextBox();
            this.txt_feing = new System.Windows.Forms.TextBox();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.txt_prove = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.Label();
            this.txt_cate = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.Label();
            this.txt_provee = new System.Windows.Forms.Label();
            this.txt_ubicacion = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.Label();
            this.txt_canti = new System.Windows.Forms.Label();
            this.txt_esatdo = new System.Windows.Forms.Label();
            this.txt_fechaing = new System.Windows.Forms.Label();
            this.txt_respo = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_actulizar = new System.Windows.Forms.Button();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.btn_CargarFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(296, 485);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 28);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(424, 485);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(100, 28);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Info;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(295, 123);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(132, 22);
            this.txt_id.TabIndex = 0;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.Info;
            this.txt_nom.Enabled = false;
            this.txt_nom.Location = new System.Drawing.Point(476, 123);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(132, 22);
            this.txt_nom.TabIndex = 1;
            this.txt_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_prec
            // 
            this.txt_prec.BackColor = System.Drawing.SystemColors.Info;
            this.txt_prec.Enabled = false;
            this.txt_prec.Location = new System.Drawing.Point(476, 212);
            this.txt_prec.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prec.Name = "txt_prec";
            this.txt_prec.Size = new System.Drawing.Size(132, 22);
            this.txt_prec.TabIndex = 5;
            this.txt_prec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cant
            // 
            this.txt_cant.BackColor = System.Drawing.SystemColors.Info;
            this.txt_cant.Enabled = false;
            this.txt_cant.Location = new System.Drawing.Point(295, 212);
            this.txt_cant.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(132, 22);
            this.txt_cant.TabIndex = 4;
            this.txt_cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ubi
            // 
            this.txt_ubi.BackColor = System.Drawing.SystemColors.Info;
            this.txt_ubi.Enabled = false;
            this.txt_ubi.Location = new System.Drawing.Point(649, 212);
            this.txt_ubi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ubi.Name = "txt_ubi";
            this.txt_ubi.Size = new System.Drawing.Size(132, 22);
            this.txt_ubi.TabIndex = 6;
            this.txt_ubi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_categ
            // 
            this.txt_categ.BackColor = System.Drawing.SystemColors.Info;
            this.txt_categ.Enabled = false;
            this.txt_categ.Location = new System.Drawing.Point(649, 123);
            this.txt_categ.Margin = new System.Windows.Forms.Padding(4);
            this.txt_categ.Name = "txt_categ";
            this.txt_categ.Size = new System.Drawing.Size(132, 22);
            this.txt_categ.TabIndex = 2;
            this.txt_categ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_resp
            // 
            this.txt_resp.BackColor = System.Drawing.SystemColors.Info;
            this.txt_resp.Enabled = false;
            this.txt_resp.Location = new System.Drawing.Point(649, 287);
            this.txt_resp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_resp.Name = "txt_resp";
            this.txt_resp.Size = new System.Drawing.Size(132, 22);
            this.txt_resp.TabIndex = 10;
            this.txt_resp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_est
            // 
            this.txt_est.BackColor = System.Drawing.SystemColors.Info;
            this.txt_est.Enabled = false;
            this.txt_est.Location = new System.Drawing.Point(476, 287);
            this.txt_est.Margin = new System.Windows.Forms.Padding(4);
            this.txt_est.Name = "txt_est";
            this.txt_est.Size = new System.Drawing.Size(132, 22);
            this.txt_est.TabIndex = 9;
            this.txt_est.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_feing
            // 
            this.txt_feing.BackColor = System.Drawing.SystemColors.Info;
            this.txt_feing.Enabled = false;
            this.txt_feing.Location = new System.Drawing.Point(295, 287);
            this.txt_feing.Margin = new System.Windows.Forms.Padding(4);
            this.txt_feing.Name = "txt_feing";
            this.txt_feing.Size = new System.Drawing.Size(132, 22);
            this.txt_feing.TabIndex = 8;
            this.txt_feing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_descrip
            // 
            this.txt_descrip.BackColor = System.Drawing.SystemColors.Info;
            this.txt_descrip.Enabled = false;
            this.txt_descrip.Location = new System.Drawing.Point(812, 123);
            this.txt_descrip.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(132, 22);
            this.txt_descrip.TabIndex = 3;
            this.txt_descrip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_prove
            // 
            this.txt_prove.BackColor = System.Drawing.SystemColors.Info;
            this.txt_prove.Enabled = false;
            this.txt_prove.Location = new System.Drawing.Point(812, 212);
            this.txt_prove.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prove.Name = "txt_prove";
            this.txt_prove.Size = new System.Drawing.Size(132, 22);
            this.txt_prove.TabIndex = 7;
            this.txt_prove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(287, 194);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_buscar.Location = new System.Drawing.Point(295, 32);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(313, 22);
            this.txt_buscar.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Producto";
            // 
            // txt_nombre
            // 
            this.txt_nombre.AutoSize = true;
            this.txt_nombre.Location = new System.Drawing.Point(503, 103);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(56, 16);
            this.txt_nombre.TabIndex = 16;
            this.txt_nombre.Text = "Nombre";
            // 
            // txt_cate
            // 
            this.txt_cate.AutoSize = true;
            this.txt_cate.Location = new System.Drawing.Point(681, 103);
            this.txt_cate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_cate.Name = "txt_cate";
            this.txt_cate.Size = new System.Drawing.Size(66, 16);
            this.txt_cate.TabIndex = 17;
            this.txt_cate.Text = "Categoría";
            // 
            // txt_desc
            // 
            this.txt_desc.AutoSize = true;
            this.txt_desc.Location = new System.Drawing.Point(843, 103);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(79, 16);
            this.txt_desc.TabIndex = 18;
            this.txt_desc.Text = "Descripción";
            // 
            // txt_provee
            // 
            this.txt_provee.AutoSize = true;
            this.txt_provee.Location = new System.Drawing.Point(843, 192);
            this.txt_provee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_provee.Name = "txt_provee";
            this.txt_provee.Size = new System.Drawing.Size(71, 16);
            this.txt_provee.TabIndex = 22;
            this.txt_provee.Text = "Proveedor";
            // 
            // txt_ubicacion
            // 
            this.txt_ubicacion.AutoSize = true;
            this.txt_ubicacion.Location = new System.Drawing.Point(681, 192);
            this.txt_ubicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.Size = new System.Drawing.Size(68, 16);
            this.txt_ubicacion.TabIndex = 21;
            this.txt_ubicacion.Text = "Ubicación";
            // 
            // txt_precio
            // 
            this.txt_precio.AutoSize = true;
            this.txt_precio.Location = new System.Drawing.Point(503, 192);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(46, 16);
            this.txt_precio.TabIndex = 20;
            this.txt_precio.Text = "Precio";
            // 
            // txt_canti
            // 
            this.txt_canti.AutoSize = true;
            this.txt_canti.Location = new System.Drawing.Point(331, 192);
            this.txt_canti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_canti.Name = "txt_canti";
            this.txt_canti.Size = new System.Drawing.Size(61, 16);
            this.txt_canti.TabIndex = 19;
            this.txt_canti.Text = "Cantidad";
            // 
            // txt_esatdo
            // 
            this.txt_esatdo.AutoSize = true;
            this.txt_esatdo.Location = new System.Drawing.Point(503, 267);
            this.txt_esatdo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_esatdo.Name = "txt_esatdo";
            this.txt_esatdo.Size = new System.Drawing.Size(50, 16);
            this.txt_esatdo.TabIndex = 24;
            this.txt_esatdo.Text = "Estado";
            // 
            // txt_fechaing
            // 
            this.txt_fechaing.AutoSize = true;
            this.txt_fechaing.Location = new System.Drawing.Point(309, 267);
            this.txt_fechaing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_fechaing.Name = "txt_fechaing";
            this.txt_fechaing.Size = new System.Drawing.Size(112, 16);
            this.txt_fechaing.TabIndex = 23;
            this.txt_fechaing.Text = "Fecha de ingreso";
            // 
            // txt_respo
            // 
            this.txt_respo.AutoSize = true;
            this.txt_respo.Location = new System.Drawing.Point(661, 267);
            this.txt_respo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_respo.Name = "txt_respo";
            this.txt_respo.Size = new System.Drawing.Size(89, 16);
            this.txt_respo.TabIndex = 25;
            this.txt_respo.Text = "Responsable";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(295, 485);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(100, 28);
            this.BtnNuevo.TabIndex = 11;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(424, 485);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 28);
            this.btn_limpiar.TabIndex = 26;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Visible = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_actulizar
            // 
            this.btn_actulizar.Location = new System.Drawing.Point(296, 485);
            this.btn_actulizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actulizar.Name = "btn_actulizar";
            this.btn_actulizar.Size = new System.Drawing.Size(100, 28);
            this.btn_actulizar.TabIndex = 27;
            this.btn_actulizar.Text = "Actualizar";
            this.btn_actulizar.UseVisualStyleBackColor = true;
            this.btn_actulizar.Visible = false;
            this.btn_actulizar.Click += new System.EventHandler(this.btn_actulizar_Click);
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Location = new System.Drawing.Point(819, 344);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(253, 190);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_foto.TabIndex = 28;
            this.pb_foto.TabStop = false;
            // 
            // btn_CargarFoto
            // 
            this.btn_CargarFoto.Enabled = false;
            this.btn_CargarFoto.Location = new System.Drawing.Point(1100, 344);
            this.btn_CargarFoto.Name = "btn_CargarFoto";
            this.btn_CargarFoto.Size = new System.Drawing.Size(95, 26);
            this.btn_CargarFoto.TabIndex = 29;
            this.btn_CargarFoto.Text = "Cargar Imagen";
            this.btn_CargarFoto.UseVisualStyleBackColor = true;
            this.btn_CargarFoto.Visible = false;
            this.btn_CargarFoto.Click += new System.EventHandler(this.btn_CargarFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 554);
            this.Controls.Add(this.btn_CargarFoto);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.btn_actulizar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.txt_respo);
            this.Controls.Add(this.txt_esatdo);
            this.Controls.Add(this.txt_fechaing);
            this.Controls.Add(this.txt_provee);
            this.Controls.Add(this.txt_ubicacion);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_canti);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_cate);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_prove);
            this.Controls.Add(this.txt_descrip);
            this.Controls.Add(this.txt_resp);
            this.Controls.Add(this.txt_est);
            this.Controls.Add(this.txt_feing);
            this.Controls.Add(this.txt_ubi);
            this.Controls.Add(this.txt_categ);
            this.Controls.Add(this.txt_prec);
            this.Controls.Add(this.txt_cant);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prec;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.TextBox txt_ubi;
        private System.Windows.Forms.TextBox txt_categ;
        private System.Windows.Forms.TextBox txt_resp;
        private System.Windows.Forms.TextBox txt_est;
        private System.Windows.Forms.TextBox txt_feing;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.TextBox txt_prove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_nombre;
        private System.Windows.Forms.Label txt_cate;
        private System.Windows.Forms.Label txt_desc;
        private System.Windows.Forms.Label txt_provee;
        private System.Windows.Forms.Label txt_ubicacion;
        private System.Windows.Forms.Label txt_precio;
        private System.Windows.Forms.Label txt_canti;
        private System.Windows.Forms.Label txt_esatdo;
        private System.Windows.Forms.Label txt_fechaing;
        private System.Windows.Forms.Label txt_respo;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_actulizar;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Button btn_CargarFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}