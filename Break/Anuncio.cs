using Break;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakdance
{
    public partial class Anuncio : Form
    {
        public Anuncio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();

            // Mostre o Form2
            form2.Show();
            this.Hide();
        }
    }
}
