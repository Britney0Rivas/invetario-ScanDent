using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public bool LoginOk { get; private set; } = false;

        public Form1()
        {
            InitializeComponent();

            // Password en modo oculto
            text_pass.UseSystemPasswordChar = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = text_user.Text.Trim();
            string pass = text_pass.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show(
                    "⚠️ Escribe usuario y contraseña.",
                    "ScanDent",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                bool ok = ValidateLogin(user, pass);

                if (!ok)
                {
                    MessageBox.Show(
                        "❌ Usuario o contraseña incorrectos.",
                        "ScanDent",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                LoginOk = true;

                MessageBox.Show(
                    "✅ Bienvenido a ScanDent 😎🦷",
                    "ScanDent",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "💥 Error: " + ex.Message,
                    "ScanDent",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            byte[] passHash = Sha256Bytes(password);

            using (SqlConnection con = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT COUNT(1)
                FROM dbo.login_user
                WHERE Username = @u
                  AND IsActive = 1
                  AND PasswordHash = @p;", con))
            {
                cmd.Parameters.Add("@u", SqlDbType.NVarChar, 20).Value = username;
                cmd.Parameters.Add("@p", SqlDbType.VarBinary, 32).Value = passHash;

                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }
        }

        private static byte[] Sha256Bytes(string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                return sha.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }

     
    }
}
