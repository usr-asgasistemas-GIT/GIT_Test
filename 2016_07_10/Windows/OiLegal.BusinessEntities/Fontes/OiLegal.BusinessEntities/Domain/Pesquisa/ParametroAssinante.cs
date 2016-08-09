using System;
using System.Collections.Generic;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class ParametroAssinante : IEqualityComparer<ParametroAssinante>
    {
        public string IdSolicitacao { get; set; }
        public int ItemSolicitacao { get; set; }
        public int CodigoSelecaoFixa { get; set; }
        public string DDD { get; set; }
        public string NumeroTerminal { get; set; }
        public string NumeroTerminalSimples { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
        public int CodigoSelecaoMovel { get; set; }
        public string Tipo { get; set; }
        public int NumeroPesquisa { get; set; }
        public int NumeroParametro { get; set; }
        public int IdConsulta { get; set; }
        public EnumTipoBusca TipoBusca { get; set; }

        public string Cnl_a { get; set; }
        public string Cnl_b { get; set; }

        //colocando a pesquisa nesta entidade por conveniência 
        public Pesquisa PesquisaAtiva { get; set; }

        public int linhaCDR { get; set; }

        //By Michel Medeiros
        //WebService assinante
        public string Uf { get; set; }

        public bool PertenceBrt { get; set; }

        #region Membros de IEqualityComparer<ParametroAssinante>

        public bool Equals(ParametroAssinante x, ParametroAssinante y)
        {
            if (x == null || y == null)
            {
                return false;
            }

            return x.NumeroTerminal.Equals(y.NumeroTerminal);
        }

        public int GetHashCode(ParametroAssinante obj)
        {
            return obj.NumeroTerminal.GetHashCode();
        }

        #endregion
    }
}