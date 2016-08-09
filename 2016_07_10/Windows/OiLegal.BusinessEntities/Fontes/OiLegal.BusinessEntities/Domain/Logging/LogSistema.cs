using System;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Logging;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Logging
{
    public class LogSistema
    {
        #region Atributos
        private int? _id;
        private Protocolo.Protocolo _protocolo;
        private long? _codOrdem;
        private string _nomeOrgao;
        private DateTime? _dataHora;
        private EnumLogSistemaAcao _acao;
        private string _funcionalidade;
        private string _ip;
        private Usuario.Usuario _usuario;
        private string _mensagem;
        private DateTime? _dataHoraInicial;
        private DateTime? _dataHoraFinal;
        #endregion

        #region Propriedades
        public int? ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public Protocolo.Protocolo Protocolo
        {
            get 
            {
                if (_protocolo == null)
                    _protocolo = new Protocolo.Protocolo();
                return _protocolo; 
            }
            set { _protocolo = value; }
        }
        public long? CodOrdem
        {
            get { return _codOrdem; }
            set { _codOrdem = value; }
        }
        public string NomeOrgao
        {
            get { return _nomeOrgao; }
            set { _nomeOrgao = value; }
        }
        public DateTime? DataHora
        {
            get { return _dataHora; }
            set { _dataHora = value; }
        }
        public EnumLogSistemaAcao Acao
        {
            get { return _acao; }
            set { _acao = value; }
        }
        public string Funcionalidade
        {
            get { return _funcionalidade; }
            set { _funcionalidade = value; }
        }
        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }
        public Usuario.Usuario Usuario
        {
            get 
            {
                if (_usuario == null)
                    _usuario = new Usuario.Usuario();
                return _usuario; 
            }
            set { _usuario = value; }
        }
        public string Mensagem
        {
            get { return _mensagem; }
            set { _mensagem = value; }
        }
        public DateTime? DataHoraInicial
        {
            get { return _dataHoraInicial; }
            set { _dataHoraInicial = value; }
        }
        public DateTime? DataHoraFinal
        {
            get { return _dataHoraFinal; }
            set { _dataHoraFinal = value; }
        }
        #endregion
    }
}
