using System;
using System.Data;
using System.Data.SqlClient;   // ✅ ESTE (no Microsoft.Data)
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public bool LoginOk { get; private set; } = false;

        // ====== Layout backup (para regresar todo a su lugar) ======
        private bool _layoutSaved = false;
        private Point _posUser, _posPass, _posBtnLogin, _posBtnReg, _posBtnAtras;
        private Point _posConfirmPass, _posDocPass, _posLbl1, _posLbl5, _posLbl4, _posLbl6;

        // Modo actual
        private bool _registerMode = false;

        public Form1()
        {
            InitializeComponent();

            // ✅ Passwords en modo ****
            text_pass.UseSystemPasswordChar = true; // login
            textBox1.UseSystemPasswordChar = true;  // confirmar
            textBox2.UseSystemPasswordChar = true;  // clave doctor

            SaveLayoutOnce();

            // Arrancar en modo login
            Register_Off_Restore();
        }

        /* =========================
           LAYOUT BACKUP
        ========================= */
        private void SaveLayoutOnce()
        {
            if (_layoutSaved) return;
            _layoutSaved = true;

            _posUser = text_user.Location;
            _posPass = text_pass.Location;
            _posBtnLogin = btn_login.Location;
            _posBtnReg = btn_reg.Location;
            _posBtnAtras = btn_atras.Location;

            _posConfirmPass = textBox1.Location;
            _posDocPass = textBox2.Location;

            _posLbl1 = label1.Location;
            _posLbl5 = label5.Location;
            _posLbl4 = label4.Location;
            _posLbl6 = label6.Location;
        }

        private void ClearAll()
        {
            text_user.Clear();
            text_pass.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        /* =========================
           MODOS (sin paneles)
        ========================= */
        public void Register_On()
        {
            SaveLayoutOnce();
            _registerMode = true;

            // Mostrar extras
            label1.Visible = false;

            label5.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;

            label4.Visible = true;
            textBox2.Visible = true;
            textBox2.Enabled = true;

            label6.Visible = true;
            label3.Visible = false;

            // Ocultar login button
            btn_login.Visible = false;
            btn_login.Enabled = false;

            // Mostrar volver
            btn_atras.Visible = true;
            btn_atras.Enabled = true;

            // Cambiar texto
            btn_reg.Text = "Crear usuario";

            // limpiar passwords
            text_pass.Clear();
            textBox1.Clear();
            textBox2.Clear();
            text_user.Focus();
        }

        private void Register_Off_Restore()
        {
            SaveLayoutOnce();
            _registerMode = false;

            // Ocultar extras
            label5.Visible = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;

            label4.Visible = false;
            textBox2.Visible = false;
            textBox2.Enabled = false;

            label6.Visible = false;
            label3.Visible = true;

            // Volver label1 si lo usas en login
            label1.Visible = true;

            // Mostrar login button
            btn_login.Visible = true;
            btn_login.Enabled = true;

            // Botón reg vuelve a normal
            btn_reg.Text = "Registrarse";

            // Ocultar volver
            btn_atras.Visible = false;
            btn_atras.Enabled = false;

            // ✅ Regresar posiciones originales (por si los moviste)
            text_user.Location = _posUser;
            text_pass.Location = _posPass;
            btn_login.Location = _posBtnLogin;
            btn_reg.Location = _posBtnReg;
            btn_atras.Location = _posBtnAtras;

            textBox1.Location = _posConfirmPass;
            textBox2.Location = _posDocPass;

            label1.Location = _posLbl1;
            label5.Location = _posLbl5;
            label4.Location = _posLbl4;
            label6.Location = _posLbl6;
        }

        /* =========================
           LOGIN
        ========================= */
        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = text_user.Text.Trim();
            string pass = text_pass.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("⚠️ Escribe usuario y contraseña.", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool ok = ValidateLogin(user, pass);

                if (!ok)
                {
                    MessageBox.Show("❌ Usuario o contraseña incorrectos.", "ScanDent",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoginOk = true;

                MessageBox.Show("✅ Bienvenido a ScanDent 😎🦷", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("💥 Error: " + ex.Message, "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            byte[] passHash = Sha256Bytes(password);

            using (SqlConnection con = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT COUNT(1)
                FROM dbo.usuarios_scandent
                WHERE Username = @u
                  AND IsActive = 1
                  AND PasswordHash = @p;", con))
            {
                cmd.Parameters.Add("@u", SqlDbType.NVarChar, 20).Value = username;
                cmd.Parameters.Add("@p", SqlDbType.VarBinary, 32).Value = passHash;

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) == 1;
            }
        }

        /* =========================
           REGISTRO (btn_reg)
        ========================= */
        private void btn_reg_Click(object sender, EventArgs e)
        {
            // 1) Si estamos en login -> abrir registro
            if (!_registerMode)
            {
                Register_On();
                return;
            }

            // 2) Si estamos en registro -> crear usuario
            string newUser = text_user.Text.Trim();
            string pass1 = text_pass.Text;     // contraseña nueva
            string pass2 = textBox1.Text;      // confirmar
            string docPass = textBox2.Text;    // clave doctor

            if (string.IsNullOrWhiteSpace(newUser))
            {
                MessageBox.Show("⚠️ Escribe el usuario.", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newUser.Equals("doctor", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("⚠️ 'doctor' está reservado.", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(pass1) || string.IsNullOrWhiteSpace(pass2))
            {
                MessageBox.Show("⚠️ Escribe y confirma la contraseña.", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass1 != pass2)
            {
                MessageBox.Show("⚠️ Las contraseñas no coinciden.", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(docPass))
            {
                MessageBox.Show("⚠️ Falta la clave del doctor.", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // validar clave doctor
                if (!ValidateLogin("doctor", docPass))
                {
                    MessageBox.Show("❌ Clave del doctor incorrecta.", "ScanDent",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (UserExists(newUser))
                {
                    MessageBox.Show("⚠️ Ese usuario ya existe.", "ScanDent",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CreateUser(newUser, pass1);

                MessageBox.Show("✅ Usuario creado. Ahora inicia sesión 👌", "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ lo que pediste: irse atrás como btn_atras + limpiar todo
                ClearAll();
                Register_Off_Restore();
            }
            catch (Exception ex)
            {
                MessageBox.Show("💥 Error: " + ex.Message, "ScanDent",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            ClearAll();
            Register_Off_Restore();
        }

        private bool UserExists(string username)
        {
            using (SqlConnection con = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT COUNT(1)
                FROM dbo.usuarios_scandent
                WHERE Username = @u;", con))
            {
                cmd.Parameters.Add("@u", SqlDbType.NVarChar, 20).Value = username;
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void CreateUser(string username, string password)
        {
            byte[] passHash = Sha256Bytes(password);

            using (SqlConnection con = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                INSERT INTO dbo.usuarios_scandent (Username, PasswordHash, Role, IsActive)
                VALUES (@u, @p, 'empleado', 1);", con))
            {
                cmd.Parameters.Add("@u", SqlDbType.NVarChar, 20).Value = username;
                cmd.Parameters.Add("@p", SqlDbType.VarBinary, 32).Value = passHash;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ✅ Unicode para que sea consistente con NVARCHAR
        private static byte[] Sha256Bytes(string input)
        {
            using (SHA256 sha = SHA256.Create())
                return sha.ComputeHash(Encoding.Unicode.GetBytes(input));
        }
    }
}