using CadastroClientes.Dados;
using CadastroClientes.NovosDados;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
namespace CadastroClientes
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();

        private readonly BindingSource BindingSource = [];

        public NovoClienteDados Novos_Dados() // metodo para pegar os dados do novo cliente
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

        public bool Verificador_NovoCliente() // metodo para verificar se os campos do novo cliente est„o preenchidos corretamente
        {
            //nome
            string Novo_Nome = TextBoxNome.Text;
            if (string.IsNullOrWhiteSpace(Novo_Nome))         
            {
                label1.Text = "NOME n„o pode ser vazio";
                return false;
            }
            if (!Novo_Nome.Contains(" "))
            {
                label1.Text = "Nome Completo";
                return false;
            }
            if (Novo_Nome.Any(char.IsNumber))
            {
                label1.Text = "Nome n„o pode conter numeros";
                return false;
            }
            if (Novo_Nome.Any(char.IsPunctuation))
            {
                label1.Text = "Nome n„o pode conter simbolos";
                return false;
            }

            //data
            string Novo_DataDeNascimento = TextBoxData.Text;
            if (string.IsNullOrWhiteSpace(Novo_DataDeNascimento))
            {
                label1.Text = "n„o pode ser vazio";
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
            DateTime temp;

            if (!DateTime.TryParse(Novo_DataDeNascimento, out temp))
            {
                label1.Text = "Data invalida";
                return false;
            }
            int index = 6;
            string ano = TextBoxData.Text.Substring(index);
            if (Convert.ToInt32(ano) > 2007 || Convert.ToInt32(ano) < 1900)
            {
                label1.Text = "Data invalida";
                return false;
            }




            //telefone
            string Novo_Telefone = TextBoxTelefone.Text;
            if (string.IsNullOrWhiteSpace(Novo_Telefone))
            {
                label1.Text = "Telefone n„o pode ser vazio";
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
                label1.Text = "n„o pode ser vazio";
                return false;
            }
            if (!Novo_Email.Contains("@"))
            {
                label1.Text = "Digite um Email v·lido!";
                return false;
            }
            if (!Novo_Email.Contains("."))
            {
                label1.Text = "Digite um Email v·lido!";
                return false;
            }
            if (Novo_Email.Contains(" "))
            {
                label1.Text = "Email incompleto";
                return false;
            }

            //genero
            string Novo_Genero = ComboBoxGenero.Text;
            if (string.IsNullOrWhiteSpace(Novo_Genero))
            {
                label1.Text = "Selecione um genero!";
                return false;
            }
            //nome social
            string Novo_NomeSocial = TextBoxNomeSocial.Text;
            if (Novo_Nome.Any(char.IsNumber))
            {
                label1.Text = "NomeSoci n„o pode conter numeros";
                return false;
            }
            if (Novo_Nome.Any(char.IsPunctuation))
            {
                label1.Text = "NomeSoci n„o pode conter simbolos";
                return false;
            }

            //etinia
            string Nova_Etinia = ComboBoxGenero.Text;
            if (string.IsNullOrWhiteSpace(Nova_Etinia))
            {
                label1.Text = "Selecione sua Etinia";
                return false;
            }



            return true;
        }


        public bool Verificador_NovoEndereco() // metodo para verificar se os campos do novo endereco est„o preenchidos corretamente
        {


            //logradouro
            string Novo_Logradouro = TextBoxLogradouro.Text;
            if (Novo_Logradouro.Any(char.IsNumber))
            {
                label1.Text = "Logradouro n„o pode conter numeros";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Novo_Logradouro))
            {
                label1.Text = "Logradouro invalido";
                return false;
            }

            //numero
            string Novo_Numero = TextBoxNumero.Text;
            if (!Novo_Numero.Any(char.IsNumber))
            {
                label1.Text = "Numero invalido";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Novo_Numero))
            {
                label1.Text = "Numero invalido";
                return false;
            }

            //bairro
            string Novo_Bairro = TextBoxBairro.Text;
            if (Novo_Bairro.Any(char.IsNumber)) 
            {
                label1.Text = "Bairro invalido";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Novo_Bairro))
            {
                label1.Text = "Bairro invalido";
                return false;
            }

            //municipio
            string Novo_Municipio = TextBoxMunicipio.Text;
            if (Novo_Municipio.Any(char.IsNumber))
            {
                label1.Text = "Municipio invalido";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Novo_Municipio))
            {
                label1.Text = "Municipio invalido";
                return false;
            }

            //estado
            string Novo_Estado = ComboBoxEstado.Text;
            if (string.IsNullOrWhiteSpace(Novo_Estado))
            {
                label1.Text = "Estado invalido";
                return false;
            }

            //cep
            string Novo_Cep = TextBoxCEP.Text;
            if (!Novo_Cep.Any(char.IsNumber))
            {
                label1.Text = "CEP invalido";
                return false;
            }
            if (Novo_Cep.Length < 9)
            {
                label1.Text = "CEP invalido";
                return false;
            }


            return true;
        }











        public bool Buscador() {
            string Novo_Nome = TextBoxNome.Text;
            string Novo_DataDeNascimento = TextBoxData.Text;
            string Novo_Telefone = TextBoxTelefone.Text;
            string Novo_Email = TextBoxEmail.Text;
            string Novo_Genero = ComboBoxGenero.Text;

            bool encontrado = false;

            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Email == Novo_Email)
                {
                    encontrado = true;
                    label1.Text = "Cliente (Email) j· cadastrado!";
                    break;
                }
                if (clientes[i].Telefone == Novo_Telefone)
                {
                    encontrado = true;
                    label1.Text = "Cliente (Telefone) j· cadastrado!";
                    break;
                }
                if (clientes[i].Id == 125)
                {
                    encontrado = true;
                    label1.Text = "Cliente (ID) j· cadastrado!";
                    break;
                }
            }
            return encontrado;

        } // metodo para verificar se o cliente j· est· cadastrado

        private int GerarNovoId() // metodo para gerar um novo ID para o cliente
        {
            return clientes.Max(cliente => cliente.Id) + 1;
        }

        public Form1()
        {

            InitializeComponent();

            Endereco endereco1 = new Endereco();

            Endereco endereco2 = new Endereco();

            Endereco endereco3 = new Endereco();


            clientes.Add(new Cliente()
            {
                Id = 10,
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
                Id = 11,
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
            }; //posso adicionar um item a lista desse modo. a diferen√ßa deles √© que o primeiro √© um objeto anonimo e o segundo √© um objeto nomeado.
            clientes.Add(Julia);

            Cliente Daniel = new Cliente()
            {
                Id = 12,
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

            BindingSource.DataSource = clientes;
            dataGridViewClientes.DataSource = BindingSource;

        }

        private void Botao_Cadastrar_Click(object sender, EventArgs e)
        {

            string Novo_Nome = TextBoxNome.Text;
            string Novo_DataDeNascimento = TextBoxData.Text;
            string Novo_Telefone = TextBoxTelefone.Text;
            string Novo_Email = TextBoxEmail.Text;
            string Novo_NomeSocial = TextBoxNomeSocial.Text;
            bool Novo_Estrangeiro = CheckBoxEstrangeiroSim.Checked;


            NovoClienteDados novoClienteDados = Novos_Dados();

            int novoId = GerarNovoId();

            if (!Verificador_NovoEndereco()) 
            {
                return;
            }

            Endereco endereco_Novo = new Endereco()
            {
                Logradouro = TextBoxLogradouro.Text,
                Numero = TextBoxNumero.Text,
                Complemento = TextBoxComplemento.Text,
                Bairro = TextBoxBairro.Text,
                Municipio = TextBoxMunicipio.Text,
                Estado = ComboBoxEstado.Text,
                Cep = TextBoxCEP.Text

            };


            if (!Verificador_NovoCliente())
            {
                return;
            }

            if (!Buscador())
            {
                int tipoClienteIndex = RadioButtonPessoaFisica.Checked ? 0 : 1;
                TipoCliente tipoClienteSelecionado = (TipoCliente)tipoClienteIndex;

                clientes.Add(new Cliente()
                {
                    Id = novoId,
                    Nome = novoClienteDados.Nome,
                    DataDeNascimento = novoClienteDados.DataDeNascimento,
                    Telefone = novoClienteDados.Telefone,
                    Email = novoClienteDados.Email,
                    Endereco = endereco_Novo,
                    Genero = (Genero)ComboBoxGenero.SelectedIndex, //È assim que ENUMs funcionam e s„o usados com as Comboboxes
                    NomeSocial = novoClienteDados.NomeSocial,
                    Etinia = (Etinia)ComboBoxEtinia.SelectedIndex,
                    Estrangeiro = Novo_Estrangeiro,
                    TipoCliente = tipoClienteSelecionado
                });
                label1.Text = "Cliente cadastrado com sucesso!";
                BindingSource.ResetBindings(false);
                return;


            }

           
        }
    }
}