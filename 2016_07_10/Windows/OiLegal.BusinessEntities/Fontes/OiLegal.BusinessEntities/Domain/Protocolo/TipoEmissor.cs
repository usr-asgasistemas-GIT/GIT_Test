#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class TipoEmissor : IEnumerableClass
    {

        #region Atributos

        private int _id;
        private string _sigla;
        private string _descricao;

        #endregion

        #region Propriedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Sigla
        {
            get { return _sigla; }
            set { _sigla = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        #region IEnumerableClass Members

        public string Text
        {
            get { return _sigla; }
            set { _sigla = value; }
        }

        public string Key
        {
            get { return _id.ToString(); }
            set { _id = Int32.Parse(value); }
        }

        #endregion
        
        #endregion

        #region Construtor

        public TipoEmissor() { }

        public TipoEmissor(int pId, string pSigla, string pDescricao)
        {
            _id = pId;
            _sigla = pSigla;
            _descricao = pDescricao;
        }
        public TipoEmissor(string pSigla, string pDescricao)
        {
            _sigla = pSigla;
            _descricao = pDescricao;
        }

        public TipoEmissor(int pID, string pSigla)
        {
            _id = pID;
            _sigla = pSigla;
        }

        #endregion

    }
}