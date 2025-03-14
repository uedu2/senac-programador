using System.Globalization;

namespace esferas_do_dragao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double pi = 3.14;
        double Volume;


        private void volume_Click_1(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out double R);
            Volume = (4 / 3.0) * pi * Math.Pow(R, 3);
            Resul.Text = Volume.ToString("F");
        }

        private void raio_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out double R);
            Volume = R/2;
            Resul.Text = Volume.ToString("F");
        }

        private void circunferencia_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out double R);
            Volume = 2 * pi * R;
            Resul.Text = Volume.ToString("F");
        }

        private void diametro_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out double R);
            Volume = 2 * R;
            Resul.Text = Volume.ToString("F");
        }

        private void area_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out double R);
            Volume =  pi * Math.Pow(R, 2);
            Resul.Text = Volume.ToString("F");

        }
    }
}
