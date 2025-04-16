using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaAtividades.Repositorio;

namespace ListaAtividades.Dominio
{
    internal class Atividade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Situacao Situacao { get; set; } // 0 - Em Andamento, 1 - Concluida
        private readonly AtividadeRepositorio repositorio = new();
        public bool Criar() 
        {
            if (!ValidarTitulo()) 
            { 
                return false;
            }
            
            repositorio.Criar(Titulo);
            return true;
        }


        public bool AtualizarSituacao()
        {
            if (!ValidarId())
            {
                return false;
            }

            if (!ValidarSituacao())
            {
                return false;
            }
            Atividade atividadeEmAndamento = BuscarAtividadeEmAndamento();
            Situacao novaSituacao = BuscarProximaSituacao();

            if (atividadeEmAndamento.Id > 0 && atividadeEmAndamento.Situacao == novaSituacao)
            {
                return false;
            }

            repositorio.AtualizarSituacao(Id, (int) novaSituacao);
            return true;
        }
        public Atividade BuscarAtividadeEmAndamento()
        {
            return new Atividade();
        }
        public List<Atividade> ListarAtividadesPendentes()
        {
            return repositorio.ListarAtividadesPendentes();
        }
        private bool ValidarTitulo() 
        { 
            return string.IsNullOrWhiteSpace(Titulo);
        }
        private bool ValidarId()
        {
            return Id > 0;
        }
        private bool ValidarSituacao()
        {
            return Situacao != Situacao.Concluido;
        }

        private Situacao BuscarProximaSituacao() 
        {
            if (Situacao == Situacao.Pendente)
            {
                return Situacao.Realizando;
            }

            return Situacao.Concluido;
        }
    }
}
