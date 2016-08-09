using System;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Request;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class ControleIdSolicitacaoDa
    {

        public Int64 IdSolicitacao { get; set; }
        public int ItemSolicitacao { get; set; }
        public int NumeroPesquisa { get; set; }
        public int NumeroParametro { get; set; }
        public int IdConsulta { get; set; }
        public bool Retornou { get; set; }
        public string XmlRequest { get; set; }
        public EnumStatusRequest StatusRequest { get; set; }
        public int LinhaCDR { get; set; }

        public ControleIdSolicitacaoDa()
        {
            Retornou = false;
        }

    }
}