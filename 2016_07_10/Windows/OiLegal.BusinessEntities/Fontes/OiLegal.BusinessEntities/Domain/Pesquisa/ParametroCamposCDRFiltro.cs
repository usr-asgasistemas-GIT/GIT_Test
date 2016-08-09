using System;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class ParametroCamposCDRFiltro : ParametroAuxiliar
    {
        #region Atributos

        private String _campoCDR;
        private String _valorCDR;
        private int _codCampoCDR;

        #endregion

        #region Propriedades

        public String CampoCDR
        {
            get
            {
                return _campoCDR;
            }
            set
            {
                _campoCDR = value;
            }
        }
        public String ValorCDR
        {
            get
            {
                return _valorCDR;
            }
            set
            {
                _valorCDR = value;
            }
        }

        public int CodCampoCDR
        {
            get
            {
                return _codCampoCDR;
            }
            set
            {
                _codCampoCDR = value;
            }
        }

        #endregion
    }
}

