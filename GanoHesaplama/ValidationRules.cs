using Gano_Hesaplama_Aracı;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanoHesaplama
{
    internal class ValidationRules
    {
        Form1 form1 = new Form1();
        Form form = new Form();
        public void Empty(Form1 form1 )
        {


     //       if (
     //form1.textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||
     //textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty ||
     //textBox4.Text == String.Empty || textBox5.Text == String.Empty)
     //       {
     //           textBox1.BackColor = Color.Yellow;
     //           textBox2.BackColor = Color.Yellow;
     //           textBox3.BackColor = Color.Yellow;
     //           textBox4.BackColor = Color.Yellow;
     //           textBox5.BackColor = Color.Yellow;
     //           MessageBox.Show("Sarı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     //       }
     //       else
     //       {
     //           this.Visible = false;
     //           Form2 form2 = new Form2();
     //           form2.label6.Text = textBox1.Text;
     //           form2.label7.Text = textBox2.Text;
     //           form2.label8.Text = textBox3.Text;
     //           form2.label9.Text = textBox4.Text;
     //           form2.label10.Text = textBox5.Text + ".Sınıf";

     //           form2.ShowDialog();


     //       }


        }


        public void digital(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Sayisal Değer Giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
