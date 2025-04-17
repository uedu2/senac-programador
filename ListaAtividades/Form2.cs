using ListaAtividades.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAtividades
{
    public partial class Criar_Atividade : Form
    {
        public Criar_Atividade()
        {
            InitializeComponent();
        }

        private void Descartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void Criar_Atividade_Load(object sender, EventArgs e)
        {
            labelerro.Text = string.Empty;
        }
        private void Criar_Click(object sender, EventArgs e)
        {
            Atividade atividade = new Atividade()
            {
                Titulo = textBoxTitulo.Text
            };
            if (!atividade.Criar())
            {
                labelerro.Text = "Não foi possível criar a atividade.";
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        
        }


    }
}
