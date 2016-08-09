#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class Comarca : IEnumerableClass
    {
        #region Atributos

        private int _id;
        private string _sigla;
        private string _descricao;
        private string _logradouro;
        private string _bairro;
        private string _cidade;
        private string _uf;
        private string _cep;
        private string _numero;
        
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

        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public string Uf
        {
            get { return _uf; }
            set { _uf = value; }
        }

        public string Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }  

        #region IEnumerableClass Members

        public string Text
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public string Key
        {
            get { return _id.ToString(); }
            set { _id = Int32.Parse(value); }
        }

        #endregion

        #endregion

        #region Construtor

        public Comarca() { }

        public Comarca(int pID, string pSigla, string pDescricao)
        {
            _id = pID;
            _sigla = pSigla;
            _descricao = pDescricao;
        }

        public Comarca(string pSigla, string pDescricao)
        {
            _sigla = pSigla;
            _descricao = pDescricao;
        }

        #endregion

    }
}