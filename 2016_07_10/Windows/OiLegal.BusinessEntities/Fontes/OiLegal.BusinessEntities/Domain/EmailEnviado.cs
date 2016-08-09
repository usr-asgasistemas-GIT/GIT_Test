using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain
{
    [Serializable]
    public class EmailEnviado
    {
         #region Atributos

        private int _codemailenviado;
        private string _codprotocolo;
        private int _codrequisicao;
        private string _assunto;
        private string _status;
        private string _remetente;
        private string _nomeremetente;
        private Dictionary<int,string> _enderecoemail;
        private List<string> _anexos;
        private DateTime _dataEnvio;
        private DateTime _dataCadastro;
        private string _conteudo;
        private string _assinatura;
        
        #endregion
        
        #region Propriedades

        public int CodEmailEnviado
        {
            get { return _codemailenviado; }
            set { _codemailenviado = value; }
        }

        public string CodProtocolo
        {
            get { return _codprotocolo; }
            set { _codprotocolo = value; }
        }

        public int CodRequisicao
        {
            get { return _codrequisicao; }
            set { _codrequisicao = value; }
        }

        public string Assunto
        {
            get { return _assunto; }
            set { _assunto = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string Remetente
        {
            get { return _remetente; }
            set { _remetente = value; }
        }

        public string NomeRemetente
        {
            get { return _nomeremetente; }
            set { _nomeremetente = value; }
        }

        public Dictionary<int,string> EnderecoEmail
        {
            get { return _enderecoemail; }
            set { _enderecoemail = value; }
        }

        public List<string> Anexos
        {
            get { return _anexos; }
            set { _anexos = value; }
        }

        public DateTime DataEnvio
        {
            get{ return _dataEnvio;}
            set {_dataEnvio = value;}
        }

        public DateTime DataCadastro
        {
            get{ return _dataCadastro;}
            set {_dataCadastro = value;}
        }

        public string Conteudo
        {
            get{ return _conteudo;}
            set {_conteudo = value;}
        }

        public string Assinatura
        {
            get { return _assinatura; }
            set { _assinatura = value; }
        }

        #endregion
        
        #region Construtores

        public EmailEnviado()
        {
            _enderecoemail = new Dictionary<int, string>();
            _anexos = new List<string>();
        }

        public EmailEnviado(int pcodEmailEnviado, string pcodProtocolo, int pcodRequisicao, string pAssunto, string pStatus, string pRemetente,string pNomeRemetente,Dictionary<int,string> pEnderecoEmail,List<string> pAnexo,DateTime pDataEnvio,DateTime pDataCadastro,string pConteudo, string pAssinatura)
        {
            _enderecoemail = new Dictionary<int, string>();
            _anexos = new List<string>();

            _codemailenviado = pcodEmailEnviado;
            _codprotocolo = pcodProtocolo;
            _codrequisicao = pcodRequisicao;
            _assunto = pAssunto;
            _remetente = pRemetente;
            _nomeremetente = pNomeRemetente;
            _enderecoemail = pEnderecoEmail;
            _anexos = pAnexo;
            _dataEnvio = pDataEnvio;
            _dataCadastro = pDataCadastro;
            _conteudo = pConteudo;
            _assinatura = pAssinatura;
        }        

        #endregion
    }
}
