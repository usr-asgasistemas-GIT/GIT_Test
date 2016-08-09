using System;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa.Wll
{
    [Serializable]
    public class RequestCadastralCrmFixa
    {
        public string NumeroTerminal { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public RequestCadastralCrmFixa(string numeroTerminal,DateTime dataInicial, DateTime dataFinal)
        {
            NumeroTerminal = numeroTerminal;
            DataInicial = dataInicial;
            DataFinal = dataFinal;
        }
    }
}
