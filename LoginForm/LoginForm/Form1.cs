using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
namespace LoginForm

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-88SU394;Initial Catalog=Deneme;User ID=sa;Password=12345;Trust Server Certificate=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txtKullanici.Text;
            password = txtSifre.Text;
            try
            {
                String query = "SELECT * FROM Login_New WHERE username = '" + txtKullanici.Text + "'AND  password = '" + txtSifre.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = txtKullanici.Text;
                    password = txtSifre.Text;

                    MenuForm form2 = new MenuForm();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlýþ giriþ bilgileri", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKullanici.Clear();
                    txtSifre.Clear();

                    txtKullanici.Focus();
                }
            }
            catch
            {
                MessageBox.Show("HATA!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtKullanici.Clear();
            txtSifre.Clear();

            txtKullanici.Focus();
        }

        
    }
}
