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
        public string nome { get; set; }
        public DateTime dataproduto { get; set; }
        private readonly ListaDeProdutosRepositorio repositorio = new ListaDeProdutosRepositorio();



        public bool RemocaoProdutos() 
        { 
            repositorio.RemocaoProdutos(nome);
            return true;
        }

        public bool Criar()
        {
            if (string.IsNullOrEmpty(nome))
            {
                return false;
            }
            if (dataproduto == DateTime.MinValue)
            {
                return false;
            } 

            repositorio.Criar(nome,dataproduto);
            return true;
        }
  
    
    
    
    
    
    
    
    
    }

}
