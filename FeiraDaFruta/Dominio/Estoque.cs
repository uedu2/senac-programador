using FeiraDaFruta.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiraDaFruta.Dominio
{
    internal class Estoque
    {
        public int id { get; set; }
        public int quantidade { get; set; }
        public int id_produto { get; set; }
        public DateTime dataestoque { get; set; }
        private readonly ListaDeProdutosRepositorio repositorio = new ListaDeProdutosRepositorio();

        public bool CompraProdutos()
        {
            repositorio.CompraProdutos(quantidade,id_produto,dataestoque);
            return true;
        }
        public bool VendaProdutos() 
        {
            repositorio.VendaProdutos(quantidade, id_produto, dataestoque);
            return true;
        }
    }
}
