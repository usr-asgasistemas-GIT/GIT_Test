#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class ConfiguracoesSittel
    {
        

        #region Atributos

        private int _prazoMeses;
        private int _autoRejeicao;
        

        #endregion

        #region Propriedades

        public int PrazoMeses
        {
            get { return _prazoMeses; }
            set { _prazoMeses = value; }
        }

        public int AutoRejeicao
        {
            get { return _autoRejeicao; }
            set { _autoRejeicao = value; }
        }
               
        
        #endregion

        #region Construtor

        public ConfiguracoesSittel() { }

        public ConfiguracoesSittel(int pPrazoMeses, int pAutoRejeicao)
        {
            _prazoMeses = pPrazoMeses;
            _autoRejeicao = pAutoRejeicao;            
        }

        

        #endregion

    }
}
