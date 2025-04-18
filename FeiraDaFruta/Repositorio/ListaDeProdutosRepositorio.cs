using FeiraDaFruta.Banco_de_Dados;
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

        public void VendaProdutos(int quantidade, int id_produto, DateTime data_estoque) 
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "insert into estoque (quantidade, id_produto, dataestoque) values (@quantidade,@id_produto,@data_estoque);";
                using (var cmd = new MySqlCommand(query, con)) 
                {
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@id_produto", id_produto);
                    cmd.Parameters.AddWithValue("@dataestoque",data_estoque);
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

       
    }
}
