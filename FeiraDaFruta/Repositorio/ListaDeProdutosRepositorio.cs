using FeiraDaFruta.Banco_de_Dados;
using FeiraDaFruta.Dominio;
using MySql.Data.MySqlClient;


namespace FeiraDaFruta.Repositorio
{
    internal class ListaDeProdutosRepositorio
    {
        public void Criar(string nome, DateTime dataproduto)
        {
            using (var con = DataBase.GetConnection())
            {

                con.Open();

                string query = "INSERT INTO produtos (nome, dataproduto) VALUES (@nome, @dataproduto)";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@dataproduto", dataproduto);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void RemocaoProdutos(string nome) 
        {
            using (var con = DataBase.GetConnection()) 
            {
                con.Open();
                string query = "DELETE FROM produtos WHERE nome = @nome;";

                using (var cmd = new MySqlCommand(query, con)) 
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.ExecuteNonQuery();
                }
            }
        
        }

        public void CompraProdutos(int quantidade, int id_produto, DateTime dataestoque)
        {
            using (var con = DataBase.GetConnection())
            {

                con.Open();

                string query = "INSERT INTO estoque (quantidade, id_produto, dataestoque) VALUES (@quantidade, @id_produto, @dataestoque)";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@id_produto", id_produto);
                    cmd.Parameters.AddWithValue("@dataestoque", dataestoque);
                    cmd.ExecuteNonQuery();
                }
            }
        }
       

            public List<Produto> ListarProdutos()
            {
                List<Produto> produtos = [];
                using (var conn = DataBase.GetConnection())
                {
                    conn.Open();

                    string query = $"SELECT * FROM produto; ";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                produtos.Add(new Produto()
                                {
                                    Id = reader.GetInt32("id"),
                                    Nome = reader.GetString("nome"),
                                    Dataproduto = reader.GetDateTime("data")
                                });
                            }

                        }
                    }
                }

                return produtos;
            }



        

    }
}
