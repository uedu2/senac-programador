using CadastroClientes.Banco;
using MySql.Data.MySqlClient;
using System.Data;
using CadastroClientes.Dominio;

namespace CadastroDeClientes.repositorio
{
    internal class ClienteRepositorio
    {
        public List<Cliente> ListarClientes()
        {
            var clientes = new List<Cliente>();

            using (var conn = Database.GetConnection())
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
        public void InserirCliente(Cliente novoCliente)
        {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string queryEndereco = "INSERT INTO endereco (logradouro, numero, bairro, municipio, estado, cep, complemento) " +
                                                    "VALUES (@logradouro, @numero, @bairro, @municipio, @estado, @cep, @complemento);";
                            using (var cmd = new MySqlCommand(queryEndereco, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@logradouro", novoCliente.Endereco.Logradouro);
                                cmd.Parameters.AddWithValue("@numero", novoCliente.Endereco.Numero);
                                cmd.Parameters.AddWithValue("@bairro", novoCliente.Endereco.Bairro);
                                cmd.Parameters.AddWithValue("@municipio", novoCliente.Endereco.Municipio);
                                cmd.Parameters.AddWithValue("@estado", novoCliente.Endereco.Estado);
                                cmd.Parameters.AddWithValue("@cep", novoCliente.Endereco.Cep);
                                cmd.Parameters.AddWithValue("@complemento", novoCliente.Endereco.Complemento);
                                cmd.ExecuteNonQuery();
                            }

                            int idEndereco;
                            string queryIdEndereco = "SELECT LAST_INSERT_ID();";
                            using (var cmd = new MySqlCommand(queryIdEndereco, conn, transaction))
                            {
                                idEndereco = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            string query = "INSERT INTO cliente (nome, nome_social, data_nascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco) " +
                                                "VALUES (@nome, @nome_social, @data_nascimento, @email, @telefone, @tipo, @etnia, @genero, @estrangeiro, @id_endereco);";
                            using (var cmd = new MySqlCommand(query, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@nome", novoCliente.Nome);
                                cmd.Parameters.AddWithValue("@nome_social", novoCliente.NomeSocial);
                                cmd.Parameters.AddWithValue("@data_nascimento", novoCliente.DataDeNascimento);
                                cmd.Parameters.AddWithValue("@email", novoCliente.Email);
                                cmd.Parameters.AddWithValue("@telefone", novoCliente.Telefone);
                                cmd.Parameters.AddWithValue("@tipo", novoCliente.TipoCliente);
                                cmd.Parameters.AddWithValue("@etnia", novoCliente.Etnia);
                                cmd.Parameters.AddWithValue("@genero", novoCliente.Genero);
                                cmd.Parameters.AddWithValue("@estrangeiro", novoCliente.Estrangeiro);
                                cmd.Parameters.AddWithValue("@id_endereco", idEndereco);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
        }
    }









        //public List<Cliente> ListarClientes()
        //{
        //    get
        //    {
        //        var clientes = new List<Cliente>();

        //        using (var conn = Database.GetConnection())
        //        {
        //            conn.Open();

        //            string query = "SELECT c.*, e.logradouro, e.numero, e.complemento, e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco = e.id;";

        //            using var cmd = new MySqlCommand(query, conn);
        //            using var reader = cmd.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                var nomeSocial = !reader.IsDBNull("nome_social") ? reader.GetString("nome_social") : "";
        //                var complemento = !reader.IsDBNull("complemento") ? reader.GetString("complemento") : "";


        //                clientes.Add(new Cliente
        //                {
        //                    Id = reader.GetInt32("id"),
        //                    Nome = reader.GetString("nome"),
        //                    NomeSocial = nomeSocial,
        //                    DataDeNascimento = reader.GetDateTime("data_nascimento"),
        //                    Email = reader.GetString("email"),
        //                    Telefone = reader.GetString("telefone"),
        //                    TipoCliente = (TipoCliente)reader.GetInt32("tipo"),
        //                    Etnia = (Etnia)reader.GetInt32("etnia"),
        //                    Genero = (Genero)reader.GetInt32("genero"),
        //                    Estrangeiro = reader.GetBoolean("estrangeiro"),
        //                    Endereco = new Endereco
        //                    {
        //                        Id = reader.GetInt32("id_endereco"),
        //                        Logradouro = reader.GetString("logradouro"),
        //                        Numero = reader.GetString("numero"),
        //                        Complemento = complemento,
        //                        Bairro = reader.GetString("bairro"),
        //                        Municipio = reader.GetString("municipio"),
        //                        Estado = reader.GetString("estado"),
        //                        Cep = reader.GetString("cep")
        //                    }
        //                });
        //            }
        //        }

        //        return clientes;
        //    }
    //}
    //}
