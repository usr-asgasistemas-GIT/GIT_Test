#region Using

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class ParametroAuxiliar : Parametro
    {
        #region Atributos
        private int _idPesquisaProtocolo;
        private int _numeroPesquisa;
        #endregion

        #region Propriedades

        public int IDPesquisaProtocolo
        {
            get { return _idPesquisaProtocolo; }
            set { _idPesquisaProtocolo = value; }
        }

        #endregion
    }
}