#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class Emissor : IEnumerableClass
    {

        #region Atributos

        private int _id;
        private TipoEmissor _tipoEmissor;
        private string _nomeEmissor;

        #endregion

        #region Propriedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public TipoEmissor TipoEmissor
        {
            get { return _tipoEmissor; }
            set { _tipoEmissor = value; }
        }

        public string NomeEmissor
        {
            get { return _nomeEmissor; }
            set { _nomeEmissor = value; }
        }

        #region IEnumerableClass Members

        public string Text
        {
            get { return _nomeEmissor; }
            set { _nomeEmissor = value; }
        }

        public string Key
        {
            get { return _id.ToString(); }
            set { _id = Int32.Parse(value); }
        }

        #endregion
        
        #endregion

        #region Construtor

        public Emissor() { }

        public Emissor(int pId, string pNomeEmissor, TipoEmissor pTipoEmissor)
        {
            _id = pId;
            _nomeEmissor = pNomeEmissor;
            _tipoEmissor = pTipoEmissor;
        }

        public Emissor(string pNomeEmissor, TipoEmissor pTipoEmissor)
        {
            _nomeEmissor = pNomeEmissor;
            _tipoEmissor = pTipoEmissor;
        }

        #endregion

    }
}