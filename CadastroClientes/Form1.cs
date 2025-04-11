using CadastroClientes.NovosDados;
using CadastroClientes.Dominio;
using CadastroDeClientes.repositorio;
namespace CadastroClientes
{
    public partial class Form1 : Form
    {
        private readonly Cliente clientes = new();

        private readonly List<Cliente> Clientes = [];
        private readonly BindingSource BindingSource = [];

        public Form1()
        {
            InitializeComponent();
        }

        //public NovoClienteDados Novos_Dados() // metodo para pegar os dados do novo cliente
        //{
        //    return new NovoClienteDados
        //    {
        //        Nome = TextBoxNome.Text,
        //        DataDeNascimento = TextBoxData.Text,
        //        Telefone = TextBoxTelefone.Text,
        //        Email = TextBoxEmail.Text,
        //        NomeSocial = TextBoxNomeSocial.Text
        //    };
        //}

        public bool Verificador_NovoCliente() // metodo para verificar se os campos do novo cliente estão preenchidos corretamente
        {
            //nome
            string Novo_Nome = TextBoxNome.Text;
            if (string.IsNullOrWhiteSpace(Novo_Nome))
            {
                label1.Text = "Nome não pode estar vazio";
                return false;
            }
            if (!Novo_Nome.Contains(" "))
            {
                label1.Text = "Digite o Nome Completo";
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
                label1.Text = "Data não pode estar vazia";
                return false;
            }
            if (Novo_DataDeNascimento.Contains(" "))
            {
                label1.Text = "Data não pode estar vazia";
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
                label1.Text = "Telefone não pode estar vazio";
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
                label1.Text = "Email não pode estar vazio";
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
                label1.Text = "Nome Social não pode conter numeros";
                return false;
            }
            if (Novo_Nome.Any(char.IsPunctuation))
            {
                label1.Text = "Nome Social não pode conter simbolos";
                return false;
            }

            //etnia
            string Nova_Etnia = ComboBoxEtnia.Text;
            if (string.IsNullOrWhiteSpace(Nova_Etnia))
            {
                label1.Text = "Selecione sua Etnia";
                return false;
            }



            return true;
        }


        public bool Verificador_NovoEndereco() // metodo para verificar se os campos do novo endereco estão preenchidos corretamente
        {


            //logradouro
            string Novo_Logradouro = TextBoxLogradouro.Text;
            if (Novo_Logradouro.Any(char.IsNumber))
            {
                label1.Text = "Logradouro não pode conter numeros";
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

        //private void LimparForm()
        //{
        //    textBoxNome.Clear();
        //    textBoxNomeSocial.Clear();
        //    maskedTextBoxDataNascimento.Clear();
        //    textBoxEmail.Clear();
        //    maskedTextBoxTelefone.Clear();
        //    comboBoxEtnia.SelectedIndex = -1;
        //    radioButtonPf.Checked = false;
        //    radioButtonPj.Checked = false;

        //    textBoxLogradouro.Clear();
        //    textBoxNumero.Clear();
        //    textBoxBairro.Clear();
        //    maskedTextBoxCEP.Clear();
        //}

        //private void FormListaClientes_Load(object sender, EventArgs e)
        //{
        //    label1.Text = "";

        //    Enum.GetNames(typeof(Etnia)).ToList().ForEach(etnia => ComboBoxEtnia.Items.Add(etnia));

        //    BindingSource.DataSource = Cliente.ListarClientes();
        //    dataGridViewClientes.DataSource = BindingSource;
        //}


        //public bool Buscador()
        //{
        //    string Novo_Nome = TextBoxNome.Text;
        //    string Novo_DataDeNascimento = TextBoxData.Text;
        //    string Novo_Telefone = TextBoxTelefone.Text;
        //    string Novo_Email = TextBoxEmail.Text;
        //    string Novo_Genero = ComboBoxGenero.Text;

        //    bool encontrado = false;

        //    for (int i = 0; i < clientes.Count; i++)
        //    {
        //        if (clientes[i].Email == Novo_Email)
        //        {
        //            encontrado = true;
        //            label1.Text = "Cliente (Email) já cadastrado!";
        //            break;
        //        }
        //        if (clientes[i].Telefone == Novo_Telefone)
        //        {
        //            encontrado = true;
        //            label1.Text = "Cliente (Telefone) já cadastrado!";
        //            break;
        //        }
        //        if (clientes[i].Id == 125)
        //        {
        //            encontrado = true;
        //            label1.Text = "Cliente (ID) já cadastrado!";
        //            break;
        //        }
        //    }
        //    return encontrado;

        //} // metodo para verificar se o cliente já está cadastrado

        //private int GerarNovoId() // metodo para gerar um novo ID para o cliente
        //{
        //    return clientes.Max(cliente => cliente.Id) + 1;
        //}

        //public Form1()
        //{

        //    InitializeComponent();

        //    Endereco endereco1 = new Endereco();

        //    Endereco endereco2 = new Endereco();

        //    Endereco endereco3 = new Endereco();


        //    //clientes.Add(new Cliente()
        //    //{
        //    //    Id = 10,
        //    //    Nome = "Wesley",
        //    //    DataDeNascimento = "12/12/12",
        //    //    Telefone = "40028922",
        //    //    Email = "Wesley@Gmail.com",
        //    //    Endereco = endereco1,
        //    //    Genero = Genero.Masculino,
        //    //    NomeSocial = "gathusco",
        //    //    Etnia = Etnia.Branco,
        //    //    Estrangeiro = false,
        //    //    TipoCliente = TipoCliente.PessoaFisica
        //    //}); //posso adiconar um item a lista desse modo.

        //    //Cliente Julia = new Cliente()
        //    //{
        //    //    Id = 11,
        //    //    Nome = "Julia",
        //    //    DataDeNascimento = "10/10/10",
        //    //    Telefone = "40028922",
        //    //    Email = "julia@Gmail.com",
        //    //    Endereco = endereco2,
        //    //    Genero = Genero.Feminino,
        //    //    NomeSocial = "capivara",
        //    //    Etnia = Etnia.Branco,
        //    //    Estrangeiro = false,
        //    //    TipoCliente = TipoCliente.PessoaFisica
        //    //}; //posso adicionar um item a lista desse modo. a diferenÃ§a deles Ã© que o primeiro Ã© um objeto anonimo e o segundo Ã© um objeto nomeado.
        //    //clientes.Add(Julia);

        //    //Cliente Daniel = new Cliente()
        //    //{
        //    //    Id = 12,
        //    //    Nome = "Daniel",
        //    //    DataDeNascimento = "11/11/11",
        //    //    Telefone = "40028922",
        //    //    Email = "daniel@Gmail.com",
        //    //    Endereco = endereco3,
        //    //    Genero = Genero.Masculino,
        //    //    NomeSocial = "chorrosco",
        //    //    Etnia = Etnia.Branco,
        //    //    Estrangeiro = false,
        //    //    TipoCliente = TipoCliente.PessoaFisica
        //    //};
        //    //clientes.Add(Daniel);

        //    BindingSource.DataSource = clientes;
        //    dataGridViewClientes.DataSource = BindingSource;

        //}

        private void Botao_Cadastrar_Click(object sender, EventArgs e) 
        {
            DateTime.TryParse(TextBoxData.Text, out DateTime dataNascimento);
            
            Endereco novoEndereco = new()
            {
                Logradouro = TextBoxLogradouro.Text,
                Numero = TextBoxNumero.Text,
                Bairro = TextBoxBairro.Text,
                Cep = TextBoxCEP.Text.Replace("-", ""),
                Municipio = TextBoxMunicipio.Text,
                Estado = ComboBoxEstado.Text,
                Complemento = TextBoxComplemento.Text,
            };

            Cliente novoCliente = new()
            {
                Nome = TextBoxNome.Text,
                NomeSocial = TextBoxNomeSocial.Text,
                DataDeNascimento = dataNascimento,
                Email = TextBoxEmail.Text,
                Telefone = TextBoxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""),
                Etnia = (Etnia)ComboBoxEtnia.SelectedIndex,
                Genero = (Genero)ComboBoxGenero.SelectedIndex,
                TipoCliente = RadioButtonPessoaFisica.Checked ? TipoCliente.PessoaFisica : TipoCliente.PessoaJuridica,
                Estrangeiro = CheckBoxEstrangeiroSim.Checked,
                Endereco = novoEndereco
            };

            novoCliente.InserirCliente(novoCliente);
            BindingSource.DataSource = clientes.ListarClientes();
            dataGridViewClientes.DataSource = BindingSource;

           // LimparForm();

        }
        //{

        //    string Novo_Nome = TextBoxNome.Text;
        //    string Novo_DataDeNascimento = TextBoxData.Text;
        //    string Novo_Telefone = TextBoxTelefone.Text;
        //    string Novo_Email = TextBoxEmail.Text;
        //    string Novo_NomeSocial = TextBoxNomeSocial.Text;
        //    bool Novo_Estrangeiro = CheckBoxEstrangeiroSim.Checked;


        //    NovoClienteDados novoClienteDados = Novos_Dados();

        //    int novoId = GerarNovoId();

        //    if (!Verificador_NovoEndereco())
        //    {
        //        return;
        //    }

        //    Endereco endereco_Novo = new Endereco()
        //    {
        //        Logradouro = TextBoxLogradouro.Text,
        //        Numero = TextBoxNumero.Text,
        //        Complemento = TextBoxComplemento.Text,
        //        Bairro = TextBoxBairro.Text,
        //        Municipio = TextBoxMunicipio.Text,
        //        Estado = ComboBoxEstado.Text,
        //        Cep = TextBoxCEP.Text

        //    };


        //    if (!Verificador_NovoCliente())
        //    {
        //        return;
        //    }

        //    //if (!Buscador())
        //    //{
        //    //    int tipoClienteIndex = RadioButtonPessoaFisica.Checked ? 0 : 1;
        //    //    TipoCliente tipoClienteSelecionado = (TipoCliente)tipoClienteIndex;

        //    clientes.Add(new Cliente()
        //    {
        //        Id = novoId,
        //        Nome = novoClienteDados.Nome,
        //        DataDeNascimento = novoClienteDados.DataDeNascimento,
        //        Telefone = novoClienteDados.Telefone,
        //        Email = novoClienteDados.Email,
        //        Endereco = endereco_Novo,
        //        Genero = (Genero)ComboBoxGenero.SelectedIndex, //é assim que ENUMs funcionam e são usados com as Comboboxes
        //        NomeSocial = novoClienteDados.NomeSocial,
        //        Etnia = (Etnia)ComboBoxEtnia.SelectedIndex,
        //        Estrangeiro = Novo_Estrangeiro,
        //        TipoCliente = tipoClienteSelecionado
        //    });
        //    label1.Text = "Cliente cadastrado com sucesso!";



        //    BindingSource.ResetBindings(false);
        //    return;


        //    //}


        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "flsdljfjlsdfjklsdjf";

            Enum.GetNames(typeof(Etnia)).ToList().ForEach(etnia => ComboBoxEtnia.Items.Add(etnia));

            BindingSource.DataSource = clientes.ListarClientes();
            dataGridViewClientes.DataSource = BindingSource;
        }



    }
}