using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class ConsultaOperacoesSittel
    {

        #region atributos
        private bool _buscaInicial;
        private string _codProtocolo;
        private string _codOrdemSittel;
        private string _nomeOrgao;
        //private DateTime? _dtInicioCumpri;
        //private DateTime? _dtFimCumpri;
        private DateTime? _dtInicioReceb;
        private DateTime? _dtFimReceb;
        private string _tpSolicitacao;
        
        #endregion

        #region propriedades

        public bool BuscaInicial
        {
            get { return _buscaInicial; }
            set { _buscaInicial = value; }
        }

        public string CodProtocolo
        {
            get { return _codProtocolo; }
            set { _codProtocolo = value; }
        }

        public string CodOrdemSittel
        {
            get { return _codOrdemSittel; }
            set { _codOrdemSittel = value; }
        }

        public string NomeOrgao
        {
            get { return _nomeOrgao; }
            set { _nomeOrgao = value; }
        }

        //public DateTime? DtInicioCumpri
        //{
        //    get { return _dtInicioCumpri; }
        //    set { _dtInicioCumpri = value; }
        //}

        //public DateTime? DtFimCumpri
        //{
        //    get { return _dtFimCumpri; }
        //    set { _dtFimCumpri = value; }
        //}

        public DateTime? DtInicioReceb
        {
            get { return _dtInicioReceb; }
            set { _dtInicioReceb = value; }
        }

        public DateTime? DtFimReceb
        {
            get { return _dtFimReceb; }
            set { _dtFimReceb = value; }
        }

        public string TpSolicitacao
        {
            get { return _tpSolicitacao; }
            set { _tpSolicitacao = value; }
        }
        
        #endregion

        #region Construtor

        public ConsultaOperacoesSittel() { }


        public ConsultaOperacoesSittel(bool pBuscaInicial, string pCodProtocolo, string pCodOrdemSittel, string pNomeOrgao, DateTime? pDtInicioReceb, DateTime? pDtFimReceb, string ptpSolicitacao)
        {
            _buscaInicial = pBuscaInicial;
            _codProtocolo = pCodProtocolo;
            _codOrdemSittel = pCodOrdemSittel;  
            _nomeOrgao = pNomeOrgao;           
            _dtInicioReceb = pDtInicioReceb;
            _dtFimReceb = pDtFimReceb;
            _tpSolicitacao = ptpSolicitacao;
           
        }

        

        #endregion

    }
}
