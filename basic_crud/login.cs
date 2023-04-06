using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Console;
using System.Threading;
using System.Globalization;

namespace basic_crud
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            textbox_username.Text = "";
            textbox_passw.Text = "";
        }

        MySqlConnection koneksi = new MySqlConnection("Server=aws.connect.psdb.cloud;Database=methanesulfonic;user=mjzb1csqsbkk4isr7uhs;password=pscale_pw_NYeVCf5ZoZUUSzDTmWEMelNem0CjgifkaW6zXrsnh8N;SslMode=VerifyFull");

        private void login_Load(object sender, EventArgs e)
        {
           Font myfont = new Font("Microsoft Sans Serif", 15.0f);
           textbox_username.Font = myfont;
           textbox_passw.Font = myfont;
            
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection koneksi = new MySqlConnection("Server=aws.connect.psdb.cloud;Database=methanesulfonic;user=mjzb1csqsbkk4isr7uhs;password=pscale_pw_NYeVCf5ZoZUUSzDTmWEMelNem0CjgifkaW6zXrsnh8N;SslMode=VerifyFull");
                // MySqlConnection koneksi = new MySqlConnection("server=localhost;database=date_test;uid=root;pwd=;convert zero datetime=True");
                MySqlCommand cmd;

                cmd = koneksi.CreateCommand();
                koneksi.Open();
                cmd.CommandText = "SELECT * FROM admin where USERNAME=@USERNAME AND PASSWORD=@PASSWORD";

                cmd.Parameters.AddWithValue("@USERNAME", textbox_username.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", textbox_passw.Text);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                if (ds.Rows.Count > 0)
                {
                    MessageBox.Show("Login berhasil!");
                    Form1 f = new Form1();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password atau Username salah. Silahkan Cek Kembali.","Peringatan");
                }
                cmd.Parameters.Clear();
                koneksi.Close();
            }
            
            catch (Exception c)
            {
                MessageBox.Show("Ups, Ada Kesalahan. \nIni Detail Errornya: \"" + c.Message + "\"", "Pesan Error");
            }
            finally
            {
                koneksi.Close();
            }
        }
               
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nonadmin z = new nonadmin();
            this.Hide();
            z.ShowDialog();
            this.Close();

        }
    }
}
