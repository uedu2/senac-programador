using ListaAtividades.Dominio;

namespace ListaAtividades
{
    public partial class Lista_De_Atividades : Form
    {
        public Lista_De_Atividades()
        {
            InitializeComponent();
        }

        private void Lista_De_Atividades_Load(object sender, EventArgs e)
        {
            Atividade atividade = new ();

            var atividadesEmAndamento = atividade.BuscarAtividadeEmAndamento();
            if (atividadesEmAndamento.Id > 0) 
            {
                textBoxAtividadeEmAndamento.Text = $"{atividadesEmAndamento.Id}-{atividadesEmAndamento.Titulo}";
            } 
            
            
            var atividadesAtividadePendentes = atividade.ListarAtividadesPendentes();
            dataGridViewAtividades.DataSource = atividadesEmAndamento;
        }
    }
}
