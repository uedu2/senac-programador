using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeiraDaFruta.Banco_de_Dados;
using FeiraDaFruta.Repositorio;

namespace FeiraDaFruta.Dominio
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Dataproduto { get; set; }
        private readonly ListaDeProdutosRepositorio repositorio = new ListaDeProdutosRepositorio();



        public bool RemocaoProdutos() 
        { 
            repositorio.RemocaoProdutos(Nome);
            return true;
        }

        public bool Criar()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                return false;
            }
            if (Dataproduto == DateTime.MinValue)
            {
                return false;
            } 

            repositorio.Criar(Nome,Dataproduto);
            return true;
        }
        public List<Produto> ListarProdutos() 
        { 
            return repositorio.ListarProdutos();
        }

    }

}
