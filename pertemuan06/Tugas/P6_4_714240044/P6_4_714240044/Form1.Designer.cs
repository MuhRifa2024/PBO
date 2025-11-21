namespace P6_4_714240044
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nama = new System.Windows.Forms.Label();
            this.nik = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.Label();
            this.tpLahir = new System.Windows.Forms.Label();
            this.umr = new System.Windows.Forms.Label();
            this.noTlp = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNik = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtTTL = new System.Windows.Forms.TextBox();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.txtnohp = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.epPeringatan = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSalah = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBenar = new System.Windows.Forms.ErrorProvider(this.components);
            this.kfPw = new System.Windows.Forms.Label();
            this.txtKonfirmasiPassword = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epPeringatan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSalah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBenar)).BeginInit();
            this.SuspendLayout();
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(63, 63);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(42, 18);
            this.nama.TabIndex = 0;
            this.nama.Text = "Nama";
            // 
            // nik
            // 
            this.nik.AutoSize = true;
            this.nik.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.nik.Location = new System.Drawing.Point(63, 91);
            this.nik.Name = "nik";
            this.nik.Size = new System.Drawing.Size(29, 18);
            this.nik.TabIndex = 1;
            this.nik.Text = "NIK";
            // 
            // alamat
            // 
            this.alamat.AutoSize = true;
            this.alamat.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.alamat.Location = new System.Drawing.Point(63, 127);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(50, 18);
            this.alamat.TabIndex = 2;
            this.alamat.Text = "Alamat";
            // 
            // tpLahir
            // 
            this.tpLahir.AutoSize = true;
            this.tpLahir.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.tpLahir.Location = new System.Drawing.Point(63, 157);
            this.tpLahir.Name = "tpLahir";
            this.tpLahir.Size = new System.Drawing.Size(140, 18);
            this.tpLahir.TabIndex = 3;
            this.tpLahir.Text = "Tempat, tanggal lahir";
            // 
            // umr
            // 
            this.umr.AutoSize = true;
            this.umr.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.umr.Location = new System.Drawing.Point(63, 197);
            this.umr.Name = "umr";
            this.umr.Size = new System.Drawing.Size(42, 18);
            this.umr.TabIndex = 4;
            this.umr.Text = "Umur";
            this.umr.Click += new System.EventHandler(this.tlLahir_Click);
            // 
            // noTlp
            // 
            this.noTlp.AutoSize = true;
            this.noTlp.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.noTlp.Location = new System.Drawing.Point(63, 252);
            this.noTlp.Name = "noTlp";
            this.noTlp.Size = new System.Drawing.Size(127, 18);
            this.noTlp.TabIndex = 5;
            this.noTlp.Text = "No. Handphone/WA";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Gold;
            this.title.Location = new System.Drawing.Point(284, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(241, 27);
            this.title.TabIndex = 6;
            this.title.Text = "CEK KESEHATAN GRATIS";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.email.Location = new System.Drawing.Point(63, 302);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 18);
            this.email.TabIndex = 7;
            this.email.Text = "Email";
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.pw.Location = new System.Drawing.Point(63, 341);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(65, 18);
            this.pw.TabIndex = 8;
            this.pw.Text = "Password";
            this.pw.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(262, 61);
            this.txtNama.MaxLength = 50;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(298, 20);
            this.txtNama.TabIndex = 9;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // txtNik
            // 
            this.txtNik.Location = new System.Drawing.Point(262, 89);
            this.txtNik.MaxLength = 16;
            this.txtNik.Name = "txtNik";
            this.txtNik.Size = new System.Drawing.Size(298, 20);
            this.txtNik.TabIndex = 10;
            this.txtNik.TextChanged += new System.EventHandler(this.txtNik_TextChanged);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(262, 125);
            this.txtAlamat.MaxLength = 100;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(298, 20);
            this.txtAlamat.TabIndex = 11;
            this.txtAlamat.Leave += new System.EventHandler(this.txtAlamat_Leave);
            // 
            // txtTTL
            // 
            this.txtTTL.Location = new System.Drawing.Point(262, 155);
            this.txtTTL.MaxLength = 25;
            this.txtTTL.Name = "txtTTL";
            this.txtTTL.Size = new System.Drawing.Size(298, 20);
            this.txtTTL.TabIndex = 12;
            this.txtTTL.Leave += new System.EventHandler(this.txtTTL_Leave);
            // 
            // txtUmur
            // 
            this.txtUmur.Location = new System.Drawing.Point(262, 195);
            this.txtUmur.MaxLength = 3;
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(298, 20);
            this.txtUmur.TabIndex = 13;
            this.txtUmur.Leave += new System.EventHandler(this.txtUmur_Leave);
            // 
            // txtnohp
            // 
            this.txtnohp.Location = new System.Drawing.Point(262, 250);
            this.txtnohp.MaxLength = 12;
            this.txtnohp.Name = "txtnohp";
            this.txtnohp.Size = new System.Drawing.Size(298, 20);
            this.txtnohp.TabIndex = 14;
            this.txtnohp.TextChanged += new System.EventHandler(this.txtnohp_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(262, 300);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 20);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(262, 339);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(298, 20);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // epPeringatan
            // 
            this.epPeringatan.ContainerControl = this;
            this.epPeringatan.Icon = ((System.Drawing.Icon)(resources.GetObject("epPeringatan.Icon")));
            // 
            // epSalah
            // 
            this.epSalah.ContainerControl = this;
            this.epSalah.Icon = ((System.Drawing.Icon)(resources.GetObject("epSalah.Icon")));
            // 
            // epBenar
            // 
            this.epBenar.ContainerControl = this;
            this.epBenar.Icon = ((System.Drawing.Icon)(resources.GetObject("epBenar.Icon")));
            // 
            // kfPw
            // 
            this.kfPw.AutoSize = true;
            this.kfPw.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kfPw.Location = new System.Drawing.Point(63, 373);
            this.kfPw.Name = "kfPw";
            this.kfPw.Size = new System.Drawing.Size(135, 18);
            this.kfPw.TabIndex = 17;
            this.kfPw.Text = "Konfirmasi Password";
            // 
            // txtKonfirmasiPassword
            // 
            this.txtKonfirmasiPassword.Location = new System.Drawing.Point(262, 371);
            this.txtKonfirmasiPassword.MaxLength = 50;
            this.txtKonfirmasiPassword.Name = "txtKonfirmasiPassword";
            this.txtKonfirmasiPassword.Size = new System.Drawing.Size(298, 20);
            this.txtKonfirmasiPassword.TabIndex = 18;
            this.txtKonfirmasiPassword.TextChanged += new System.EventHandler(this.txtKonfirmasiPassword_TextChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSimpan.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.Maroon;
            this.btnSimpan.Location = new System.Drawing.Point(671, 366);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(105, 29);
            this.btnSimpan.TabIndex = 19;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.HotPink;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(671, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 29);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(61)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtKonfirmasiPassword);
            this.Controls.Add(this.kfPw);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtnohp);
            this.Controls.Add(this.txtUmur);
            this.Controls.Add(this.txtTTL);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNik);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.email);
            this.Controls.Add(this.title);
            this.Controls.Add(this.noTlp);
            this.Controls.Add(this.umr);
            this.Controls.Add(this.tpLahir);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.nik);
            this.Controls.Add(this.nama);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form Cek Kesehatan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epPeringatan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSalah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBenar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label nik;
        private System.Windows.Forms.Label alamat;
        private System.Windows.Forms.Label tpLahir;
        private System.Windows.Forms.Label umr;
        private System.Windows.Forms.Label noTlp;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNik;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtTTL;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.TextBox txtnohp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ErrorProvider epPeringatan;
        private System.Windows.Forms.ErrorProvider epSalah;
        private System.Windows.Forms.ErrorProvider epBenar;
        private System.Windows.Forms.Label kfPw;
        private System.Windows.Forms.TextBox txtKonfirmasiPassword;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnExit;
    }
}

