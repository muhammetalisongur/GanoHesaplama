using GanoHesaplama;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gano_Hesaplama_Aracı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Commands commands = new Commands();
        ValidationRules validationRules = new ValidationRules();

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtOkul.Clear();
            txtBolum.Clear();
            txtSinif.Clear();

            txtAd.BackColor = Color.White;
            txtSoyad.BackColor = Color.White;
            txtOkul.BackColor = Color.White;
            txtBolum.BackColor = Color.White;
            txtSinif.BackColor = Color.White;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



          
                this.Visible = false;
                Form2 form2 = new Form2();
                form2.label6.Text = txtAd.Text;
                form2.label7.Text = txtSoyad.Text;
                form2.label8.Text = txtOkul.Text;
                form2.label9.Text = txtBolum.Text;
                form2.label10.Text = txtSinif.Text + ".Sınıf";

                commands.saveFile(txtAd, txtSoyad, txtOkul, txtBolum, txtSinif);

                form2.ShowDialog();


            


        }

        private void txtSinif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                validationRules.digitalValue();
            }
        }

        private void txtSinif_TextChanged(object sender, EventArgs e)
        {
            if (txtSinif.Text != "")
            {
                try
                {
                    int sinif = Convert.ToInt32(txtSinif.Text);
                    if (sinif < 1)
                    {
                        MessageBox.Show("1 veya 4 aralığında rakam giriniz... ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtSinif.Text = txtSinif.Text.Remove(txtSinif.Text.Length - 1);

                    }
                    else if (sinif > 4)
                    {
                        MessageBox.Show("1 veya 4 aralığında rakam giriniz... ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtSinif.Text = txtSinif.Text.Remove(txtSinif.Text.Length - 1);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }



        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            validationRules.letterValue(txtSoyad.Text);
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAd.Text, "[^A-z ]"))
            {
                MessageBox.Show("Sadece Harf Giriniz... ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAd.Text = txtAd.Text.Remove(txtAd.Text.Length - 1);

            }
        }

        private void txtOkul_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtOkul.Text, "[^A-z ]"))
            {
                MessageBox.Show("Sadece Harf Giriniz... ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOkul.Text = txtOkul.Text.Remove(txtOkul.Text.Length - 1);

            }
        }

        private void txtBolum_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBolum.Text, "[^A-z ]"))
            {
                MessageBox.Show("Sadece Harf Giriniz... ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBolum.Text = txtBolum.Text.Remove(txtBolum.Text.Length - 1);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = commands.DataCsv();
        }

        private void txtAd_TextChanged_1(object sender, EventArgs e)
        {
            //validationRules.emptyValueAd(txtAd);
        }

        private void txtAd_MouseMove(object sender, MouseEventArgs e)
        {
            //validationRules.emptyValueAd(txtAd);
        }
    }
}
