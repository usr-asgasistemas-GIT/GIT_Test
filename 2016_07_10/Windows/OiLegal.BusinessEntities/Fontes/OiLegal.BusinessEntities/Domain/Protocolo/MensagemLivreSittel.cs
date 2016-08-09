#region Using

using System;
using System.Text;
using System.Collections.Generic;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class MensagemLivreSittel
    {
        #region Atributos

        private int _prazoDias;
        private List<string> _lstEmails;

        #endregion

        #region Propriedades

        public int PrazoDias
        {
            get { return _prazoDias; }
            set { _prazoDias = value; }
        }

        public List<string> LstEmails
        {
            get { return _lstEmails; }
            set { _lstEmails = value; }
        }

        #endregion

        #region Construtor

        public MensagemLivreSittel() { }

        public MensagemLivreSittel(int pPrazoDias, List<string> pLstEmails)
        {
            _prazoDias = pPrazoDias;
            _lstEmails = pLstEmails;            
        }

        

        #endregion

    }
}
