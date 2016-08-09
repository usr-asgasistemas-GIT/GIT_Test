using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class ParametroBasePesquisa : ParametroAuxiliar
    {
        #region Atributos

        private String _basePesquisa;
        private int _codBasePesquisa;

        #endregion

        #region Propriedades

        public String BasePesquisa
        {
            get
            {
                return _basePesquisa;
            }
            set
            {
                _basePesquisa = value;
            }
        }

        public int CodBasePesquisa
        {
            get
            {
                return _codBasePesquisa;
            }
            set
            {
                _codBasePesquisa = value;
            }
        }

        #endregion
    }
}
