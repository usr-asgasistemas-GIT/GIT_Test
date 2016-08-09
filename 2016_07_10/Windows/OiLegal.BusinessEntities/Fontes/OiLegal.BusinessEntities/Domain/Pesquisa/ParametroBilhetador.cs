using System;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class ParametroBilhetador : ParametroAuxiliar
    {
        #region Atributos

        private String _bilhetador;
        private String _ufBilhetador;

        #endregion

        #region Propriedades

        public String Bilhetador
        {
            get
            {
                return _bilhetador;
            }
            set
            {
                _bilhetador = value;
            }
        }

        public String UfBilhetador
        {
            get
            {
                return _ufBilhetador;
            }
            set
            {
                _ufBilhetador = value;
            }
        }

        #endregion
    }
}
