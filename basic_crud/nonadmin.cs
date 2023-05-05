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
    public partial class nonadmin : Form
    {
        public nonadmin()
        {
            InitializeComponent();
        }

        MySqlConnection koneksi = new MySqlConnection("server=localhost;database=date_test;uid=root;pwd=;convert zero datetime=True");
       
        public void caridataformat()
        {
            dataGridView1.Columns[7].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[8].DefaultCellStyle.Format = "c";

            dataGridView1.Columns[3].DefaultCellStyle.Format = "HH:mm, dd-MM-yyyy";

            dataGridView1.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns[8].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            MessageBox.Show("Data berhasil dicari.");
        }

        public void kosongkantext()
        {
            textbox_cari.Text = "";
            textbox_id.Text = "";
            textbox_jiwa.Text = "";
            textbox_nama.Text = "";
            textbox_nik.Text = "";
        }

        public void lihatData()
        {
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "select * from identitas";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            dataGridView1.Columns[7].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[8].DefaultCellStyle.Format = "c";

            dataGridView1.Columns[3].DefaultCellStyle.Format = "HH:mm, dd-MM-yyyy";

            dataGridView1.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns[8].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
        }

        private void nonadmin_Load(object sender, EventArgs e)
        {
            lihatData();
            label_waktu.Text = DateTime.Now.ToString
            ("dddd, HH:mm, dd MMMM yyyy", new System.Globalization.CultureInfo("id-ID"));
            this.dateTimePicker2.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                MySqlCommand cmd;
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "SELECT distinct * FROM identitas WHERE tanggal BETWEEN @dari AND @ke;";
                cmd.Parameters.AddWithValue("@dari", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@ke", dateTimePicker2.Value);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                MessageBox.Show("Data berhasil dicari.");
                caridataformat();
                koneksi.Close();
            }
            catch (Exception c)
            {
                MessageBox.Show("Upss, coba cek kembali. Ini errornya: " + c.Message, "Pesan Error");
            }
        }

        private void button_cari_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                MySqlCommand cmd;
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "SELECT * FROM identitas WHERE NIK LIKE '%" + textbox_cari.Text + "%' OR ID LIKE '%" + textbox_cari.Text + "%' OR NAMA LIKE '%" + textbox_cari.Text + "%' OR JUMLAH_JIWA LIKE '%" + textbox_cari.Text + "%' OR KUALITAS LIKE '%" + textbox_cari.Text + "%' OR TOTAL LIKE '%" + textbox_cari.Text + "%' OR PEMBAYARAN LIKE '%" + textbox_cari.Text + "%' OR KEMBALIAN LIKE '%" + textbox_cari.Text + "%'";
                cmd.Parameters.AddWithValue("@NIK", textbox_cari.Text);
                cmd.Parameters.AddWithValue("@NAMA", textbox_cari.Text);
                cmd.Parameters.AddWithValue("@JUMLAH", textbox_cari.Text);
                cmd.Parameters.AddWithValue("@JUMLAH_JIWA", textbox_cari.Text);
                cmd.Parameters.AddWithValue("@KUALITAS", textbox_cari.Text);
                cmd.Parameters.AddWithValue("@TOTAL", textbox_cari.Text);
                cmd.Parameters.AddWithValue("@PEMBAYARAN", textbox_cari.Text);
                cmd.Parameters.AddWithValue("@KEMBALIAN", textbox_cari.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                caridataformat();
                kosongkantext();
                koneksi.Close();
            }
            catch (Exception c)
            {
                MessageBox.Show("Upss, coba cek kembali. Ini errornya: " + c.Message, "Pesan Error");
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void button_carikolom_Click_1(object sender, EventArgs e)
        { 
            try
            {
                koneksi.Open();
                MySqlCommand cmd;
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "SELECT * FROM identitas WHERE ID LIKE '%" + textbox_id.Text + "%'";
                cmd.Parameters.AddWithValue("@ID", textbox_id.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                caridataformat();
                kosongkantext();
                koneksi.Close();
            }
            catch (Exception c)
            {
                MessageBox.Show("Upss, coba cek kembali. Ini errornya: " + c.Message, "Pesan Error");
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            lihatData();
        }

        private void button_cari_nik_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                MySqlCommand cmd;
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "SELECT * FROM identitas WHERE NIK LIKE '%" + textbox_nik.Text + "%'";
                cmd.Parameters.AddWithValue("@NIK", textbox_nik.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                caridataformat();
                kosongkantext();
                koneksi.Close();
            }
            catch (Exception c)
            {
                MessageBox.Show("Upss, coba cek kembali. Ini errornya: " + c.Message, "Pesan Error");
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label_waktu_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_backlogin_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Kembali ke Form Login");
                login x = new login();
                this.Hide();
                x.ShowDialog();
                this.Close();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Menampilkan Credits~!");
                Credits v = new Credits();
                v.ShowDialog();

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

        private void button_cari_nama_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                MySqlCommand cmd;
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "SELECT * FROM identitas WHERE NAMA LIKE '%" + textbox_nama.Text + "%'";
                cmd.Parameters.AddWithValue("@NAMA", textbox_nama.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                caridataformat();
                kosongkantext();
                koneksi.Close();
            }
            catch (Exception c)
            {
                MessageBox.Show("Upss, coba cek kembali. Ini errornya: " + c.Message, "Pesan Error");
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void button_cari_jiwa_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                MySqlCommand cmd;
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "SELECT * FROM identitas WHERE JUMLAH_JIWA LIKE '%" + textbox_jiwa.Text + "%'";
                cmd.Parameters.AddWithValue("@JUMLAH_JIWA", textbox_jiwa.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                caridataformat();
                kosongkantext();
                koneksi.Close();
            }
            catch (Exception c)
            {
                MessageBox.Show("Upss, coba cek kembali. Ini errornya: " + c.Message, "Pesan Error");
            }
            finally
            {
                koneksi.Close();
            }
        }
    }
    
}

