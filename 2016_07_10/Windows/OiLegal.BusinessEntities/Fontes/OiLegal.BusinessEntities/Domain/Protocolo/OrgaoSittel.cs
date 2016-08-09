#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class OrgaoSittel : IEnumerableClass
    {
        
        #region Atributos

        private int _id;
        private string _tipoOrgao;
        private string _nomeOrgao;
        private string _uf;
        private string _cidade;
        private string _ars;        
        private bool _ativo;
        private DateTime _dataCadastro;
        
        #endregion

        #region Propriedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string TipoOrgao
        {
            get { return _tipoOrgao; }
            set { _tipoOrgao = value; }
        }
        
        public string NomeOrgao
        {
            get { return _nomeOrgao; }
            set { _nomeOrgao = value; }
        }

        public string Uf
        {
            get { return _uf; }
            set { _uf = value; }
        }

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public string Ars
        {
            get { return _ars; }
            set { _ars = value; }
        }

        public bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

        public DateTime DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = value; }
        }        

        #region IEnumerableClass Members

        public string Text
        {
            get { return _nomeOrgao; }
            set { _nomeOrgao = value; }
        }

        public string Key
        {
            get { return _id.ToString(); }
            set { _id = Int32.Parse(value); }
        }

        #endregion

        #endregion

        #region Construtor

        public OrgaoSittel() { }

        public OrgaoSittel(int pID, string pTipoOrgao, string pNomeOrgao, string pUf, string pCidade)
        {
            _id = pID;
            _tipoOrgao = pTipoOrgao;
            _nomeOrgao = pNomeOrgao;
            _uf = pUf;
            _cidade = pCidade;
        }

        public OrgaoSittel(int pID, string pTipoOrgao, string pNomeOrgao, string pUf, string pCidade, bool pAtivo)
        {
            _id = pID;
            _tipoOrgao = pTipoOrgao;
            _nomeOrgao = pNomeOrgao;
            _uf = pUf;
            _cidade = pCidade;
            _ativo = pAtivo;

        }

        #endregion
    }
}
