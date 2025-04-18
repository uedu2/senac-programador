using FeiraDaFruta.Dominio;

namespace FeiraDaFruta
{
    public partial class Feira_Da_Fruta : Form
    {
        private Produto? produtos;

        public Feira_Da_Fruta()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Produto produtos = new Produto()
            {
                Nome = textBoxCriar.Text
            };

            if (produtos.Criar())
            {
                labelErro.Text = "Produto adicionado com sucesso!";
                return;
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewFrutas.SelectedRows.Count <= 0)
            {
                labelErro.Text = "Selecione um Produto!";
                return;
            }

            var linhaSelecionada = dataGridViewFrutas.SelectedRows[0];
        }

        private void Feira_Da_Fruta_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;
            Produto produto = new Produto();
            var listaprodutos = produto.ListarProdutos();
            dataGridViewFrutas.DataSource = listaprodutos;

        }
    }
}