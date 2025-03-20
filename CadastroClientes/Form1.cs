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

        public bool verificador()
        {
            //nome
            string Novo_Nome = TextBoxNome.Text;
            if (string.IsNullOrWhiteSpace(Novo_Nome))         
            {
                label1.Text = "NOME não pode ser vazio";
                return false;
            }
            if (!Novo_Nome.Contains(" "))
            {
                label1.Text = "Nome Completo";
                return false;
            }
            if (Novo_Nome.Any(char.IsNumber))
            {
                label1.Text = "Nome não pode conter numeros";
                return false;
            }
            if (Novo_Nome.Any(char.IsPunctuation))
            {
                label1.Text = "Nome não pode conter simbolos";
                return false;
            }

            //data
            string Novo_DataDeNascimento = TextBoxData.Text;
            if (string.IsNullOrWhiteSpace(Novo_DataDeNascimento))
            {
                label1.Text = "não pode ser vazio";
                return false;
            }
            if (Novo_DataDeNascimento.Contains(" "))
            {
                label1.Text = "Data vazia";
                return false;
            }
            if (Novo_DataDeNascimento.Length < 10)
            {
                label1.Text = "Data incompleta";
                return false;
            }
            if (Novo_DataDeNascimento.Contains("30/02"))
            {
                label1.Text = "Data invalida";
                return false;
            }
            if (Novo_DataDeNascimento.Contains("31/02"))
            {
                label1.Text = "Data invalida";
                return false;
            }
          


            //telefone
            string Novo_Telefone = TextBoxTelefone.Text;
            if (string.IsNullOrWhiteSpace(Novo_Telefone))
            {
                label1.Text = "Telefone não pode ser vazio";
                return false;
            }
            if (Novo_Telefone.Length < 13)
            {
                label1.Text = "Telefone Incompleto!";
                return false;
            }
            if (Novo_Telefone.Contains(" "))
            {
                label1.Text = "Telefone Incompleto!";
                return false;
            }

            //email
            string Novo_Email = TextBoxEmail.Text;
            if (string.IsNullOrWhiteSpace(Novo_Email))
            {
                label1.Text = "não pode ser vazio";
                return false;
            }
            if (!Novo_Email.Contains("@"))
            {
                label1.Text = "Digite um Email válido!";
                return false;
            }
            if (!Novo_Email.Contains("."))
            {
                label1.Text = "Digite um Email válido!";
                return false;
            }
            if (Novo_Email.Contains(" "))
            {
                label1.Text = "Email incompleto";
                return false;
            }



            return true;
        }

        public bool Buscador() {
            string Novo_Nome = TextBoxNome.Text;
            string Novo_DataDeNascimento = TextBoxData.Text;
            string Novo_Telefone = TextBoxTelefone.Text;
            string Novo_Email = TextBoxEmail.Text;

            bool encontrado = false;

            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Email == Novo_Email)
                {
                    encontrado = true;
                    label1.Text = "Cliente (Email) já cadastrado!";
                    break;
                }
                if (clientes[i].Telefone == Novo_Telefone)
                {
                    encontrado = true;
                    label1.Text = "Cliente (Telefone) já cadastrado!";
                    break;
                }
                if (clientes[i].Id == 125)
                {
                    encontrado = true;
                    label1.Text = "Cliente (ID) já cadastrado!";
                    break;
                }
            }
            return encontrado;

        }

        private int GerarNovoId()
        {
            return clientes.Max(cliente => cliente.Id) + 1;
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

        private void Botao_Cadastrar_Click(object sender, EventArgs e)
        {

            string Novo_Nome = TextBoxNome.Text;
            string Novo_DataDeNascimento = TextBoxData.Text;
            string Novo_Telefone = TextBoxTelefone.Text;
            string Novo_Email = TextBoxEmail.Text;
            string Novo_NomeSocial = TextBoxNomeSocial.Text;

            NovoClienteDados novoClienteDados = Novos_Dados();
            Endereco endereco4 = new Endereco();
            int novoId = GerarNovoId();


            if (!verificador())
            {
                return;
            }

            if (!Buscador())
            {
                clientes.Add(new Cliente()
                {
                    Id = novoId,
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

                label1.Text = "Cliente cadastrado com sucesso!";
                return;
            }
            else
            {
                
            }

           
        }
    }
}