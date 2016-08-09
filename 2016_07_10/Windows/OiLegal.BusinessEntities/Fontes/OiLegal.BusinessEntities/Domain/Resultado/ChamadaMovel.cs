#region Using

using System;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado
{
    
    /// <summary>
    /// Classe que representa uma chamada de categoria móvel.
    /// </summary>
    [Serializable]
    public class ChamadaMovel : Chamada
    {

        #region Propriedades

        public ERB.ERB ERB { get; set; }

        public TipoSentido Sentido { get; set; }

        public byte IndVC { get; set; }

        public byte EfficiencyInd { get; set; }

        public string Rota { get; set; }

        public string IMEI { get; set; }

        public string IMSI { get; set; }

        public string Gtt { get; set; }
        
        public string Celula { get; set; }

        public string CGI { get; set; }

        public bool CKB
        {
            get { return true; }
            set { _ckb = value; }
        }
        private bool _ckb;

        public string Lac { get; set; }
        
        public string RotaEntrada { get; set; }
        public string RotaSaida { get; set; }
        
        public string IdenChamada { get; set; }

        public string Flag_9digito_a { get; set; }

        public string Flag_9digito_b { get; set; }

        public byte TipoCdr { get; set; }

        #region OCS

        public string NumATon { get; set; }

        public string IndPre { get; set; }

        public string IndRoam { get; set; }

        public string IndFree { get; set; }

        public string CauseTerm { get; set; }

        public string NumBTon { get; set; }

        public string Central { get; set; }

        public string Parceiro { get; set; }
        
        public string TipoDeUso { get; set; }

        public string EOTA { get; set; }

        public string CNLA { get; set; }

        public string FlagAPortado { get; set; }

        public string EOTB { get; set; }

        public string CNLB { get; set; }

        public string FlagBPortado { get; set; }

        public string APNCode { get; set; }

        public string MCC { get; set; }

        public string MNC { get; set; }

        public string APN { get; set; }

        public string Volume { get; set; }

        public string TipoAcesso { get; set; }

        #endregion

        #endregion


        #region Metodos
        public bool ValidarEotMovel()
        {
            bool result = false;
            if (Sentido == AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.TipoSentido.Recebida)
            {
                if (string.IsNullOrEmpty(EOTA) || Convert.ToInt32(EOTA) == 0 || ListaEot().Contains(EOTA))
                {
                    result = true;
                    PertenceBrt = ListaEotBRTFixa().Contains(EOTA);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(EOTB) || Convert.ToInt32(EOTB) == 0 || ListaEot().Contains(EOTB))
                {
                    result = true;
                    PertenceBrt = ListaEotBRTFixa().Contains(EOTB);
                }
            }
            return result;
        }

        public bool ValidarEotBRTFixa()
        {
            if (Sentido == AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.TipoSentido.Recebida)
            {
                if (string.IsNullOrEmpty(EOTA) || Convert.ToInt32(EOTA) == 0 || ListaEot().Contains(EOTA))
                {
                    return ListaEotBRTFixa().Contains(EOTA);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(EOTB) || Convert.ToInt32(EOTB) == 0 || ListaEot().Contains(EOTB))
                {
                    return PertenceBrt = ListaEotBRTFixa().Contains(EOTB);
                }
            }

            return false;

        }
        #endregion

    }

}

