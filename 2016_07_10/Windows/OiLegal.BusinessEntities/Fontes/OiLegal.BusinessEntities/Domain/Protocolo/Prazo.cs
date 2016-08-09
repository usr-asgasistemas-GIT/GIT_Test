#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class Prazo : IEnumerableClass
    {  

        #region Atributos

        private int _id;
        private double _valorPrazo;
        private string _descricao;
        private TipoRequisicao _tipoRequisicao;
        private short _ordem;

        #endregion

        #region Propriedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double ValorPrazo
        {
            get { return _valorPrazo; }
            set { _valorPrazo = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public TipoRequisicao TipoRequisicao
        {
            get { return _tipoRequisicao; }
            set { _tipoRequisicao = value; }
        }

        public short Ordem
        {
            get { return _ordem; }
            set { _ordem = value; }
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

        public Prazo() { }

        public Prazo(int pID,double pValorPrazo, string pDescricao, TipoRequisicao pTipoRequisicao)
        {
            _id = pID;
            _valorPrazo = pValorPrazo;
            _descricao = pDescricao;
            _tipoRequisicao = pTipoRequisicao;
        }

        public Prazo(double pValorPrazo, string pDescricao, TipoRequisicao pTipoRequisicao)
        {
            _valorPrazo = pValorPrazo;
            _descricao = pDescricao;
            _tipoRequisicao = pTipoRequisicao;
        }

        public Prazo(double pValorPrazo, string pDescricao, TipoRequisicao pTipoRequisicao, short pOrdenacaoPrazo)
        {
            _valorPrazo = pValorPrazo;
            _descricao = pDescricao;
            _tipoRequisicao = pTipoRequisicao;
            _ordem = pOrdenacaoPrazo;
        }

        public Prazo(int pID, double pValorPrazo, string pDescricao, TipoRequisicao pTipoRequisicao, short pOrdenacaoPrazo)
        {
            _id = pID;
            _valorPrazo = pValorPrazo;
            _descricao = pDescricao;
            _tipoRequisicao = pTipoRequisicao;
            _ordem = pOrdenacaoPrazo;
        }

        #endregion
        
    }

}