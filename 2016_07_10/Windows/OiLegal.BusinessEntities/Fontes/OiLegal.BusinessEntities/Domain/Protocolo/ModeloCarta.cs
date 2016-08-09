#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class ModeloCarta
    {

        #region Atributos

        private int? _idModeloCarta;
        private string _nome;
        private Usuario.Usuario _usuario;
        private string _conteudo;
        private TipoRequisicao _tipoRequisicao;

        #endregion

        #region Propriedades

        public int? IdModeloCarta
        {
            get { return _idModeloCarta; }
            set { _idModeloCarta = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public Usuario.Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string Conteudo
        {
            get { return _conteudo; }
            set { _conteudo = value; }
        }

        public TipoRequisicao TipoRequisicao
        {
            get { return _tipoRequisicao; }
            set { _tipoRequisicao = value; }
        }

        #endregion

        #region Métodos

        public override string ToString()
        {
            return string.Format("Id: {0}, Nome: {1}, Usuario: {2}, Conteudo: {3}, Tipo Resquisição: {4}", IdModeloCarta, Nome, Usuario.Nome, Conteudo, TipoRequisicao.Text);
        }

        public ModeloCarta() {}

        public ModeloCarta(int? idModelo, string nome)
        {
            _idModeloCarta = idModelo;
            _nome = nome;
        }

        #endregion

    }
}