using System;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain
{
    [Serializable]
    public class Evento
    {
        public Evento()
        {
            _id = -1;
        }

        //Evento ADMIN

        /// <summary>
        /// Construtor do objeto Evento Básico
        /// </summary>
        /// <param name="pID">Recebe o Id do Evento</param>
        /// <param name="pNomeEvento">Recebe o Nome do Evento</param>
        /// <param name="pTipoEvento">Recebe o EnumTipo do Evento</param>
        /// <param name="pMensagemEvento">Recebe a Mensagem do Evento</param>
        /// <param name="pDetalhesEvento">Recebe os Detalhes do Evento</param>
        public Evento(int? pID, string pNomeEvento, string pTipoEvento, string pMensagemEvento, string pDetalhesEvento)
        {
            _id = pID;
            _nomeEvento = pNomeEvento;
            _tipoEvento = pTipoEvento;
            _mensagemEvento = pMensagemEvento;
            _detalhesEvento = pDetalhesEvento;
        }

        /// <summary>
        /// Construtor do objeto Evento para o Login
        /// </summary>
        /// <param name="pID">Recebe o Id do Evento</param>
        /// <param name="pNomeEvento">Recebe o Nome do Evento</param>
        /// <param name="pTipoEvento">Recebe o EnumTipo do Evento</param>
        /// <param name="pMensagemEvento">Recebe a Mensagem do Evento</param>
        /// <param name="pDetalhesEvento">Recebe os Detalhes do Evento</param>
        /// <param name="pNomeUsuario">Recebe o Nome do Usuário</param>
        public Evento(int? pID, string pNomeEvento, string pTipoEvento, string pMensagemEvento, string pDetalhesEvento, string pNomeUsuario)
        {
            _id = pID;
            _nomeEvento = pNomeEvento;
            _tipoEvento = pTipoEvento;
            _mensagemEvento = pMensagemEvento;
            _detalhesEvento = pDetalhesEvento;
            _nomeUsuario = pNomeUsuario;
        }

        /// <summary>
        /// Construtor do objeto Evento Completo
        /// </summary>
        /// <param name="pID">Recebe o Id do Evento</param>
        /// <param name="pNomeAplicacao">Recebe o Nome da Aplicação do Evento</param>
        /// <param name="pNomeEvento">Recebe o Nome do Evento</param>
        /// <param name="pTipoEvento">Recebe o EnumTipo do Evento</param>
        /// <param name="pMensagemEvento">Recebe a Mensagem do Evento</param>
        /// <param name="pDataEvento">Recebe a Data do Evento</param>
        /// <param name="pErroEvento">Recebe o Erro da Aplicação</param>
        /// <param name="pDetalhesEvento">Recebe os Detalhes do Evento</param>
        /// <param name="pNomeUsuario">Recebe o Nome do Usuário</param>
        /// <param name="pNomeGrupoUsuario">Recebe o Nome do Grupo do Usuário</param>
        public Evento(int? pID, string pNomeAplicacao, string pNomeEvento, string pTipoEvento, string pMensagemEvento, DateTime pDataEvento, string pErroEvento, string pDetalhesEvento, string pNomeUsuario, string pNomeGrupoUsuario)
        {
            _id = pID;
            _nomeAplicacao = pNomeAplicacao;
            _nomeEvento = pNomeEvento;
            _tipoEvento = pTipoEvento;
            _mensagemEvento = pMensagemEvento;
            _dataEvento = pDataEvento;
            _erroEvento = pErroEvento;
            _detalhesEvento = pDetalhesEvento;
            _nomeUsuario = pNomeUsuario;
            _nomeGrupoUsuario = pNomeGrupoUsuario;
        }

        private int? _id;
        private string _nomeAplicacao;
        private string _nomeEvento;
        private string _tipoEvento;
        private string _mensagemEvento;
        private DateTime _dataEvento;
        private string _erroEvento;
        private string _detalhesEvento;
        private string _nomeUsuario;
        private string _nomeGrupoUsuario;
        private int _idUsuario;
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }


        public int ID
        {
            get { return _id.HasValue ? _id.Value : 0; }
            set { _id = value; }
        }

        public string NomeAplicacao
        {
            get { return _nomeAplicacao; }
            set { _nomeAplicacao = value; }
        }

        public string NomeEvento
        {
            get { return _nomeEvento; }
            set { _nomeEvento = value; }
        }

        public string TipoEvento
        {
            get { return _tipoEvento; }
            set { _tipoEvento = value; }
        }

        public string MensagemEvento
        {
            get { return _mensagemEvento; }
            set { _mensagemEvento = value; }
        }

        public DateTime DataEvento
        {
            get { return _dataEvento; }
            set { _dataEvento = value; }
        }

        public string ErroEvento
        {
            get { return _erroEvento; }
            set { _erroEvento = value; }
        }

        public string DetalhesEvento
        {
            get { return _detalhesEvento; }
            set { _detalhesEvento = value; }
        }

        public string NomeUsuario
        {
            get { return _nomeUsuario; }
            set { _nomeUsuario = value; }
        }

        public string NomeGrupoUsuario
        {
            get { return _nomeGrupoUsuario; }
            set { _nomeGrupoUsuario = value; }
        }
    }
}
