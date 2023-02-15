using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanoHesaplama
{
    internal class ValidationRules
    {
        public void letterValue(string txtSoyad)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSoyad, "[^A-z ]"))
            {
                MessageBox.Show("Sadece Harf Giriniz... ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSoyad = txtSoyad.Remove(txtSoyad.Length - 1);

            }
        }
        public void digitalValue()
        {
            MessageBox.Show("Sayisal Değer Giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void emptyValueAd(TextBox txtAd, Label label)
        {

            if (txtAd.Text == "" || txtAd.Text == string.Empty)
            {
                txtAd.BackColor = Color.Yellow;
                
                MessageBox.Show("Sarı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtAd.BackColor = Color.White;
            }
        }

        public void emptyValueSoyad(TextBox txtAd, TextBox txtSoyad, TextBox txtOkul, TextBox txtBolum, TextBox txtSinif)
        {

            if (txtAd.Text == "" || txtSoyad.Text == "" || txtOkul.Text == "" || txtBolum.Text == "" || txtSinif.Text == "" ||
                txtAd.Text == string.Empty || txtSoyad.Text == String.Empty || txtOkul.Text == String.Empty ||
                txtBolum.Text == string.Empty || txtSinif.Text == String.Empty)
            {
                txtAd.BackColor = Color.Yellow;
                txtSoyad.BackColor = Color.Yellow;
                txtOkul.BackColor = Color.Yellow;
                txtBolum.BackColor = Color.Yellow;
                txtSinif.BackColor = Color.Yellow;
                MessageBox.Show("Sarı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void emptyValueOkul(TextBox txtAd, TextBox txtSoyad, TextBox txtOkul, TextBox txtBolum, TextBox txtSinif)
        {

            if (txtAd.Text == "" || txtSoyad.Text == "" || txtOkul.Text == "" || txtBolum.Text == "" || txtSinif.Text == "" ||
                txtAd.Text == string.Empty || txtSoyad.Text == String.Empty || txtOkul.Text == String.Empty ||
                txtBolum.Text == string.Empty || txtSinif.Text == String.Empty)
            {
                txtAd.BackColor = Color.Yellow;
                txtSoyad.BackColor = Color.Yellow;
                txtOkul.BackColor = Color.Yellow;
                txtBolum.BackColor = Color.Yellow;
                txtSinif.BackColor = Color.Yellow;
                MessageBox.Show("Sarı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void emptyValueBolum(TextBox txtAd, TextBox txtSoyad, TextBox txtOkul, TextBox txtBolum, TextBox txtSinif)
        {

            if (txtAd.Text == "" || txtSoyad.Text == "" || txtOkul.Text == "" || txtBolum.Text == "" || txtSinif.Text == "" ||
                txtAd.Text == string.Empty || txtSoyad.Text == String.Empty || txtOkul.Text == String.Empty ||
                txtBolum.Text == string.Empty || txtSinif.Text == String.Empty)
            {
                txtAd.BackColor = Color.Yellow;
                txtSoyad.BackColor = Color.Yellow;
                txtOkul.BackColor = Color.Yellow;
                txtBolum.BackColor = Color.Yellow;
                txtSinif.BackColor = Color.Yellow;
                MessageBox.Show("Sarı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void emptyValueSinif(TextBox txtAd, TextBox txtSoyad, TextBox txtOkul, TextBox txtBolum, TextBox txtSinif)
        {

            if (txtAd.Text == "" || txtSoyad.Text == "" || txtOkul.Text == "" || txtBolum.Text == "" || txtSinif.Text == "" ||
                txtAd.Text == string.Empty || txtSoyad.Text == String.Empty || txtOkul.Text == String.Empty ||
                txtBolum.Text == string.Empty || txtSinif.Text == String.Empty)
            {
                txtAd.BackColor = Color.Yellow;
                txtSoyad.BackColor = Color.Yellow;
                txtOkul.BackColor = Color.Yellow;
                txtBolum.BackColor = Color.Yellow;
                txtSinif.BackColor = Color.Yellow;
                MessageBox.Show("Sarı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
