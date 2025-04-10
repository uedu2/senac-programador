using BancoDeDados.Banco;
using MySql.Data.MySqlClient;
using System.Data;
using CadastroClientes.Dominio;

namespace CadastroDeClientes.repositorio
{
    internal class ClienteRepositorio
    {
        public List<Cliente> ListarClientes
        {
            get
            {
                var clientes = new List<Cliente>();

                using (var conn = BancoDeDados.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT c.*, e.logradouro, e.numero, e.complemento, e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco = e.id;";

                    using var cmd = new MySqlCommand(query, conn);
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var nomeSocial = !reader.IsDBNull("nome_social") ? reader.GetString("nome_social") : "";
                        var complemento = !reader.IsDBNull("complemento") ? reader.GetString("complemento") : "";


                        clientes.Add(new Cliente
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            NomeSocial = nomeSocial,
                            DataDeNascimento = reader.GetDateTime("data_nascimento"),
                            Email = reader.GetString("email"),
                            Telefone = reader.GetString("telefone"),
                            TipoCliente = (TipoCliente)reader.GetInt32("tipo"),
                            Etnia = (Etnia)reader.GetInt32("etnia"),
                            Genero = (Genero)reader.GetInt32("genero"),
                            Estrangeiro = reader.GetBoolean("estrangeiro"),
                            Endereco = new Endereco
                            {
                                Id = reader.GetInt32("id_endereco"),
                                Logradouro = reader.GetString("logradouro"),
                                Numero = reader.GetString("numero"),
                                Complemento = complemento,
                                Bairro = reader.GetString("bairro"),
                                Municipio = reader.GetString("municipio"),
                                Estado = reader.GetString("estado"),
                                Cep = reader.GetString("cep")
                            }
                        });
                    }
                }

                return clientes;
            }
        }
    }
}