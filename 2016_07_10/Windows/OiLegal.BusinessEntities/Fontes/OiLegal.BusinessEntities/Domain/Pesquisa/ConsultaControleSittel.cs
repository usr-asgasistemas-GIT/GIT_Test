using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class ConsultaControleSittel
    {

        #region atributos
        private bool _buscaInicial;
        private string _codProtocolo;
        private string _codOrdemSittel;
        private string _nomeOrgao;
        private DateTime? _dtInicioCumpri;
        private DateTime? _dtFimCumpri;
        private DateTime? _dtInicioReceb;
        private DateTime? _dtFimReceb;
        private bool _ordensVencidas;
        private bool _omitirOrdensConcl;
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

        public DateTime? DtInicioCumpri
        {
            get { return _dtInicioCumpri; }
            set { _dtInicioCumpri = value; }
        }

        public DateTime? DtFimCumpri
        {
            get { return _dtFimCumpri; }
            set { _dtFimCumpri = value; }
        }

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

        public bool OrdensVencidas
        {
            get { return _ordensVencidas; }
            set { _ordensVencidas = value; }
        }

        public bool OmitirOrdensConcl
        {
            get { return _omitirOrdensConcl; }
            set { _omitirOrdensConcl = value; }
        }
        
        #endregion

        #region Construtor

        public ConsultaControleSittel() { }


        public ConsultaControleSittel(bool pBuscaInicial, string pCodProtocolo, string pCodOrdemSittel, string pNomeOrgao, DateTime? pDtInicioCumpri, DateTime? pDtFimCumpri, DateTime? pDtInicioReceb, DateTime? pDtFimReceb, bool pOrdensVencidas, bool pOmitirOrdensConcl)
        {
            _buscaInicial = pBuscaInicial;
            _codProtocolo = pCodProtocolo;
            _codOrdemSittel = pCodOrdemSittel;  
            _nomeOrgao = pNomeOrgao;
            _dtInicioCumpri = pDtInicioCumpri;
            _dtFimCumpri = pDtFimCumpri;
            _dtInicioReceb = pDtInicioReceb;
            _dtFimReceb = pDtFimReceb;
            _ordensVencidas = pOrdensVencidas;
            _omitirOrdensConcl = pOmitirOrdensConcl;
        }

        

        #endregion

    }
}
