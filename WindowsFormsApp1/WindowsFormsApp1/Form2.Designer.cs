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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prec = new System.Windows.Forms.TextBox();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.txt_ubi = new System.Windows.Forms.TextBox();
            this.txt_categ = new System.Windows.Forms.TextBox();
            this.txt_resp = new System.Windows.Forms.TextBox();
            this.txt_est = new System.Windows.Forms.TextBox();
            this.txt_feing = new System.Windows.Forms.TextBox();
            this.txt_prov_prod = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.Label();
            this.txt_cate = new System.Windows.Forms.Label();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fechaegre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Protel = new System.Windows.Forms.TextBox();
            this.txt_ProP = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_prov_dir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_knuu = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Consumibles = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(14, 624);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(98, 60);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.Color.White;
            this.txt_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nom.Enabled = false;
            this.txt_nom.Location = new System.Drawing.Point(78, 379);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom.Multiline = true;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(107, 19);
            this.txt_nom.TabIndex = 1;
            this.txt_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_prec
            // 
            this.txt_prec.BackColor = System.Drawing.Color.White;
            this.txt_prec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_prec.Enabled = false;
            this.txt_prec.Location = new System.Drawing.Point(268, 347);
            this.txt_prec.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prec.Multiline = true;
            this.txt_prec.Name = "txt_prec";
            this.txt_prec.Size = new System.Drawing.Size(116, 20);
            this.txt_prec.TabIndex = 5;
            this.txt_prec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cant
            // 
            this.txt_cant.BackColor = System.Drawing.Color.White;
            this.txt_cant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cant.Enabled = false;
            this.txt_cant.Location = new System.Drawing.Point(265, 382);
            this.txt_cant.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(116, 14);
            this.txt_cant.TabIndex = 4;
            this.txt_cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ubi
            // 
            this.txt_ubi.BackColor = System.Drawing.Color.White;
            this.txt_ubi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ubi.Enabled = false;
            this.txt_ubi.Location = new System.Drawing.Point(268, 417);
            this.txt_ubi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ubi.Multiline = true;
            this.txt_ubi.Name = "txt_ubi";
            this.txt_ubi.Size = new System.Drawing.Size(116, 15);
            this.txt_ubi.TabIndex = 6;
            this.txt_ubi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_categ
            // 
            this.txt_categ.BackColor = System.Drawing.Color.White;
            this.txt_categ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_categ.Enabled = false;
            this.txt_categ.Location = new System.Drawing.Point(80, 410);
            this.txt_categ.Margin = new System.Windows.Forms.Padding(4);
            this.txt_categ.Multiline = true;
            this.txt_categ.Name = "txt_categ";
            this.txt_categ.Size = new System.Drawing.Size(107, 19);
            this.txt_categ.TabIndex = 2;
            this.txt_categ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_resp
            // 
            this.txt_resp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_resp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_resp.Enabled = false;
            this.txt_resp.HideSelection = false;
            this.txt_resp.Location = new System.Drawing.Point(179, 130);
            this.txt_resp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_resp.Multiline = true;
            this.txt_resp.Name = "txt_resp";
            this.txt_resp.Size = new System.Drawing.Size(116, 20);
            this.txt_resp.TabIndex = 10;
            this.txt_resp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_resp.Visible = false;
            // 
            // txt_est
            // 
            this.txt_est.BackColor = System.Drawing.Color.White;
            this.txt_est.Enabled = false;
            this.txt_est.Location = new System.Drawing.Point(179, 130);
            this.txt_est.Margin = new System.Windows.Forms.Padding(4);
            this.txt_est.Multiline = true;
            this.txt_est.Name = "txt_est";
            this.txt_est.Size = new System.Drawing.Size(116, 19);
            this.txt_est.TabIndex = 9;
            this.txt_est.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_feing
            // 
            this.txt_feing.BackColor = System.Drawing.Color.White;
            this.txt_feing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_feing.Enabled = false;
            this.txt_feing.Location = new System.Drawing.Point(268, 85);
            this.txt_feing.Margin = new System.Windows.Forms.Padding(4);
            this.txt_feing.Multiline = true;
            this.txt_feing.Name = "txt_feing";
            this.txt_feing.Size = new System.Drawing.Size(116, 19);
            this.txt_feing.TabIndex = 8;
            this.txt_feing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_prov_prod
            // 
            this.txt_prov_prod.BackColor = System.Drawing.Color.White;
            this.txt_prov_prod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_prov_prod.Enabled = false;
            this.txt_prov_prod.Location = new System.Drawing.Point(81, 17);
            this.txt_prov_prod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prov_prod.Name = "txt_prov_prod";
            this.txt_prov_prod.Size = new System.Drawing.Size(107, 14);
            this.txt_prov_prod.TabIndex = 7;
            this.txt_prov_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(195, 495);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(206, 121);
            this.dataGridView1.TabIndex = 13;
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.White;
            this.txt_buscar.Location = new System.Drawing.Point(129, 29);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(238, 21);
            this.txt_buscar.TabIndex = 12;
            // 
            // txt_nombre
            // 
            this.txt_nombre.AutoSize = true;
            this.txt_nombre.Location = new System.Drawing.Point(11, 382);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(60, 16);
            this.txt_nombre.TabIndex = 16;
            this.txt_nombre.Text = "Producto:";
            // 
            // txt_cate
            // 
            this.txt_cate.AutoSize = true;
            this.txt_cate.Location = new System.Drawing.Point(11, 410);
            this.txt_cate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_cate.Name = "txt_cate";
            this.txt_cate.Size = new System.Drawing.Size(62, 16);
            this.txt_cate.TabIndex = 17;
            this.txt_cate.Text = "Categoría";
            // 
            // txt_provee
            // 
            this.txt_provee.AutoSize = true;
            this.txt_provee.Location = new System.Drawing.Point(11, 207);
            this.txt_provee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_provee.Name = "txt_provee";
            this.txt_provee.Size = new System.Drawing.Size(67, 16);
            this.txt_provee.TabIndex = 22;
            this.txt_provee.Text = "Proveedor:";
            // 
            // txt_ubicacion
            // 
            this.txt_ubicacion.AutoSize = true;
            this.txt_ubicacion.Location = new System.Drawing.Point(110, 457);
            this.txt_ubicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.Size = new System.Drawing.Size(66, 16);
            this.txt_ubicacion.TabIndex = 21;
            this.txt_ubicacion.Text = "Ubicación:";
            // 
            // txt_precio
            // 
            this.txt_precio.AutoSize = true;
            this.txt_precio.BackColor = System.Drawing.Color.Transparent;
            this.txt_precio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(214, 350);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(48, 16);
            this.txt_precio.TabIndex = 20;
            this.txt_precio.Text = "Precio:";
            // 
            // txt_canti
            // 
            this.txt_canti.AutoSize = true;
            this.txt_canti.Location = new System.Drawing.Point(214, 385);
            this.txt_canti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_canti.Name = "txt_canti";
            this.txt_canti.Size = new System.Drawing.Size(39, 16);
            this.txt_canti.TabIndex = 19;
            this.txt_canti.Text = "Stock:";
            // 
            // txt_esatdo
            // 
            this.txt_esatdo.AutoSize = true;
            this.txt_esatdo.Location = new System.Drawing.Point(212, 417);
            this.txt_esatdo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_esatdo.Name = "txt_esatdo";
            this.txt_esatdo.Size = new System.Drawing.Size(47, 16);
            this.txt_esatdo.TabIndex = 24;
            this.txt_esatdo.Text = "Estado:";
            // 
            // txt_fechaing
            // 
            this.txt_fechaing.AutoSize = true;
            this.txt_fechaing.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaing.Location = new System.Drawing.Point(157, 85);
            this.txt_fechaing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_fechaing.Name = "txt_fechaing";
            this.txt_fechaing.Size = new System.Drawing.Size(112, 16);
            this.txt_fechaing.TabIndex = 23;
            this.txt_fechaing.Text = "Fecha de ingreso:";
            // 
            // txt_respo
            // 
            this.txt_respo.AutoSize = true;
            this.txt_respo.Enabled = false;
            this.txt_respo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_respo.Location = new System.Drawing.Point(96, 457);
            this.txt_respo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_respo.Name = "txt_respo";
            this.txt_respo.Size = new System.Drawing.Size(82, 16);
            this.txt_respo.TabIndex = 25;
            this.txt_respo.Text = "Responsable";
            this.txt_respo.Visible = false;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.BackgroundImage")));
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Location = new System.Drawing.Point(14, 624);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnNuevo.Size = new System.Drawing.Size(98, 60);
            this.BtnNuevo.TabIndex = 11;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.BackgroundImage")));
            this.btn_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(268, 627);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(99, 60);
            this.btn_limpiar.TabIndex = 26;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Visible = false;
            // 
            // btn_actulizar
            // 
            this.btn_actulizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_actulizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_actulizar.BackgroundImage")));
            this.btn_actulizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_actulizar.FlatAppearance.BorderSize = 0;
            this.btn_actulizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actulizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actulizar.Location = new System.Drawing.Point(268, 627);
            this.btn_actulizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actulizar.Name = "btn_actulizar";
            this.btn_actulizar.Size = new System.Drawing.Size(99, 63);
            this.btn_actulizar.TabIndex = 27;
            this.btn_actulizar.UseVisualStyleBackColor = false;
            this.btn_actulizar.Visible = false;
            // 
            // pb_foto
            // 
            this.pb_foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pb_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_foto.Image = ((System.Drawing.Image)(resources.GetObject("pb_foto.Image")));
            this.pb_foto.Location = new System.Drawing.Point(5, 496);
            this.pb_foto.Margin = new System.Windows.Forms.Padding(2);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(184, 120);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_foto.TabIndex = 28;
            this.pb_foto.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fecha de egreso:";
            // 
            // txt_fechaegre
            // 
            this.txt_fechaegre.BackColor = System.Drawing.Color.White;
            this.txt_fechaegre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fechaegre.Enabled = false;
            this.txt_fechaegre.Location = new System.Drawing.Point(268, 130);
            this.txt_fechaegre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fechaegre.Multiline = true;
            this.txt_fechaegre.Name = "txt_fechaegre";
            this.txt_fechaegre.Size = new System.Drawing.Size(116, 19);
            this.txt_fechaegre.TabIndex = 30;
            this.txt_fechaegre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Telefono:";
            // 
            // txt_Protel
            // 
            this.txt_Protel.BackColor = System.Drawing.Color.White;
            this.txt_Protel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Protel.Enabled = false;
            this.txt_Protel.Location = new System.Drawing.Point(279, 239);
            this.txt_Protel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Protel.Name = "txt_Protel";
            this.txt_Protel.Size = new System.Drawing.Size(107, 14);
            this.txt_Protel.TabIndex = 32;
            this.txt_Protel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ProP
            // 
            this.txt_ProP.BackColor = System.Drawing.Color.White;
            this.txt_ProP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ProP.Enabled = false;
            this.txt_ProP.Location = new System.Drawing.Point(281, 18);
            this.txt_ProP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProP.Name = "txt_ProP";
            this.txt_ProP.Size = new System.Drawing.Size(107, 14);
            this.txt_ProP.TabIndex = 36;
            this.txt_ProP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Info;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(960, 34);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(110, 19);
            this.txt_id.TabIndex = 0;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(877, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Producto:";
            this.label1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "KNU:";
            // 
            // txt_prov_dir
            // 
            this.txt_prov_dir.BackColor = System.Drawing.Color.White;
            this.txt_prov_dir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_prov_dir.Enabled = false;
            this.txt_prov_dir.Location = new System.Drawing.Point(81, 49);
            this.txt_prov_dir.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prov_dir.Name = "txt_prov_dir";
            this.txt_prov_dir.Size = new System.Drawing.Size(107, 14);
            this.txt_prov_dir.TabIndex = 38;
            this.txt_prov_dir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Dirección:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(129, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 91);
            this.panel1.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(206)))), ((int)(((byte)(145)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(140, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 23);
            this.textBox1.TabIndex = 43;
            this.textBox1.Text = "REGISTRO";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(5, 192);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 96);
            this.panel2.TabIndex = 43;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 96);
            this.panel5.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 190);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Producto:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 218);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "Categoría";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 47);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 16);
            this.label23.TabIndex = 41;
            this.label23.Text = "Dirección:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(209, 193);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 16);
            this.label17.TabIndex = 19;
            this.label17.Text = "Stock:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 15);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 16);
            this.label18.TabIndex = 22;
            this.label18.Text = "Proveedor:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(207, 225);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 16);
            this.label19.TabIndex = 24;
            this.label19.Text = "Estado:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 158);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 16);
            this.label22.TabIndex = 39;
            this.label22.Text = "KNU:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(193, 47);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 16);
            this.label20.TabIndex = 33;
            this.label20.Text = "Telefono:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(193, 20);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 16);
            this.label21.TabIndex = 37;
            this.label21.Text = "Proveedor P.:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(206)))), ((int)(((byte)(145)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(14, 172);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 22);
            this.textBox2.TabIndex = 44;
            this.textBox2.Text = "PROVEEDOR";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(206)))), ((int)(((byte)(145)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(16, 318);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(95, 22);
            this.textBox3.TabIndex = 46;
            this.textBox3.Text = "PRODUCTO";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txt_resp);
            this.panel3.Controls.Add(this.txt_est);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(5, 328);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 159);
            this.panel3.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(374, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 21);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txt_prov_dir);
            this.panel4.Controls.Add(this.txt_prov_prod);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txt_ProP);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(5, 192);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 96);
            this.panel4.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(193, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Proveedor P.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 410);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Categoría";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(214, 385);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Stock:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Proveedor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(212, 417);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Estado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(198, 239);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Telefono:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 350);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "KNU:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 239);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = "Dirección:";
            // 
            // txt_knuu
            // 
            this.txt_knuu.BackColor = System.Drawing.Color.White;
            this.txt_knuu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_knuu.Location = new System.Drawing.Point(78, 348);
            this.txt_knuu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_knuu.Multiline = true;
            this.txt_knuu.Name = "txt_knuu";
            this.txt_knuu.Size = new System.Drawing.Size(107, 20);
            this.txt_knuu.TabIndex = 40;
            this.txt_knuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Consumibles);
            this.tabControl1.Location = new System.Drawing.Point(424, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 48;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "No consumibles";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.DoubleClick += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Consumibles
            // 
            this.Consumibles.Location = new System.Drawing.Point(4, 25);
            this.Consumibles.Name = "Consumibles";
            this.Consumibles.Padding = new System.Windows.Forms.Padding(3);
            this.Consumibles.Size = new System.Drawing.Size(192, 71);
            this.Consumibles.TabIndex = 1;
            this.Consumibles.Text = "Consumibles";
            this.Consumibles.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(643, 695);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_knuu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Protel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fechaegre);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.btn_actulizar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.txt_respo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_esatdo);
            this.Controls.Add(this.txt_fechaing);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_provee);
            this.Controls.Add(this.txt_ubicacion);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_canti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_cate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_feing);
            this.Controls.Add(this.txt_ubi);
            this.Controls.Add(this.txt_categ);
            this.Controls.Add(this.txt_prec);
            this.Controls.Add(this.txt_cant);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.DoubleClick += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prec;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.TextBox txt_ubi;
        private System.Windows.Forms.TextBox txt_categ;
        private System.Windows.Forms.TextBox txt_resp;
        private System.Windows.Forms.TextBox txt_est;
        private System.Windows.Forms.TextBox txt_feing;
        private System.Windows.Forms.TextBox txt_prov_prod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label txt_nombre;
        private System.Windows.Forms.Label txt_cate;
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fechaegre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Protel;
        private System.Windows.Forms.TextBox txt_ProP;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_prov_dir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_knuu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Consumibles;
    }
}