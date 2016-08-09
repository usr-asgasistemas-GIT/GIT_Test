#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class NumeroSensivel
    {

        #region Atributos

        private string _numero;

        #endregion

        #region Propriedades

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        #endregion
       
    }
}