#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class TipoDocumento : IEnumerableClass
    {

        #region Atributos

        private int _id;
        private string _descricao;

        #endregion

        #region Propriedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        #region IEnumerableClass Members

        public string Key
        {
            get { return _id.ToString(); }
            set { _id = Int32.Parse(value); }
        }

        public string Text
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        #endregion

        #endregion

        
        #region Construtores

        public TipoDocumento() { }

        public TipoDocumento(int pId, string pDescricao)
        {
            _id = pId;
            _descricao = pDescricao;
            
        }

        public TipoDocumento(string pDescricao)
        {
            _descricao = pDescricao;
            
        }

        #endregion

    }
}