using ListaAtividades.Dominio;
using ListaAtividades.Repositorio;

namespace ListaAtividades
{
    public partial class Lista_De_Atividades : Form
    {
        private Atividade? atividadeEmAdamento;

        public Lista_De_Atividades()
        {
            InitializeComponent();
        }

        private void Lista_De_Atividades_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;

            CarregarListaDeAtividades();
            CarregarAtividadesEmAndamento();

        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (atividadeEmAdamento == null || atividadeEmAdamento.Id <= 0)
            {
                labelErro.Text = "Não há atividade em andamento.";
                return;
            }
            if (!atividadeEmAdamento.AtualizarSituacao())
            {
                labelErro.Text = "Não foi possível finalizar a atividade.";
                return;
            }
            CarregarAtividadesEmAndamento();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtividades.SelectedRows.Count <= 0)
            {
                labelErro.Text = "Selecione uma atividade.";
                return;
            }

            var linhaSelecionada = dataGridViewAtividades.SelectedRows[0];

            Atividade atividade = new()
            {
                Id = (int)linhaSelecionada.Cells[0].Value,
                Titulo = (string)linhaSelecionada.Cells[1].Value,
                Situacao = (Situacao)linhaSelecionada.Cells[2].Value
            };

            if (!atividade.AtualizarSituacao())
            {
                labelErro.Text = "Não foi possível atualizar a atividade.";
                return;
            }

            CarregarListaDeAtividades();
            CarregarAtividadesEmAndamento();

        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            var resultado = new Criar_Atividade().ShowDialog();

            if (resultado != DialogResult.OK) 
            { 
                labelErro.Text = "Criação da atividade não foi concluida";
                return;
            }

            labelErro.Text = "atividade criada com sucesso.";
            CarregarListaDeAtividades();
        }
        private void CarregarAtividadesEmAndamento()
        {
            Atividade atividade = new();

            atividadeEmAdamento = atividade.BuscarAtividadeEmAndamento();
            string textoAtividade = $"{atividadeEmAdamento.Id}-{atividadeEmAdamento.Titulo}";
            textBoxAtividadeEmAndamento.Text = atividadeEmAdamento.Id > 0 ? textoAtividade : string.Empty;
        }
        
        private void CarregarListaDeAtividades() 
        {
            Atividade atividade = new();
            
            var atividadesAtividadePendentes = atividade.ListarAtividadesPendentes();
            dataGridViewAtividades.DataSource = atividadesAtividadePendentes;

        }
    
    }  
}
