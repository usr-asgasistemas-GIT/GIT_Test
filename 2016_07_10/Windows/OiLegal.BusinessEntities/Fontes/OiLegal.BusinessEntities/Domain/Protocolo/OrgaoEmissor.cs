#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class OrgaoEmissor : IEnumerableClass
    {

        #region Atributos

        private int _id;
        private string _descricao;
        private TipoOrgaoEmissor _tipoOrgaoEmissor;

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
            
        public TipoOrgaoEmissor TipoOrgaoEmissor
        {
            get { return _tipoOrgaoEmissor; }
            set { _tipoOrgaoEmissor = value; }
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

        public OrgaoEmissor() { }

        public OrgaoEmissor(int pId, string pDescricao, TipoOrgaoEmissor pTipoOrgaoEmissor)
        {
            _id = pId;
            _descricao = pDescricao;
            _tipoOrgaoEmissor = pTipoOrgaoEmissor;
        }

        public OrgaoEmissor(string pDescricao, TipoOrgaoEmissor pTipoOrgaoEmissor)
        {
            _descricao = pDescricao;
            _tipoOrgaoEmissor = pTipoOrgaoEmissor;
        }

        #endregion
        
    }
}