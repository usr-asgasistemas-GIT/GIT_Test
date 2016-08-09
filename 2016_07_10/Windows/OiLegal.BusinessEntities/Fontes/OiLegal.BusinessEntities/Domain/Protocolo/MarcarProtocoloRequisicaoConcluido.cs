using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class MarcarProtocoloRequisicaoConcluido
    {
        private bool _abaComPesquisa;
        private bool _temRequisicaoSittel;
        private List<RequisicaoSittel> _lstRequisicao;
        private List<string> _lstProtocolo;
        private List<string> _lstProtolocosSittel;

        private DateTime _dataBaixa;

        public bool AbaComPesquisa
        {
            get { return _abaComPesquisa; }
            set { _abaComPesquisa = value; }
        }

        public bool TemRequisicaoSittel
        {
            get { return _temRequisicaoSittel; }
            set { _temRequisicaoSittel = value; }
        }

        public List<RequisicaoSittel> LstRequisicao
        {
            get { return _lstRequisicao; }
            set { _lstRequisicao = value; }
        }

        public List<string> LstProtocolo
        {
            get { return _lstProtocolo; }
            set { _lstProtocolo = value; }
        }

        public List<string> LstProtocolosSittel
        {
            get { return _lstProtolocosSittel; }
            set { _lstProtolocosSittel = value; }
        }

        public DateTime DataBaixa
        {
            get { return _dataBaixa; }
            set { _dataBaixa = value; }
        }

        #region Construtor

        public MarcarProtocoloRequisicaoConcluido(bool pAbaComPesquisa, bool pTemRequisicaoSittel, List<RequisicaoSittel> pLstRequisicao, List<string> pLstProtocolo)
        {
            _abaComPesquisa = pAbaComPesquisa;
            _temRequisicaoSittel = pTemRequisicaoSittel;
            _lstRequisicao = pLstRequisicao;
            _lstProtocolo = pLstProtocolo;
        }

        public MarcarProtocoloRequisicaoConcluido(bool pAbaComPesquisa, bool pTemRequisicaoSittel, List<RequisicaoSittel> pLstRequisicao, List<string> pLstProtocolo, List<string> pLstProtocoSittel)
        {
            _abaComPesquisa = pAbaComPesquisa;
            _temRequisicaoSittel = pTemRequisicaoSittel;
            _lstRequisicao = pLstRequisicao;
            _lstProtocolo = pLstProtocolo;
            _lstProtolocosSittel = pLstProtocoSittel;
        }

        public MarcarProtocoloRequisicaoConcluido() { }

        #endregion
    }

    [Serializable]
    public class RequisicaoSittel
    {
        private string _reqOiLegal;
        private string _ordemSittel;
        private string _reqSittel;
        private string _indSolicitanteSittel;
        private string _protocolo;
        private bool _sittel;

        public string ReqOiLegal
        {
            get { return _reqOiLegal; }
            set { _reqOiLegal = value; }
        }

        public string OrdemSittel
        {
            get { return _ordemSittel; }
            set { _ordemSittel = value; }
        }

        public string ReqSittel
        {
            get { return _reqSittel; }
            set { _reqSittel = value; }
        }

        public string IndSolicitanteSittel
        {
            get { return _indSolicitanteSittel; }
            set { _indSolicitanteSittel = value; }
        }

        public string Protocolo
        {
            get { return _protocolo; }
            set { _protocolo = value; }
        }

        public bool Sittel
        {
            get { return _sittel; }
            set { _sittel = value; }
        }

        public DateTime DataRequisicao { get; set; }
       
        #region Construtor

        public RequisicaoSittel() { }

        public RequisicaoSittel(string pReqOiLegal, string pOrdemSittel, string pReqSittel, string pIndSolicitanteSittel)
        {
            _reqOiLegal = pReqOiLegal;
            _ordemSittel = pOrdemSittel;
            _reqSittel = pReqSittel;
            _indSolicitanteSittel = pIndSolicitanteSittel;
        }

        public RequisicaoSittel(string pReqOiLegal, string pOrdemSittel, string pReqSittel, string pIndSolicitanteSittel, string pProtocolo, bool pSittel,DateTime pDataRequisicao)
        {
            _reqOiLegal = pReqOiLegal;
            _ordemSittel = pOrdemSittel;
            _reqSittel = pReqSittel;
            _indSolicitanteSittel = pIndSolicitanteSittel;
            _protocolo = pProtocolo;
            _sittel = pSittel;
            DataRequisicao = pDataRequisicao;
        }


        #endregion
    }

}
