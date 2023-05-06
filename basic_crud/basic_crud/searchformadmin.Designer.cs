namespace basic_crud
{
    partial class searchformadmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchformadmin));
            this.button_refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_carintgl = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_cari = new System.Windows.Forms.Button();
            this.textbox_cari = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_cari_id = new System.Windows.Forms.Button();
            this.textbox_id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_cari_nik = new System.Windows.Forms.Button();
            this.textbox_nik = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_cari_nama = new System.Windows.Forms.Button();
            this.textbox_nama = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_cari_jiwa = new System.Windows.Forms.Button();
            this.textbox_jiwa = new System.Windows.Forms.TextBox();
            this.label_waktu = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button_backlogin = new System.Windows.Forms.Button();
            this.button_back_input = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(312, 480);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(136, 24);
            this.button_refresh.TabIndex = 37;
            this.button_refresh.Text = "Tampilkan Semua Data";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(312, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(816, 360);
            this.dataGridView1.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_carintgl);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(624, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 88);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Berdasarkan Tanggal";
            // 
            // button_carintgl
            // 
            this.button_carintgl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_carintgl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_carintgl.FlatAppearance.BorderSize = 0;
            this.button_carintgl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button_carintgl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_carintgl.ForeColor = System.Drawing.Color.White;
            this.button_carintgl.Location = new System.Drawing.Point(416, 48);
            this.button_carintgl.Name = "button_carintgl";
            this.button_carintgl.Size = new System.Drawing.Size(75, 23);
            this.button_carintgl.TabIndex = 29;
            this.button_carintgl.Text = "Cari";
            this.button_carintgl.UseVisualStyleBackColor = false;
            this.button_carintgl.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(256, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Sampai";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = " HH:mm / dd - MM - yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(328, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker2.TabIndex = 31;
            this.dateTimePicker2.Value = new System.DateTime(2023, 4, 2, 23, 30, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Dari";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " HH:mm / dd - MM - yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_cari);
            this.groupBox2.Controls.Add(this.textbox_cari);
            this.groupBox2.Location = new System.Drawing.Point(320, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 88);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cari Berdasarkan Semua Atribut";
            // 
            // button_cari
            // 
            this.button_cari.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cari.FlatAppearance.BorderSize = 0;
            this.button_cari.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cari.ForeColor = System.Drawing.Color.White;
            this.button_cari.Location = new System.Drawing.Point(200, 48);
            this.button_cari.Name = "button_cari";
            this.button_cari.Size = new System.Drawing.Size(75, 23);
            this.button_cari.TabIndex = 34;
            this.button_cari.Text = "Cari";
            this.button_cari.UseVisualStyleBackColor = false;
            this.button_cari.Click += new System.EventHandler(this.button_cari_Click);
            // 
            // textbox_cari
            // 
            this.textbox_cari.Location = new System.Drawing.Point(16, 24);
            this.textbox_cari.MaxLength = 50;
            this.textbox_cari.Name = "textbox_cari";
            this.textbox_cari.Size = new System.Drawing.Size(259, 20);
            this.textbox_cari.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.button_cari_id);
            this.groupBox3.Controls.Add(this.textbox_id);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(16, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 88);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cari Berdasarkan ID";
            // 
            // button_cari_id
            // 
            this.button_cari_id.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_cari_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cari_id.FlatAppearance.BorderSize = 0;
            this.button_cari_id.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button_cari_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cari_id.ForeColor = System.Drawing.Color.White;
            this.button_cari_id.Location = new System.Drawing.Point(192, 48);
            this.button_cari_id.Name = "button_cari_id";
            this.button_cari_id.Size = new System.Drawing.Size(75, 24);
            this.button_cari_id.TabIndex = 37;
            this.button_cari_id.Text = "Cari";
            this.button_cari_id.UseVisualStyleBackColor = false;
            this.button_cari_id.Click += new System.EventHandler(this.button_carikolom_Click_1);
            // 
            // textbox_id
            // 
            this.textbox_id.BackColor = System.Drawing.Color.White;
            this.textbox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_id.Location = new System.Drawing.Point(16, 24);
            this.textbox_id.MaxLength = 50;
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.Size = new System.Drawing.Size(251, 20);
            this.textbox_id.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 96);
            this.panel1.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PaleGreen;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 59);
            this.label8.TabIndex = 26;
            this.label8.Text = "Aplikasi Zakat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Sitka Heading", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 33);
            this.label11.TabIndex = 38;
            this.label11.Text = "Untuk Administrator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(8, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 96);
            this.panel2.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.button_cari_nik);
            this.groupBox4.Controls.Add(this.textbox_nik);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(16, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 88);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cari Berdasarkan NIK";
            // 
            // button_cari_nik
            // 
            this.button_cari_nik.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_cari_nik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cari_nik.FlatAppearance.BorderSize = 0;
            this.button_cari_nik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button_cari_nik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cari_nik.ForeColor = System.Drawing.Color.White;
            this.button_cari_nik.Location = new System.Drawing.Point(192, 48);
            this.button_cari_nik.Name = "button_cari_nik";
            this.button_cari_nik.Size = new System.Drawing.Size(75, 24);
            this.button_cari_nik.TabIndex = 37;
            this.button_cari_nik.Text = "Cari";
            this.button_cari_nik.UseVisualStyleBackColor = false;
            this.button_cari_nik.Click += new System.EventHandler(this.button_cari_nik_Click);
            // 
            // textbox_nik
            // 
            this.textbox_nik.BackColor = System.Drawing.Color.White;
            this.textbox_nik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_nik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_nik.Location = new System.Drawing.Point(16, 24);
            this.textbox_nik.MaxLength = 50;
            this.textbox_nik.Name = "textbox_nik";
            this.textbox_nik.Size = new System.Drawing.Size(251, 20);
            this.textbox_nik.TabIndex = 35;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox5.Controls.Add(this.button_cari_nama);
            this.groupBox5.Controls.Add(this.textbox_nama);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Location = new System.Drawing.Point(16, 328);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(280, 88);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cari Berdasarkan Nama";
            // 
            // button_cari_nama
            // 
            this.button_cari_nama.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_cari_nama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cari_nama.FlatAppearance.BorderSize = 0;
            this.button_cari_nama.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button_cari_nama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cari_nama.ForeColor = System.Drawing.Color.White;
            this.button_cari_nama.Location = new System.Drawing.Point(192, 48);
            this.button_cari_nama.Name = "button_cari_nama";
            this.button_cari_nama.Size = new System.Drawing.Size(75, 24);
            this.button_cari_nama.TabIndex = 37;
            this.button_cari_nama.Text = "Cari";
            this.button_cari_nama.UseVisualStyleBackColor = false;
            this.button_cari_nama.Click += new System.EventHandler(this.button_cari_nama_Click);
            // 
            // textbox_nama
            // 
            this.textbox_nama.BackColor = System.Drawing.Color.White;
            this.textbox_nama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_nama.Location = new System.Drawing.Point(16, 24);
            this.textbox_nama.MaxLength = 50;
            this.textbox_nama.Name = "textbox_nama";
            this.textbox_nama.Size = new System.Drawing.Size(251, 20);
            this.textbox_nama.TabIndex = 35;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox6.Controls.Add(this.button_cari_jiwa);
            this.groupBox6.Controls.Add(this.textbox_jiwa);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Location = new System.Drawing.Point(16, 416);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(280, 88);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cari Berdasarkan Jumlah Jiwa";
            // 
            // button_cari_jiwa
            // 
            this.button_cari_jiwa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_cari_jiwa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cari_jiwa.FlatAppearance.BorderSize = 0;
            this.button_cari_jiwa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button_cari_jiwa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cari_jiwa.ForeColor = System.Drawing.Color.White;
            this.button_cari_jiwa.Location = new System.Drawing.Point(192, 48);
            this.button_cari_jiwa.Name = "button_cari_jiwa";
            this.button_cari_jiwa.Size = new System.Drawing.Size(75, 24);
            this.button_cari_jiwa.TabIndex = 37;
            this.button_cari_jiwa.Text = "Cari";
            this.button_cari_jiwa.UseVisualStyleBackColor = false;
            this.button_cari_jiwa.Click += new System.EventHandler(this.button_cari_jiwa_Click);
            // 
            // textbox_jiwa
            // 
            this.textbox_jiwa.BackColor = System.Drawing.Color.White;
            this.textbox_jiwa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_jiwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textbox_jiwa.Location = new System.Drawing.Point(16, 24);
            this.textbox_jiwa.MaxLength = 50;
            this.textbox_jiwa.Name = "textbox_jiwa";
            this.textbox_jiwa.Size = new System.Drawing.Size(251, 20);
            this.textbox_jiwa.TabIndex = 35;
            // 
            // label_waktu
            // 
            this.label_waktu.AutoSize = true;
            this.label_waktu.BackColor = System.Drawing.Color.Transparent;
            this.label_waktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_waktu.Location = new System.Drawing.Point(64, 16);
            this.label_waktu.Name = "label_waktu";
            this.label_waktu.Size = new System.Drawing.Size(113, 16);
            this.label_waktu.TabIndex = 38;
            this.label_waktu.Text = "Jum\'at 20-02-2023";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label_waktu);
            this.groupBox7.Location = new System.Drawing.Point(16, 112);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(280, 40);
            this.groupBox7.TabIndex = 44;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Waktu Saat Ini:";
            // 
            // button_backlogin
            // 
            this.button_backlogin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_backlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_backlogin.FlatAppearance.BorderSize = 0;
            this.button_backlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_backlogin.ForeColor = System.Drawing.Color.White;
            this.button_backlogin.Location = new System.Drawing.Point(464, 480);
            this.button_backlogin.Name = "button_backlogin";
            this.button_backlogin.Size = new System.Drawing.Size(123, 24);
            this.button_backlogin.TabIndex = 38;
            this.button_backlogin.Text = "Kembali ke Login";
            this.button_backlogin.UseVisualStyleBackColor = false;
            this.button_backlogin.Click += new System.EventHandler(this.button_backlogin_Click);
            // 
            // button_back_input
            // 
            this.button_back_input.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_back_input.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_back_input.FlatAppearance.BorderSize = 0;
            this.button_back_input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back_input.ForeColor = System.Drawing.Color.White;
            this.button_back_input.Location = new System.Drawing.Point(592, 480);
            this.button_back_input.Name = "button_back_input";
            this.button_back_input.Size = new System.Drawing.Size(123, 24);
            this.button_back_input.TabIndex = 45;
            this.button_back_input.Text = "Kembali ke Input";
            this.button_back_input.UseVisualStyleBackColor = false;
            this.button_back_input.Click += new System.EventHandler(this.button_back_input_Click);
            // 
            // searchformadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1137, 514);
            this.Controls.Add(this.button_back_input);
            this.Controls.Add(this.button_backlogin);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "searchformadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Zakat";
            this.Load += new System.EventHandler(this.nonadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_carintgl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_cari;
        private System.Windows.Forms.TextBox textbox_cari;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textbox_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_cari_id;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_cari_nik;
        private System.Windows.Forms.TextBox textbox_nik;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_cari_nama;
        private System.Windows.Forms.TextBox textbox_nama;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button_cari_jiwa;
        private System.Windows.Forms.TextBox textbox_jiwa;
        private System.Windows.Forms.Label label_waktu;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_backlogin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_back_input;
    }
}