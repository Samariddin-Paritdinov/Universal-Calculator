using System;
using System.Windows.Forms;
using System.IO;

namespace Kurs_Ishi_4_sem
{
    public partial class Form2 : Form
    {
        string historyFilePath = @"C:\Users\user\Desktop\Paritdinov_Samariddin_Kurs_ishi_2-kurs_4-sem\history.txt";

        public Form2()
        {
            InitializeComponent();

            if (File.Exists(historyFilePath))
            {
                textBox1.Text = File.ReadAllText(historyFilePath);
            }
            else
            {
                textBox1.Text = "Tarix topilmadi.";
            }
        }


        private void Clear_Click(object sender, EventArgs e)
        {
            File.WriteAllText(historyFilePath, "");

            textBox1.Text = "";
        }
    }
}
