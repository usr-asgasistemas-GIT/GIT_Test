using System;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa.Wll
{
    public class TerminalWll
    {
        public string NumeroTerminal { get; set; }
        public DateTime DataAtivacao { get; set; }
        public DateTime? DataDesativacao { get; set; }

        public TerminalWll(string numeroTerminal, DateTime dataAtivacao, DateTime? dataDesativacao)
        {
            NumeroTerminal = numeroTerminal;
            DataAtivacao = dataAtivacao;
            DataDesativacao = dataDesativacao;
        }
    }
}
