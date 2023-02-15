using Gano_Hesaplama_Aracı;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanoHesaplama
{
    internal class Commands
    {
        string path = AppDomain.CurrentDomain.BaseDirectory + @"GanoHesaplama.csv";

        public void saveFile(TextBox txtAd, TextBox txtSoyad, TextBox txtOkul, TextBox txtBolum, TextBox txtSinif)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (!File.Exists(path))
            {
                stringBuilder.Append("Ad"); stringBuilder.Append(";");
                stringBuilder.Append("Soyad"); stringBuilder.Append(";");
                stringBuilder.Append("Okul"); stringBuilder.Append(";");
                stringBuilder.Append("Bölüm"); stringBuilder.Append(";");
                stringBuilder.AppendLine("Sınıf");
            }
            stringBuilder.Append(txtAd.Text); stringBuilder.Append(";");
            stringBuilder.Append(txtSoyad.Text); stringBuilder.Append(";");
            stringBuilder.Append(txtOkul.Text); stringBuilder.Append(";");
            stringBuilder.Append(txtBolum.Text); stringBuilder.Append(";");
            stringBuilder.AppendLine(txtSinif.Text + ".Sınıf");
            File.AppendAllText(path, stringBuilder.ToString(), Encoding.UTF8);

            MessageBox.Show("Başarılı bir şekilde eklendi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public DataTable DataCsv()
        {
            DataTable dataTable = new DataTable();

            string[] lines = File.ReadAllLines(path);

            if (lines.Length > 0)
            {
                string firtsLine = lines[0];
                string[] headLabels = firtsLine.Split(';');

                foreach (string headerWord in headLabels)
                {
                    dataTable.Columns.Add(new DataColumn(headerWord));
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(';');
                    DataRow dr = dataTable.NewRow();
                    int columnIndex = 0;
                    for (int j = 0; j < dataWords.Length; j++)
                    {
                        dr[j] = dataWords[columnIndex++];
                    }
                    dataTable.Rows.Add(dr);
                }
            }
            return dataTable;


        }
    }
}
