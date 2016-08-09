#region Using

using System;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Empresa;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Usuario.Grupo
{
    [Serializable]
    public class Grupo
    {
        #region Atributos

        private int? _codGrupo;
        private string _nomeGrupo;
        private Empresa.Empresa _empresa;
        private Grupo _pai;
        private Grupo _filho;
        private bool _raiz;
        private Usuario _responsavel;
        private Permissao.Permissao _permissao;
        private Grupo _parentGroup;
        private Area.Area _area;

        #endregion

        #region Propriedades

        public int? CodGrupo
        {
            get { return _codGrupo; }
            set { _codGrupo = value; }
        }

        public string NomeGrupo
        {
            get { return _nomeGrupo; }
            set { _nomeGrupo = value; }
        }

        public Empresa.Empresa Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        public Grupo Pai
        {
            get { return _pai; }
            set { _pai = value; }
        }

        public Grupo Filho
        {
            get { return _filho; }
            set { _filho = value; }
        }

        public bool Raiz
        {
            get { return _raiz; }
            set { _raiz = value; }
        }

        public Usuario Responsavel
        {
            get { return _responsavel; }
            set { _responsavel = value; }
        }

        public Permissao.Permissao Permissao
        {
            get { return _permissao; }
            set { _permissao = value; }
        }

        public Grupo ParentGroup
        {
            get { return _parentGroup; }
            set { _parentGroup = value; }
        }

        public Area.Area Area
        {
            get { return _area; }
            set { _area = value; }
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return String.Format
                ("ID: {0}, Nome: {1}, Area: {2}, ID Grupo pai: {3}, Nome Grupo pai: {4}", CodGrupo, NomeGrupo, Area == null ? "Sem Area" : Area.NomeArea, ParentGroup.CodGrupo, ParentGroup.NomeGrupo);
        }
        #endregion
    }
}