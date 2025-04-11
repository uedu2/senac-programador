using CadastroDeClientes.repositorio;

namespace CadastroClientes.Dominio
{
    public class Cliente
    {
        private readonly ClienteRepositorio clienteRepositorio = new();

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public Genero Genero { get; set; }
        public string NomeSocial { get; set; }
        public Etnia Etnia { get; set; }
        public bool Estrangeiro { get; set; }
        public TipoCliente TipoCliente { get; set; }

        public List<Cliente> ListarClientes()
        {
            return clienteRepositorio.ListarClientes();
        }

        public void InserirCliente(Cliente novoCliente)
        {
            clienteRepositorio.InserirCliente(novoCliente); //CadastroDeClientes
        }

    }

}
