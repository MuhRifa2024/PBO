using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714240044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tlLahir_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SetErrorMessages(TextBox textBox, string peringatanMessage, string salahMessage, string benarMessage)
        {
            epPeringatan.SetError(textBox, peringatanMessage);
            epSalah.SetError(textBox, salahMessage);
            epBenar.SetError(textBox, benarMessage);
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            txtNama.CharacterCasing = CharacterCasing.Upper;
            if (txtNama.Text == "")
            {
                SetErrorMessages(txtNama, "Nama tidak boleh kosong!", "", "");
            }
            else if (txtNama.Text.Length > 50)
            {
                SetErrorMessages(txtNama, "", "Nama tidak boleh lebih dari 50 character!", "");
            }
            else if (txtNama.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                SetErrorMessages(txtNama, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtNama, "", "Hanya boleh huruf", "");
            }
        }

        private void txtNik_TextChanged(object sender, EventArgs e)
        {
            if (txtNik.Text == "")
            {
                SetErrorMessages(txtNik, "NIK tidak boleh kosong!", "", "");
            }
            else if (txtNik.Text.Length != 16)
            {
                SetErrorMessages(txtNik, "", "NIK harus 16 digit!", "");
            }
            else if (txtNik.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtNik, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtNik, "", "Hanya boleh angka", "");
            }
        }

        private void txtAlamat_Leave(object sender, EventArgs e) 
        {
            if (txtAlamat.Text == "")
            {
                SetErrorMessages(txtAlamat, "Alamat tidak boleh kosong!", "", "");
            }
            else if (txtAlamat.Text.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == ',' || c == '.'))
            {
                SetErrorMessages(txtAlamat, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtAlamat, "", "Tidak boleh memasukan symbol!", "");
            }
        }

        private void txtTTL_Leave(object sender, EventArgs e)
        {
            if (txtTTL.Text == "")
            {
                SetErrorMessages(txtTTL, "Tanggal Lahir tidak boleh kosong!", "", "");
            }
            else if (txtTTL.Text.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == ','))
            {
                SetErrorMessages(txtTTL, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtTTL, "", "Tidak boleh memasukan symbol!", "");
            }
        }

        private void txtUmur_Leave(object sender, EventArgs e)
        {
            if (txtUmur.Text == "")
            {
                SetErrorMessages(txtUmur, "Umur tidak boleh kosong!", "", "");
            }
            else if (txtUmur.Text.All(Char.IsNumber))
            {
                int umur = int.Parse(txtUmur.Text);

                if (umur < 17)
                {
                    SetErrorMessages(txtUmur, "", "Umur belum cukup (Min. 17) / Belum terdaftar", "");
                }
                else
                {
                    SetErrorMessages(txtUmur, "", "", "Betul!");
                }
            }
            else
            {
                SetErrorMessages(txtUmur, "Hanya boleh memasukan angka!", "", "");
            }
        }



        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            if (txtEmail.Text == "")
            {
                SetErrorMessages(txtEmail, "Textbox Email tidak boleh kosong!", "", "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                SetErrorMessages(txtEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtEmail, "", "Format email salah!\nContoh: a@b.c", "");
            }
        }

        
        private void txtnohp_TextChanged(object sender, EventArgs e)
        {
            if (txtnohp.Text == "")
            {
                SetErrorMessages(txtnohp, "No Handphone Tidak boleh kosong!", "", "");
            }
            else if (txtnohp.Text.Length > 13)
            {
                SetErrorMessages(txtnohp, "", "No HP tidak boleh lebih dari 13 angka", "");
            }
            else if (txtnohp.Text.Length < 12)
            {
                SetErrorMessages(txtnohp, "", "No HP tidak boleh kurang dari 12 angka", "");
            }
            else if (txtnohp.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtnohp, "", "", "Betul");
            }
            else
            {
                SetErrorMessages(txtnohp, "", "Hanya boleh angka!", "");
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                SetErrorMessages(txtPassword, "Password tidak boleh kosong!", "", "");
            }
            else if (txtPassword.Text.Length < 8)
            {
                SetErrorMessages(txtPassword, "", "Password terlalu pendek (min 8 karakter)!", "");
            }
            else
            {
                SetErrorMessages(txtPassword, "", "", "Password kuat!");
            }
        }

        private void txtKonfirmasiPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtKonfirmasiPassword.Text == "")
            {
                SetErrorMessages(txtKonfirmasiPassword, "", "", "");
            }
            else if (txtKonfirmasiPassword.Text != txtPassword.Text)
            {
                SetErrorMessages(txtKonfirmasiPassword, "", "Password tidak sama!", "");
            }
            else
            {
                SetErrorMessages(txtKonfirmasiPassword, "", "", "Password Cocok!");
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string pesanError = "";

            if (txtNama.Text == "") pesanError += "- Nama masih kosong\n";
            if (txtNik.Text == "") pesanError += "- Nik masih kosong\n";
            if (txtAlamat.Text == "") pesanError += "- Alamat masih kosong\n";
            if (txtTTL.Text == "") pesanError += "- TTL masih kosong\n";
            if (txtUmur.Text == "") pesanError += "- Umur masih kosong\n";
            if (txtnohp.Text == "") pesanError += "- No HP masih kosong\n";
            if (txtEmail.Text == "") pesanError += "- Email masih ksong\n";
            if (txtPassword.Text == "") pesanError += "- Password masih kosong\n";

            if (txtKonfirmasiPassword.Text != txtPassword.Text)
            {
                pesanError += "- Konfirmasi password tidak sama\n";
            }

            if (pesanError != "")
            {
                MessageBox.Show("Gagal menyimpan data! Harap perbaiki kesalahan berikut:\n\n" + pesanError, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(
            "Nama: " + txtNama.Text + "\n" +
            "NIK: " + txtNik.Text + "\n" +
            "Email: " + txtEmail.Text + "\n" +
            "No HP: " + txtnohp.Text + "\n" +
            "Umur: " + txtUmur.Text + "\n" +
            "Alamat: " + txtAlamat.Text,
            "Data Berhasil Disimpan",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
