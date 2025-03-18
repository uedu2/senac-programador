using CadastroClientes.Dados;

namespace CadastroClientes
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        


        public Form1()
        {
            InitializeComponent();
            
            Endereco endereco1 = new Endereco() { Logradouro = "Rua dos Bobos", Numero = "0", Complemento = 
             "Casa", Bairro = "Bairro do Limoeiro", Municipio = "Sei lá", Estado = "Gasoso", Cep = "00000-000" };
            
            Endereco endereco2 = new Endereco() { Logradouro = "Rua dos Bobos", Numero = "0", Complemento = 
             "Casa", Bairro = "Bairro do Limoeiro", Municipio = "Sei lá", Estado = "Gasoso", Cep = "00000-000" };
            
            Endereco endereco3 = new Endereco() { Logradouro = "Rua dos Bobos", Numero = "0", Complemento = 
             "Casa", Bairro = "Bairro do Limoeiro", Municipio = "Sei lá", Estado = "Gasoso", Cep = "00000-000" };

            
            clientes.Add(new Cliente() { Id = 123, Nome = "Wesley", DataDeNascimento = "12/12/12", Telefone = "40028922", Email = "Wesley@Gmail.com" , Endereco = endereco1,
             Genero = Genero.Masculino, NomeSocial = "gathusco", Etinia = Etinia.Branco, Estrangeiro = false, TipoCliente = TipoCliente.PessoaFisica });
            
            clientes.Add(new Cliente() { Id = 321, Nome = "Julia", DataDeNascimento = "10/10/10", Telefone = "40028922", Email = "julia@Gmail.com", Endereco = endereco2, 
             Genero = Genero.Feminino, NomeSocial = "capivara", Etinia = Etinia.Branco, Estrangeiro = false, TipoCliente = TipoCliente.PessoaFisica });
            
            clientes.Add(new Cliente() { Id = 213, Nome = "Daniel", DataDeNascimento = "11/11/11", Telefone = "40028922", Email = "daniel@Gmail.com", Endereco = endereco3, 
             Genero = Genero.Masculino,NomeSocial = "chorrosco", Etinia = Etinia.Branco, Estrangeiro = false,TipoCliente= TipoCliente.PessoaFisica });

        }

    }
}
