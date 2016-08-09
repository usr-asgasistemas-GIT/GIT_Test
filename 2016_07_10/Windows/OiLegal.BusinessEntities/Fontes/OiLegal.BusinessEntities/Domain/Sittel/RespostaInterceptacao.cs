using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Requisicao;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Sittel
{
    public class RespostaInterceptacao
    {
        #region Atributos

        string _codProtocolo;
        int _codRequisicao;
        EnumTipoDeRequisicao _tipoRequisicao;
        string _tipoEvento;

        DateTime? _dataInicio;
        string _gmtInicio;
        DateTime? _dataFim;
        string _gmtFim;
        string _emailUsr;
        string _loginUsr;
        string _nomeUsr;
        string _senhaUsr;
        bool _mudouSenhaUsr;
        string _nomeOperacao;
        string _senhaOperacao;
        bool _mudouSenhaOperacao;

        //Para interceptacoes do Tipo Ultima Erb
        bool _CGINaoEspecificado;
        string _CGI;
        int _cellId;
        string _endereco;
        string _bairro;
        string _municipio;
        string _uf;
        string _pais;
        string _cep;
        string  _latitude;
        string _longitude;
        string _azimute;
        #endregion

        #region Propriedades

        public string CodProtocolo
        {
            get { return _codProtocolo; }
            set { _codProtocolo = value; }
        }

        public int CodRequisicao
        {
            get { return _codRequisicao; }
            set { _codRequisicao = value; }
        }

        public EnumTipoDeRequisicao TipoRequisicao
        {
            get { return _tipoRequisicao; }
            set { _tipoRequisicao = value; }
        }

        public string TipoEvento
        {
            get { return _tipoEvento; }
            set { _tipoEvento = value; } 
        }

        public DateTime? DataHoraInicio
        {
            get { return _dataInicio; }
            set { _dataInicio = value; }
        }

        public string GmtInicio
        {
            get { return _gmtInicio; }
            set { _gmtInicio = value; }
        }

        public DateTime? DataHoraFim
        {
            get { return _dataFim; }
            set { _dataFim = value; }
        }

        public string GmtFim
        {
            get { return _gmtFim; }
            set { _gmtFim = value; }
        }

        public string EmailUsr
        {
            get { return _emailUsr; }
            set { _emailUsr = value; }
        }

        public string NomeUsr
        {
            get { return _nomeUsr; }
            set { _nomeUsr = value; }
        }

        public string LoginUsr
        {
            get { return _loginUsr; }
            set { _loginUsr = value; }
        }

        public string SenhaUsr
        {
            get { return _senhaUsr; }
            set { _senhaUsr = value; }
        }

        public bool MudouSenhaUsr
        {
            get { return _mudouSenhaUsr; }
            set { _mudouSenhaUsr = value; }
        }

        public string NomeOperacao
        {
            get { return _nomeOperacao; }
            set { _nomeOperacao = value; }
        }

        public string SenhaOperacao
        {
            get { return _senhaOperacao; }
            set { _senhaOperacao = value; }
        }

        public bool MudouSenhaOperacao
        {
            get { return _mudouSenhaOperacao; }
            set { _mudouSenhaOperacao = value; }
        }

        public bool CGINaoEspecificado
        { 
            get {return _CGINaoEspecificado; }
            set {_CGINaoEspecificado = value;}
        }

        public string CGI
        {
            get { return _CGI; }
            set { _CGI = value; }
        }

        public int CellId
        {
            get { return _cellId; }
            set { _cellId = value; }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        } 

        public string Municipio
        {
            get { return _municipio; }
            set { _municipio = value; }
        } 

        public string UF
        {
            get { return _uf; }
            set { _uf = value; }
        }

        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        public string Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        public string Latitude
        {
            get {return _latitude;}
            set{ _latitude = value;}
        }

        public string Longitude
        {
            get {return _longitude;}
            set{ _longitude = value;}
        }

        public string Azimute
        {
            get { return _azimute; }
            set { _azimute = value; }
        }
        #endregion

        #region Construtor

        public RespostaInterceptacao()
        {
            _mudouSenhaOperacao = false;
            _mudouSenhaUsr = false;
            _CGINaoEspecificado = true;
        }
        #endregion

    }
}
