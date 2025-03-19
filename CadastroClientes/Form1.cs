using CadastroClientes.Dados;

namespace CadastroClientes
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();

        public class NovoClienteDados
        {
            public string Nome { get; set; }
            public string DataDeNascimento { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }
            public string NomeSocial { get; set; }
        }
        public NovoClienteDados Novos_Dados()
        {
            return new NovoClienteDados
            {
                Nome = TextBoxNome.Text,
                DataDeNascimento = TextBoxData.Text,
                Telefone = TextBoxTelefone.Text,
                Email = TextBoxEmail.Text,
                NomeSocial = TextBoxNomeSocial.Text
            };
        }



        public Form1()
        {

            InitializeComponent();

            Endereco endereco1 = new Endereco();// { Logradouro = "Rua dos Bobos", Numero = "0", Complemento = 
                                                // "Casa", Bairro = "Bairro do Limoeiro", Municipio = "Sei lá", Estado = "Gasoso", Cep = "00000-000" };

            Endereco endereco2 = new Endereco();

            Endereco endereco3 = new Endereco();


            clientes.Add(new Cliente()
            {
                Id = 123,
                Nome = "Wesley",
                DataDeNascimento = "12/12/12",
                Telefone = "40028922",
                Email = "Wesley@Gmail.com",
                Endereco = endereco1,
                Genero = Genero.Masculino,
                NomeSocial = "gathusco",
                Etinia = Etinia.Branco,
                Estrangeiro = false,
                TipoCliente = TipoCliente.PessoaFisica
            }); //posso adiconar um item a lista desse modo.

            Cliente Julia = new Cliente()
            {
                Id = 321,
                Nome = "Julia",
                DataDeNascimento = "10/10/10",
                Telefone = "40028922",
                Email = "julia@Gmail.com",
                Endereco = endereco2,
                Genero = Genero.Feminino,
                NomeSocial = "capivara",
                Etinia = Etinia.Branco,
                Estrangeiro = false,
                TipoCliente = TipoCliente.PessoaFisica
            }; //posso adicionar um item a lista desse modo. a diferença deles é que o primeiro é um objeto anonimo e o segundo é um objeto nomeado.
            clientes.Add(Julia);

            Cliente Daniel = new Cliente()
            {
                Id = 213,
                Nome = "Daniel",
                DataDeNascimento = "11/11/11",
                Telefone = "40028922",
                Email = "daniel@Gmail.com",
                Endereco = endereco3,
                Genero = Genero.Masculino,
                NomeSocial = "chorrosco",
                Etinia = Etinia.Branco,
                Estrangeiro = false,
                TipoCliente = TipoCliente.PessoaFisica
            };
            clientes.Add(Daniel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoClienteDados novoClienteDados = Novos_Dados();
            Endereco endereco4 = new Endereco();
            if (TextBoxNome.Text == "") 
            {
                label1.Text = "não pode ser vazio";
                return;
            }
            if (TextBoxData.Text == "") 
            {
                label1.Text = "não pode ser vazio";
                return;
            }
            if (TextBoxTelefone.Text == "") 
            {
                label1.Text = "não pode ser vazio";
                return;
            }
             if (TextBoxEmail..Text == "") 
            {
                label1.Text = "não pode ser vazio";
                return;
            }
            clientes.Add(new Cliente()
            {
                Id = 124,
                Nome = novoClienteDados.Nome,
                DataDeNascimento = novoClienteDados.DataDeNascimento,
                Telefone = novoClienteDados.Telefone,
                Email = novoClienteDados.Email,
                Endereco = endereco4,
                Genero = Genero.Masculino,
                NomeSocial = novoClienteDados.NomeSocial,
                Etinia = Etinia.Branco,
                Estrangeiro = false,
                TipoCliente = TipoCliente.PessoaFisica
            });

        }
    }
}
