using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_b1(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.Text)
                {
                    case "Вода":
                        textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.997);
                        break;
                    case "Кефир":
                        textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.031);
                        break;
                    case "Спирт":
                        textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.789);
                        break;
                    case "Бензин":
                        textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.7);
                        break;
                    case "Ртуть":
                        textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 13.596);
                        break;
                    case "Лед":
                        textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.9167);
                        break;
                    case "Золото":
                        textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 19.3);
                        break;
                }
                string output = String.Format("Литраж: {0}\tВещество: {1}\tКилограммы: {2}\n", textBox1.Text, comboBox1.Text, textBox2.Text);
                File.AppendAllText("C:\\\\Users\\im\\source\\repos\\WindowsFormsApp1\\File\\file.txt", output);
            }
            catch(Exception exep)
            {
                MessageBox.Show(exep.Message);
            }
        }
    }
}
