﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {

           InitializeComponent();
           // Application.Run(new login());
           // this.Close();

        }
        //Gunakan koneksi dibawah jika ingin memakai database offline
        //MySqlConnection koneksi = new MySqlConnection("server=localhost;database=date_test;uid=root;pwd=;convert zero datetime=True");
        //Gunakan koneksi dibawah jika ingin memakai database online
        //MySqlConnection koneksi = new MySqlConnection("Server=aws.connect.psdb.cloud;Database=methanesulfonic;user=mjzb1csqsbkk4isr7uhs;password=pscale_pw_NYeVCf5ZoZUUSzDTmWEMelNem0CjgifkaW6zXrsnh8N;SslMode=VerifyFull");
        MySqlConnection koneksi = new MySqlConnection("Server=aws.connect.psdb.cloud;Database=methanesulfonic;user=0kycfa9jqanz63z0rlt0;password=pscale_pw_OwSoNujBv6UcYU0yIn24b7VyDyUxlRE3exjuHYoR4pI;SslMode=VerifyFull");

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

            dataGridView1.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns[8].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");

           //jika data jenis beras berada di dalam database 
           //comboBox1.DataSource = ds.Tables[0];
           // comboBox1.ValueMember = "jenis";
           // comboBox1.DisplayMember = "RP." + "jenis";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lihatData();
            label_waktu.Text = DateTime.Now.ToString
            ("dddd, HH:mm, dd MMMM yyyy", new System.Globalization.CultureInfo("id-ID"));
            this.dateTimePicker2.Value = DateTime.Now;
            Font myfont = new Font("Microsoft Sans Serif", 12.0f);
            textbox_id.Font = myfont;
            textbox_nik.Font = myfont;
            textbox_nama.Font = myfont;
            textbox_uang.Font = myfont;
            textbox_total.Font = myfont;
            textbox_kembalian.Font = myfont;
            comboBox1.Font = myfont;
            comboBox2.Font = myfont;

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox2.Text))
                button_simpan.Enabled = false;
            else
                button_simpan.Enabled = true;
        }

        public void button_cek_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                if (comboBox1.SelectedIndex == 0)
                {
                    total = int.Parse(comboBox2.Text) * (12000 * 4.3);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    total = int.Parse(comboBox2.Text) * (15000 * 4.3);
                }

                if (comboBox1.SelectedIndex == 2)
                {
                    total = int.Parse(comboBox2.Text) * (20000 * 4.3);
                }

                if (comboBox1.SelectedIndex == 3)
                {
                    total = int.Parse(comboBox2.Text) * (25000 * 4.3);
                }

                if (comboBox1.SelectedIndex == 4)
                {
                    total = int.Parse(comboBox2.Text) * (30000 * 4.3);
                }

                if (comboBox1.SelectedIndex == 5)
                {
                    total = int.Parse(comboBox2.Text) * (35000 * 4.3);
                }

                textbox_total.Text = "RP. " + total;


                double nilai_kembalian = int.Parse(textbox_uang.Text) - total;
                textbox_kembalian.Text = "RP. " + nilai_kembalian;

                textbox_kembalian.Text = "RP. " + nilai_kembalian.ToString();
            }
            catch (Exception c)
            {
                MessageBox.Show("Ups, Ada Kesalahan. \nIni Detail Errornya: " + c.Message, "Pesan Error");
            }
        }


        private void textbox_jiwa_TextChanged(object sender, EventArgs e)
        {

        }



        private void button_simpan_Click_1(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                MySqlCommand cmd;
                cmd = koneksi.CreateCommand();

                double total = 0;
                if (comboBox1.SelectedIndex == 0)
                {
                    total = int.Parse(comboBox2.Text) * (12000 * 4.3);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    total = int.Parse(comboBox2.Text) * (15000 * 4.3);
                }

                if (comboBox1.SelectedIndex == 2)
                {
                    total = int.Parse(comboBox2.Text) * (20000 * 4.3);
                }

                if (comboBox1.SelectedIndex == 3)
                {
                    total = int.Parse(comboBox2.Text) * (25000 * 4.3);
                }

                if (comboBox1.SelectedIndex == 4)
                {
                    total = int.Parse(comboBox2.Text) * (30000 * 4.3);
                }

                if (comboBox1.SelectedIndex == 5)
                {
                    total = int.Parse(comboBox2.Text) * (35000 * 4.3);
                }
                double nilai_kembalian = int.Parse(textbox_uang.Text) - total;

                cmd.CommandText = "insert into identitas (NIK, NAMA, JUMLAH_JIWA, KUALITAS, TOTAL, TANGGAL, PEMBAYARAN, KEMBALIAN) values (@NIK,@NAMA,@JUMLAH_JIWA,@KUALITAS,@TOTAL,@TANGGAL,@PEMBAYARAN,@KEMBALIAN)";
                cmd.Parameters.AddWithValue("@NIK", textbox_nik.Text);
                cmd.Parameters.AddWithValue("@NAMA", textbox_nama.Text);
                DateTime dateTimeVariable = DateTime.Now;
                cmd.Parameters.AddWithValue("@TANGGAL", dateTimeVariable);
                cmd.Parameters.AddWithValue("@PEMBAYARAN", textbox_uang.Text);
                cmd.Parameters.AddWithValue("@JUMLAH_JIWA", comboBox2.Text);
                cmd.Parameters.AddWithValue("@KUALITAS", comboBox1.Text);
                cmd.Parameters.AddWithValue("@TOTAL", total);
                cmd.Parameters.AddWithValue("@KEMBALIAN", nilai_kembalian);

                MessageBox.Show("Data dengan NIK " + textbox_nik.Text + " berhasil disimpan");
                cmd.ExecuteNonQuery();
                textbox_id.Text = "";
                textbox_nik.Text = "";
                textbox_nama.Text = "";
                textbox_uang.Text = "";
                textbox_total.Text = "0";
                textbox_kembalian.Text = "0";
                lihatData();
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

        private void textbox_nik_TextChanged_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textbox_nik.Text))
                button_simpan.Enabled = false;
            else
                button_simpan.Enabled = true;
        }

        private void textbox_uang_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textbox_nik.Text))
                button_simpan.Enabled = false;
            else
                button_simpan.Enabled = true;
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

                dataGridView1.Columns[7].DefaultCellStyle.Format = "c";
                dataGridView1.Columns[5].DefaultCellStyle.Format = "c";
                dataGridView1.Columns[6].DefaultCellStyle.Format = "c";
                dataGridView1.Columns[8].DefaultCellStyle.Format = "c";

                dataGridView1.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
                dataGridView1.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
                dataGridView1.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
                dataGridView1.Columns[8].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
                MessageBox.Show("Data berhasil dicari.");

                koneksi.Close();
            }
            catch (Exception c)
            {
                MessageBox.Show("Ups, Ada Kesalahan. \nIni Detail Errornya: \"" + c.Message + "\"", "Pesan Error");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_batal_Click(object sender, EventArgs e)
        {
            textbox_id.Text = "";
            textbox_nik.Text = "";
            textbox_nama.Text = "";
            textbox_uang.Text = "";
            textbox_total.Text = "";
            textbox_kembalian.Text = "";
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            try
            { 
            koneksi.Open();

            int total = 0;
            if (comboBox1.SelectedIndex == 0)
            {
                total = int.Parse(comboBox2.Text) * (12000 * 2);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                total = int.Parse(comboBox2.Text) * (15000 * 2);
            }
            int nilai_kembalian = int.Parse(textbox_uang.Text) - total;

            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "update identitas set NIK=@NIK, NAMA=@NAMA, JUMLAH_JIWA=@JUMLAH_JIWA, KUALITAS=@KUALITAS, TOTAL=@TOTAL, TANGGAL=@TANGGAL, PEMBAYARAN=@PEMBAYARAN, KEMBALIAN=@KEMBALIAN where ID=@ID";
            cmd.Parameters.AddWithValue("@ID", textbox_id.Text);
            cmd.Parameters.AddWithValue("@NIK", textbox_nik.Text);
            cmd.Parameters.AddWithValue("@NAMA", textbox_nama.Text);
            DateTime dateTimeVariable = DateTime.Now;
            cmd.Parameters.AddWithValue("@TANGGAL", dateTimeVariable);
            cmd.Parameters.AddWithValue("@PEMBAYARAN", textbox_uang.Text);
            cmd.Parameters.AddWithValue("@JUMLAH_JIWA", comboBox2.Text);
            cmd.Parameters.AddWithValue("@KUALITAS", comboBox1.Text);
            cmd.Parameters.AddWithValue("@TOTAL", total);
            cmd.Parameters.AddWithValue("@KEMBALIAN", nilai_kembalian);
            MessageBox.Show("Data dengan NIK " + textbox_nik.Text + " berhasil diperbaharui");
            cmd.ExecuteNonQuery();
            textbox_id.Text = "";
            textbox_nik.Text = "";
            textbox_nama.Text = "";
            textbox_uang.Text = "";
            textbox_total.Text = "0";
            textbox_kembalian.Text = "0";
            lihatData();

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

        private void button_hapus_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                int total = 0;
                if (comboBox1.SelectedIndex == 0)
                {
                    total = int.Parse(comboBox2.Text) * (12000 * 2);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    total = int.Parse(comboBox2.Text) * (15000 * 2);
                }
                int nilai_kembalian = int.Parse(textbox_uang.Text) - total;

                MySqlCommand cmd;
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "delete from identitas where ID=@ID";
                cmd.Parameters.AddWithValue("@ID", textbox_id.Text);
                cmd.Parameters.AddWithValue("@NIK", textbox_nik.Text);
                cmd.Parameters.AddWithValue("@NAMA", textbox_nama.Text);
                DateTime dateTimeVariable = DateTime.Now;
                cmd.Parameters.AddWithValue("@TANGGAL", dateTimeVariable);
                cmd.Parameters.AddWithValue("@PEMBAYARAN", textbox_uang.Text);
                cmd.Parameters.AddWithValue("@JUMLAH_JIWA", comboBox2.Text);
                cmd.Parameters.AddWithValue("@KUALITAS", comboBox1.Text);
                cmd.Parameters.AddWithValue("@TOTAL", total);
                cmd.Parameters.AddWithValue("@KEMBALIAN", nilai_kembalian);
                MessageBox.Show("Data dengan NIK " + textbox_nik.Text + " berhasil dihapus");
                cmd.ExecuteNonQuery();
                textbox_id.Text = "";
                textbox_nik.Text = "";
                textbox_nama.Text = "";
                textbox_uang.Text = "";
                textbox_total.Text = "0";
                textbox_kembalian.Text = "0";
                lihatData();
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

        private void textbox_nama_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textbox_nama.Text))
                button_simpan.Enabled = false;
            else
                button_simpan.Enabled = true;


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox2.Text))
                button_simpan.Enabled = false;
            else
                button_simpan.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textbox_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textbox_nik.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textbox_nama.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textbox_total.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textbox_uang.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                textbox_kembalian.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch (Exception c)
            {
                MessageBox.Show("Ups, Ada Kesalahan. \nIni Detail Errornya: \"" + c.Message + "\"", "Pesan Error");
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            lihatData();
            koneksi.Close();
        }

        private void button_nonadmin_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Menuju ke Form Non-Administrator");
                nonadmin z = new nonadmin();
                this.Hide();
                z.ShowDialog();
                this.Close();
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

        private void button_backlogin_Click(object sender, EventArgs e)
        {

        }

        private void button_backlogin_Click_1(object sender, EventArgs e)
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
    }  
}
