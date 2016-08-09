using System;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class ParametroCamposCDRRetornados : ParametroAuxiliar
    {
        #region Atributos

        private String _campoCDR;
        private int _idCampoCDR;
        private int _posicao;

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

        public int IdCampoCDR
        {
            get
            {
                return _idCampoCDR;
            }
            set
            {
                _idCampoCDR = value;
            }
        }

        public int Posicao
        {
            get
            {
                return _posicao;
            }
            set
            {
                _posicao = value;
            }
        }

        #endregion
    }
}

