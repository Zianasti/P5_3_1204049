using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P5_3_1204049
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string jkelamin = "";
        private void tbAkademik_Leave(object sender, EventArgs e)
        {


            if (Regex.IsMatch(tbAkademik.Text, @"^\d{4}/\d{4}$"))//Regex Validator
            {
                epCorrect.SetError(tbAkademik, "Betul!");
            }
            else
            {
                epWrong.SetError(tbAkademik, "Format Tahun Akademik salah!\nContoh: 2001/2002");
            }
            
        }

        private void ButtonPilihMatkul_Click(object sender, EventArgs e)
        {
           
            if (tbNim.Text == "")
            {
                epWarning.SetError(tbNim, "Textbox NIM tidak boleh kosong!"); //Required Validator
            }

            if (tbNama.Text == "")
            {
                epWarning.SetError(tbNama, "Textbox Nama tidak boleh kosong!"); //Required Validator
            }

            if (radioButton1.Checked)
            {
                jkelamin = jkelamin + "Laki-laki";
            }
            if (radioButton2.Checked)
            {
                jkelamin = jkelamin + "Perempuan";
            }
            if (jkelamin == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan Jenis Kelamin", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (tbAlamat.Text == "")
            {
                epWarning.SetError(tbAlamat, "Textbox Alamat tidak boleh kosong!"); //Required Validator
            }

            if (cbProdi.Text == "--Pilih Program Studi--")
            {
                epWarning.SetError(cbProdi, "Pilih Program Studi!"); //Required Validator
            }
            else
            {
                epCorrect.SetError(cbProdi, "Betul");
            }

            if (tbAkademik.Text == "")
            {
                epWarning.SetError(tbAkademik, "Textbox Tahun Akademik tidak boleh kosong!"); //Required Validator
            }

            if (tbAkademik.Text == "")
            {
                epWarning.SetError(tbAkademik, "Textbox Tahun Akademik tidak boleh kosong!"); //Required Validator
            }

            if (tbSemester.Text == "")
            {
                epWarning.SetError(tbSemester, "Textbox Semester tidak boleh kosong!"); //Required Validator
            }
            else
            {
                this.Size = new Size(680, 550);
            }
        }

        private void tbAlamat_Click(object sender, EventArgs e)
        {
            if (tbAlamat.Text != "")
            {
                epCorrect.SetError(tbAlamat, "Betul!");
            }
        }

        private void rbK06_CheckedChanged(object sender, EventArgs e)
        {
            if (rbK06.Checked)
            {
                cbMath.Enabled = true; cbMath.Checked = false;
                cbProg1.Enabled = true; cbProg1.Checked = false;
                cbProg2.Enabled = true; cbProg2.Checked = false;
                cbProg3.Enabled = true; cbProg3.Checked = false;
                cbProg4.Enabled = true; cbProg4.Checked = false;
                cbProg5.Enabled = true; cbProg5.Checked = false;
                cbProg6.Enabled = true; cbProg6.Checked = false;
                cbProg7.Enabled = true; cbProg7.Checked = false;
                cbPL.Enabled = false; cbPL.Checked = false;
                cbJarkom.Enabled = true; cbJarkom.Checked = false;
                cbSisop.Enabled = true; cbSisop.Checked = false;
                cbMRP.Enabled = false; cbMRP.Checked = false;
            }
        }

        private void rbK10_CheckedChanged(object sender, EventArgs e)
        {
            cbMath.Enabled = false; cbMath.Checked = false;
            cbProg1.Enabled = true; cbProg1.Checked = false;
            cbProg2.Enabled = true; cbProg2.Checked = false;
            cbProg3.Enabled = true; cbProg3.Checked = false;
            cbProg4.Enabled = true; cbProg4.Checked = false;
            cbProg5.Enabled = true; cbProg5.Checked = false;
            cbProg6.Enabled = true; cbProg6.Checked = false;
            cbProg7.Enabled = true; cbProg7.Checked = false;
            cbPL.Enabled = false; cbPL.Checked = false;
            cbJarkom.Enabled = true; cbJarkom.Checked = false;
            cbSisop.Enabled = true; cbSisop.Checked = false;
            cbMRP.Enabled = true; cbMRP.Checked = false;
        }

        private void rbK14_CheckedChanged(object sender, EventArgs e)
        {
            cbMath.Enabled = false; cbMath.Checked = false;
            cbProg1.Enabled = true; cbProg1.Checked = false;
            cbProg2.Enabled = true; cbProg2.Checked = false;
            cbProg3.Enabled = true; cbProg3.Checked = false;
            cbProg4.Enabled = true; cbProg4.Checked = false;
            cbProg5.Enabled = true; cbProg5.Checked = false;
            cbProg6.Enabled = true; cbProg6.Checked = false;
            cbProg7.Enabled = true; cbProg7.Checked = false;
            cbPL.Enabled = true; cbPL.Checked = false;
            cbJarkom.Enabled = true; cbJarkom.Checked = false;
            cbSisop.Enabled = true; cbSisop.Checked = false;
            cbMRP.Enabled = false; cbMRP.Checked = false;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string kurikulum = "";
            if (rbK06.Checked)
            {
                kurikulum = rbK06.Text;
            }
            else if (rbK10.Checked)
            {
                kurikulum = rbK10.Text;
            }
            else if (rbK14.Checked)
            {
                kurikulum = rbK14.Text; 
            }

            string matkul = "";
            if (cbMath.Checked)
            {
                matkul += cbMath.Text + ",";
            }
            if (cbProg1.Checked)
            {
                matkul += cbProg1.Text + ",";
            }
            if (cbProg2.Checked)
            {
                matkul += cbProg2.Text + ",";
            }
            if (cbProg3.Checked)
            {
                matkul += cbProg3.Text + ",";
            }
            if (cbProg4.Checked)
            {
                matkul += cbProg4.Text + ",";
            }
            if (cbProg5.Checked)
            {
                matkul += cbProg5.Text + ",";
            }
            if (cbProg6.Checked)
            {
                matkul += cbProg6.Text + ",";
            }
            if (cbProg7.Checked)
            {
                matkul += cbProg7.Text + ",";
            }
            if (cbPL.Checked)
            {
                matkul += cbPL.Text + ",";
            }
            if (cbJarkom.Checked)
            {
                matkul += cbJarkom.Text + ",";
            }
            if (cbSisop.Checked)
            {
                matkul += cbSisop.Text + ",";
            }
            if (cbMRP.Checked)
            {
                matkul += cbMRP.Text + ",";
            }

            MessageBox.Show
                ("NIM : " + tbNim.Text +
                "\nNama : " + tbNama.Text +
                "\nJenis Kelamin : " + jkelamin +
                "\nAlamat : " + tbAlamat.Text +
                "\nProgram Studi :" + cbProdi.Text +
                "\nTahun Akademik :" + tbAkademik.Text +
                "\nSemester :" + tbSemester.Text +
                "\nKurikulum : " + kurikulum +
                "\nMata Kuliah : " + matkul ,
                "Data Mata Kuliah Mahasiswa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            tbNim.Text = null;
            tbNama.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            tbAlamat.Text = null;
            cbProdi.Text = null;
            tbAkademik.Text = null;
            tbSemester.Text = null;

            rbK06.Checked = false;
            rbK10.Checked = false;
            rbK14.Checked = false;

            cbMath.Enabled = false; cbMath.Checked = false;
            cbProg1.Enabled = false; cbProg1.Checked = false;
            cbProg2.Enabled = false; cbProg2.Checked = false;
            cbProg3.Enabled = false; cbProg3.Checked = false;
            cbProg4.Enabled = false; cbProg4.Checked = false;
            cbProg5.Enabled = false; cbProg5.Checked = false;
            cbProg6.Enabled = false; cbProg6.Checked = false;
            cbProg7.Enabled = false; cbProg7.Checked = false;
            cbPL.Enabled = false; cbPL.Checked = false;
            cbJarkom.Enabled = false; cbJarkom.Checked = false;
            cbSisop.Enabled = false; cbSisop.Checked = false;
            cbMRP.Enabled = false; cbMRP.Checked = false;

            this.Size = new Size(680, 290);

            MessageBox.Show
                        ("Pengisian Data Telah dibatalkan.",
                        "Batal",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
