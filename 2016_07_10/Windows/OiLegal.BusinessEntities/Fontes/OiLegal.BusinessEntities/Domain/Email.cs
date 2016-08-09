using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain
{
    [Serializable]
    public class Email : IEnumerableClass
    {

        #region Atributos

        private int _id;
        private string _email;
        private string _oficio;
        private string _protocolo;
        private string _unidade;
        private string _autoridade;
        private bool _ativo;
        private DateTime _datacadastro;

        #endregion

        #region Propriedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Endereco_Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Oficio
        {
            get { return _oficio; }
            set { _oficio = value; }
        }

        public string Protocolo
        {
            get { return _protocolo; }
            set { _protocolo = value; }
        }

        public string Unidade
        {
            get { return _unidade; }
            set { _unidade = value; }
        }

        public string Autoridade
        {
            get { return _autoridade; }
            set { _autoridade = value; }
        }

        public bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

        public DateTime DataCadastro
        {
            get { return _datacadastro; }
            set { _datacadastro = value; }
        }

        #region IEnumerableClass Members

        public string Text
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Key
        {
            get { return _id.ToString(); }
            set { _id = Int32.Parse(value); }
        }

        #endregion

        #endregion

        #region Construtores

        public Email() { }

        public Email(int pId, string pEmail, string pOficio, string pUnidade, string pAutoridade, bool pAtivo)
        {
            _id = pId;
            _email = pEmail;
            _oficio = pOficio;
            _unidade = pUnidade;
            _autoridade = pAutoridade;
            _ativo = pAtivo;
        }

        public Email(string pEmail)
        {
            _email = pEmail;

        }

        #endregion
    }
}
