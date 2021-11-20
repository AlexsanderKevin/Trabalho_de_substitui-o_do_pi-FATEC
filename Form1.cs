using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_Substituição_do_PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double maior (double a, double b)
        {
            double maior_num = 0;

            if (b > a)
            {
                maior_num = b;
            } else if (a > b)
            {
                maior_num = a; 
            }

            return maior_num;
        }

        double menor (double a, double b)
        {
            double menor_num = 0;

            if (a < b)
            {
                menor_num = a;
            }else if (b < a)
            {
                menor_num = b;
            }

            return menor_num;
        }

        double somar (double a, double b)
        {
            double soma = a + b;

            return soma;
        }

        double mediar (double a, double b)
        {
            double media = (a + b) / 2;

            return media;
        }

        private void button_maior_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num_1.Text);
            double num2 = Convert.ToDouble(num_2.Text);

            result.Text = Convert.ToString(maior(num1, num2));
        }

        private void button_menor_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num_1.Text);
            double num2 = Convert.ToDouble(num_2.Text);

            result.Text = Convert.ToString(menor(num1, num2));
        }

        private void button_soma_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num_1.Text);
            double num2 = Convert.ToDouble(num_2.Text);

            result.Text = Convert.ToString(somar(num1, num2));
        }

        private void button_media_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num_1.Text);
            double num2 = Convert.ToDouble(num_2.Text);

            result.Text = Convert.ToString(mediar(num1, num2));
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tchau!");
            this.Close();
        }
    }
}
