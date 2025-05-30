using FeiraDaFruta.Dominio;

namespace FeiraDaFruta
{
    public partial class Feira_Da_Fruta : Form
    {
        private Produto? produtos;
        private void CarregarLista()
        {
            Produto produto = new Produto();
            var listaprodutos = produto.ListarProdutos();
            dataGridViewFrutas.DataSource = listaprodutos;
        }
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
            
            Produto produtos = new Produto()
            {
                Nome = textBoxCriar.Text
            };

        
            if (dataGridViewFrutas.SelectedRows.Count <= 0)
            {
                labelErro.Text = "Seleciona uma atividade.";
                return;
            }
            var linhaSelecionada = dataGridViewFrutas.SelectedRows[0];
            Produto produto = new()
            {
                Id = (int)linhaSelecionada.Cells[0].Value,
                Nome = (string)linhaSelecionada.Cells[1].Value,
                Dataproduto = (DateTime)linhaSelecionada.Cells[2].Value
            };
            RemocaoProdutos
        }

        private void Feira_Da_Fruta_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;
            CarregarLista();

        }
    }
}