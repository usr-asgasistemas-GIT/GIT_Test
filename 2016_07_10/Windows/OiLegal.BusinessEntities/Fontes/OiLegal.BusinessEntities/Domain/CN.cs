using System;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain
{
    [Serializable]
    public class CN
    {

        #region Atributos

        private string _cn;
        private DateTime _data;

        #endregion

        #region Propriedades

        public string Cn
        {
            get { return _cn; }
            set { _cn = value; }
        }

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public string Digito { get; set; }

        #endregion

        #region Construtor

        public CN() { }

        #endregion

    }
}