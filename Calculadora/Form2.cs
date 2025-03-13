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


        private void volumes()
        {
            bool volume = cubo.Checked == false && paralelepipedo.Checked == true ? true : false;
            bool massa = cubo.Checked == false && paralelepipedo.Checked == true || retangulo.Checked == true ? true : false;

            if (volume == true)
            {
                altura.Enabled = true;
            }
            if (volume == false)
            {
                altura.Enabled = false;
            }
            if (massa == true)
            {
                largura.Enabled = true;
            }
            if (massa == false)
            {
                largura.Enabled = false;
            }
        }


            private void volume_Click(object sender, EventArgs e)
        {
            double.TryParse(base_.Text, out double num1);
            double.TryParse(largura.Text, out double num2);
            double.TryParse(altura.Text, out double num3);

            if (cubo.Checked == true) 
            {
                double num4 = num1 * num1 * num1;
                string resul = base_.Text.All(char.IsNumber) ? "" + num4 : "ambos os valores precisam ser números!";

                resultado.Text = resul;
            }

            if (paralelepipedo.Checked == true) 
            {
                double num4 = num1 * num2 * num3;
                string resul = base_.Text.All(char.IsNumber) ? "" + num4 : "ambos os valores precisam ser números!";

                resultado.Text = resul;
            }
            
            base_.Clear();
            largura.Clear();
            altura.Clear();
        }

        private void perimetro_Click(object sender, EventArgs e)
        {
            double.TryParse(base_.Text, out double num1);
            double.TryParse(largura.Text, out double num2);
            double.TryParse(altura.Text, out double num4);
            if (quadrado.Checked)
            {

                double num3 = num1 * 4;
                string resul = base_.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";

                resultado.Text = resul;
            }
            if (retangulo.Checked)
            {
                double num3 =  2 * (num1 + num2);
                string resul = base_.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";

                resultado.Text = resul;
            }
            if (cubo.Checked)
            {

                double num3 = 12 * (num1);
                string resul = base_.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";

                resultado.Text = resul;
            }
            if (paralelepipedo.Checked) 
            {

                double num3 = (4 * num1) + (4 * num2) + (4 * num4);
                string resul = base_.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";

                resultado.Text = resul;

                


            }

            base_.Clear();
            largura.Clear();
            altura.Clear();
        }

        private void area_Click(object sender, EventArgs e)
        {
            double.TryParse(base_.Text, out double num1);
            double.TryParse(largura.Text, out double num2);
            double.TryParse(altura.Text, out double num4);
            if (quadrado.Checked)
            {
                double num3 = num1 * num1;
                string resul = base_.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";

                resultado.Text = resul;
            }
            if (retangulo.Checked)
            {
                double num3 = num1 * num2;
                string resul = base_.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";

                resultado.Text = resul;

            }
            if (cubo.Checked)
            {
                double num3 = (num1 * num1) * 6;
                string resul = base_.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";

                resultado.Text = resul;

            }
            if (paralelepipedo.Checked)
            {
                
                double num5 =  2 * ((num1 * num2) +(num1 * num4) + (num2 * num4));
                
                string resul = base_.Text.All(char.IsNumber) ? "" + num5 : "ambos os valores precisam ser números!";
                resultado.Text = resul;
            }

            base_.Clear();
            largura.Clear();
            altura.Clear();
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

        private void paralelepipedo_CheckedChanged(object sender, EventArgs e)
        {
            volumes();


        }

        private void cubo_CheckedChanged(object sender, EventArgs e)
        {
            volumes();
        }

        private void quadrado_CheckedChanged(object sender, EventArgs e)
        {
            volumes();

        }

        private void retangulo_CheckedChanged(object sender, EventArgs e)
        {
            volumes();
        }
        
        }

    }

