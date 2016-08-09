#region Using

using System;

#endregion;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class TipoRequisicao : IEnumerableClass
    {

        #region Atributos

        private bool _ativo;
        private int _id;
        private string _descricao;
        private bool _criarPesquisa;
        private bool _pesquisaAutomatica;        

        #endregion

        #region Propriedades

        public bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

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

        public bool CriarPesquisa
        {
            get { return _criarPesquisa; }
            set { _criarPesquisa = value; }
        }

        public bool PesquisaAutomatica
        {
            get { return _pesquisaAutomatica; }
            set { _pesquisaAutomatica = value; }
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

        #region Construtores

        public TipoRequisicao() { }

        public TipoRequisicao(int pId, string pDescricao)
        {
            _id = pId;
            _descricao = pDescricao;
            
        }

        public TipoRequisicao(string pDescricao)
        {
            _descricao = pDescricao;
            
        }

        public TipoRequisicao(int pId, string pDescricao, bool pCriarPesquisa, bool pPesquisaAutomatica)
        {
            _id = pId;
            _descricao = pDescricao;
            _criarPesquisa = pCriarPesquisa;
            _pesquisaAutomatica = pPesquisaAutomatica;            
        }

        public TipoRequisicao(string pDescricao, bool pCriarPesquisa, bool pPesquisaAutomatica)
        {            
            _descricao = pDescricao;
            _criarPesquisa = pCriarPesquisa;
            _pesquisaAutomatica = pPesquisaAutomatica;            
        }

        public TipoRequisicao(bool pAtivo, int pId, string pDescricao, bool pCriarPesquisa, bool pPesquisaAutomatica)
        {
            _ativo = pAtivo;
            _id = pId;
            _descricao = pDescricao;
            _criarPesquisa = pCriarPesquisa;
            _pesquisaAutomatica = pPesquisaAutomatica;            
        }

        public TipoRequisicao(bool pAtivo, string pDescricao, bool pCriarPesquisa, bool pPesquisaAutomatica)
        {
            _ativo = pAtivo;
            _descricao = pDescricao;
            _criarPesquisa = pCriarPesquisa;
            _pesquisaAutomatica = pPesquisaAutomatica;            
        }

        #endregion

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is TipoRequisicao)
            {
                TipoRequisicao cust = obj as TipoRequisicao;
                return cust.Id == this.Id;
            }
            return false;
        } 

    }
}