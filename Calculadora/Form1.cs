using System.Buffers.Text;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


        }

        private void numero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }

        private void mais_Click(object sender, EventArgs e)
        {
            double.TryParse(Numero1.Text, out double num1);
            double.TryParse(numero2.Text, out double num2);

            double num3 = num1 + num2;
            string resul = Numero1.Text.All(char.IsNumber) || numero2.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";
            
            resultado.Text = resul;
            numero2.Clear();
            Numero1.Clear();
        }

        private void simbolo_Click(object sender, EventArgs e)
        {

        }
        private void menos_Click(object sender, EventArgs e)
        {
            double.TryParse(Numero1.Text, out double num1);
            double.TryParse(numero2.Text, out double num2);

            double num3 = num1 - num2;
            string resul = Numero1.Text.All(char.IsNumber) || numero2.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";
            
            resultado.Text = resul;
            numero2.Clear();
            Numero1.Clear();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            double.TryParse(Numero1.Text, out double num1);
            double.TryParse(numero2.Text, out double num2);

            double num3 = num1 / num2;
            string resul = Numero1.Text.All(char.IsNumber) || numero2.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";
            
            resultado.Text = resul;
            numero2.Clear();
            Numero1.Clear();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            double.TryParse(Numero1.Text, out double num1);
            double.TryParse(numero2.Text, out double num2);

            double num3 = num1 * num2;
            string resul = Numero1.Text.All(char.IsNumber) || numero2.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";
            
            resultado.Text = resul;
            numero2.Clear();
            Numero1.Clear();
        }

        private void wesley_Click(object sender, EventArgs e)
        {
            // Crie uma nova instância do Form2
            Form2 form2 = new Form2();

            // Mostre o Form2
            form2.ShowDialog();
            //this.Hide();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            simbolo.Text = checkedListBox1.Text.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (simbolo.Text == "+")
            {
                double.TryParse(Numero1.Text, out double num1);
                double.TryParse(numero2.Text, out double num2);

                double num3 = num1 + num2;
                string resul = Numero1.Text.All(char.IsNumber) || numero2.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";

                resultado.Text = resul;
                numero2.Clear();
                Numero1.Clear();
            }
            else if (simbolo.Text == "-")
            {
                double.TryParse(Numero1.Text, out double num1);
                double.TryParse(numero2.Text, out double num2);

                double num3 = num1 - num2;
                string resul = Numero1.Text.All(char.IsNumber) || numero2.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";

                resultado.Text = resul;
                numero2.Clear();
                Numero1.Clear();
            }
            else if (simbolo.Text == "*") 
            {
                double.TryParse(Numero1.Text, out double num1);
                double.TryParse(numero2.Text, out double num2);
               
                double num3 = num1 * num2;
                string resul = Numero1.Text.All(char.IsNumber) || numero2.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";

                resultado.Text = resul;
                numero2.Clear();
                Numero1.Clear();
            }
            else if (simbolo.Text == "/")
            {
                double.TryParse(Numero1.Text, out double num1);
                double.TryParse(numero2.Text, out double num2);
                
                double num3 = num1 / num2;
                string resul = Numero1.Text.All(char.IsNumber) || numero2.Text.All(char.IsNumber) ? "" + num3 : "ambos os valores precisam ser números!";

                resultado.Text = resul;
                numero2.Clear();
                Numero1.Clear();
            }
        }
    }
}
