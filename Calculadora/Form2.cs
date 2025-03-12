using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void volume_Click(object sender, EventArgs e)
        {
            double.TryParse(base_.Text, out double num1);
            double.TryParse(largura.Text, out double num2);
            double.TryParse(altura.Text, out double num3);
            if (!base_.Text.All(char.IsNumber))
            {
                result_label.Text = "ambos os valores precisam ser números!";
                base_.Clear();
                largura.Clear();
                altura.Clear();
                return;
            }

            double num4 = num1 * num2 * num3;
            resultado.Text = "" + num4;
            base_.Clear();
            largura.Clear();
            altura.Clear();
        }

        private void perimetro_Click(object sender, EventArgs e)
        {
            double.TryParse(base_.Text, out double num1);
            if (!base_.Text.All(char.IsNumber))
            {
                result_label.Text = "ambos os valores precisam ser números!";
                base_.Clear();

                return;
            }

            double num3 = num1 * 4;
            resultado.Text = "" + num3;
            base_.Clear();
        }

        private void area_Click(object sender, EventArgs e)
        {
            double.TryParse(base_.Text, out double num1);
            if (!base_.Text.All(char.IsNumber))
            {
                result_label.Text = "ambos os valores precisam ser números!";
                base_.Clear();

                return;
            }

            double num3 = num1 * num1;
            resultado.Text = "" + num3;
            base_.Clear();
        }



        ////memes
        private void result_label_Click(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }

        private void altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void largura_TextChanged(object sender, EventArgs e)
        {

        }

        private void base__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
