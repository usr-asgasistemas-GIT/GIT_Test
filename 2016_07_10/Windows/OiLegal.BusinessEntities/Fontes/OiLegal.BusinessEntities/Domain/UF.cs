#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain
{
    [Serializable]
    public class UF : IEnumerableClass
    {

        #region Atributos

        private string _codUf;
        private string _descricao;
        
        #endregion

        #region Propriedades

        public string CodUf
        {
            get { return _codUf; }
            set { _codUf = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        #region IEnumerableClass Members

        public string Key
        {
            get { return _codUf; }
            set { _codUf = value; }
        }

        public string Text
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        #endregion

        #endregion

        #region Construtor

        public UF() { }

        public UF(string pCodUf, string pDescricao)
        {
            _codUf = pCodUf;
            _descricao = pDescricao;
        }

        #endregion

    }
}