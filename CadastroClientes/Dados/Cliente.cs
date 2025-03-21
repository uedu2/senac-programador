using CadastroClientes.Dados;

namespace CadastroClientes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataDeNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
       public Endereco Endereco { get; set; }
       public Genero Genero { get; set; }
        public string NomeSocial { get; set; }
       public Etnia Etnia { get; set; }
        public bool Estrangeiro { get; set; }
       public TipoCliente TipoCliente { get; set; }
       
    }

}
