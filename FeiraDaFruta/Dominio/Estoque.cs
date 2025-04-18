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
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int Id_produto { get; set; }
        public DateTime Dataestoque { get; set; }
        private readonly ListaDeProdutosRepositorio repositorio = new ListaDeProdutosRepositorio();

        public bool CompraProdutos()
        {
            repositorio.CompraProdutos(Quantidade, Id_produto, Dataestoque);
            return true;
        }
        public bool VendaProdutos() 
        {
            repositorio.VendaProdutos(Quantidade, Id_produto, Dataestoque);
            return true;
        }
    }
}
