using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Sittel
{
    [Serializable]
    public class MensagemSittel
    {
        #region Atributos      

        private string _id;
        private string _codProtocolo;
        private string _numOrdemSittel;
        private string _codNomeOrgao;
        private string _nomeOrgao;
        private string _codRequisicaoSittel;
        private string _numCaso;
        private bool _temMsgRecebida;
        private string _msgRecebida;
        private string _resposta;
        private bool _soVisualizacao;
        private bool _perguntaDoFront;

        #endregion

        #region Propriedades

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string CodProtocolo
        {
            get { return _codProtocolo; }
            set { _codProtocolo = value; }
        }

        public string NumOrdemSittel
        {
            get { return _numOrdemSittel; }
            set { _numOrdemSittel = value; }
        }

        public string codNomeOrgao
        {
            get { return _codNomeOrgao; }
            set { _codNomeOrgao = value; }
        }

        public string NomeOrgao
        {
            get { return _nomeOrgao; }
            set { _nomeOrgao = value; }
        }

        public string CodRequisicaoSittel
        {
            get { return _codRequisicaoSittel; }
            set { _codRequisicaoSittel = value; }
        }

        public string NumCaso
        {
            get { return _numCaso; }
            set { _numCaso = value; }
        }

        public bool TemMsgRecebida
        {
            get { return _temMsgRecebida; }
            set { _temMsgRecebida = value; }
        }              

        public string MsgRecebida
        {
            get { return _msgRecebida; }
            set { _msgRecebida = value; }
        }

        public string Resposta
        {
            get { return _resposta; }
            set { _resposta = value; }
        }

        public bool SoVisualizacao
        {
            get { return _soVisualizacao; }
            set { _soVisualizacao = value; }
        }

        public bool PerguntaDoFront
        {
            get { return _perguntaDoFront; }
            set { _perguntaDoFront = value; }
        }
               
        #endregion

        #region Construtor

        public MensagemSittel() { }
        

        #endregion
    }
}
