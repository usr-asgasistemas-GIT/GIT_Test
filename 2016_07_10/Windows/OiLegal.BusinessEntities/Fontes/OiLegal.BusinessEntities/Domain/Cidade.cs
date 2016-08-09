#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain
{
    [Serializable]
    public class Cidade : IEnumerableClass
    {

        #region Atributos

        private int _id;
        private string _nome;
        private UF _uf;

        #endregion
        
        #region Propriedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public UF Uf
        {
            get { return _uf; }
            set { _uf = value; }
        }

        #region IEnumerableClass Members

        public string Text
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Key
        {
            get { return _id.ToString(); }
            set { _id = Int32.Parse(value); }
        }

        #endregion

        #endregion
        
        #region Construtores

        public Cidade() { }

        public Cidade(int pId, string pNome, UF pUf)
        {
            _id = pId;
            _nome = pNome;
            _uf = pUf;
        }

        public Cidade(string pNome, UF pUf)
        {
            _nome = pNome;
            _uf = pUf;
        }

        #endregion

    }
}