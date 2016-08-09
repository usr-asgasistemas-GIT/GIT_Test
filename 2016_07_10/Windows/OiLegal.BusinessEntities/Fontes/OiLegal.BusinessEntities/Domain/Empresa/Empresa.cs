#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Empresa
{
    [Serializable]
    public class Empresa : IEnumerableClass
    { 
        #region Atributos

        private int _id;
        private string _descricao;
        private string _razaoSocial;
        private string _cnpj;

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

        public string RazaoSocial
        {
            get { return _razaoSocial; }
            set { _razaoSocial = value; }
        }

        public string Cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
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

          #region Construtor

        public Empresa() { }

        public Empresa(int pID, string pDescricao,  string pRazaoSocial, string pCnpj)
        {
            _id = pID;            
            _descricao = pDescricao;
            _razaoSocial = pRazaoSocial;
            _cnpj = pCnpj;
        }
        public Empresa(int pID, string pDescricao)
        {
            _id = pID;
            _descricao = pDescricao;
            
        } 

        #endregion
       
    }
}