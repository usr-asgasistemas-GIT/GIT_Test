#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class CartaResposta
    {

        #region Atributos

        private int _idCartaResposta;
        private Requisicao _requisicao;
        private ModeloCarta _modeloCarta;
        private string _conteudo;
        private DateTime _dataCriacao;
        private string _nomeCarta;

        #endregion

        #region Propriedades

        public int IdCartaResposta
        {
            get { return _idCartaResposta; }
            set { _idCartaResposta = value; }
        }
        public string NomeCarta
        {
            get { return _nomeCarta; }
            set { _nomeCarta = value; }
        }

        public Requisicao Requisicao
        {
            get { return _requisicao; }
            set { _requisicao = value; }
        }

        public ModeloCarta ModeloCarta
        {
            get { return _modeloCarta;  }
            set { _modeloCarta = value; }
        }

        public string Conteudo
        {
            get { return _conteudo; }
            set { _conteudo = value; }
        }

        public DateTime DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = value; }
        }
     
        #endregion

        #region Métodos
        public override string ToString()
        {
            return string.Format("Id Modelo Carta: {0}, Código Requisição: {1}, Conteudo: {2}", ModeloCarta.IdModeloCarta, Requisicao.Cod_Requisicao, Conteudo);
        }
        #endregion

    }
}