using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Sittel
{
    [Serializable]
    public class ResultadoInterceptacaoSittel : MarshalByRefObject
    {
        #region Atributos
        private string _codProtocolo;
        private ResultadoRequisicao _resultadoRequisicao;

        #endregion

        #region Propriedades        
        public string CodProtocolo
        {
            get { return _codProtocolo; }
            set { _codProtocolo = value; }
        }

        public ResultadoRequisicao ResultadoRequisicao
        {
            get { return _resultadoRequisicao; }
            set { _resultadoRequisicao = value; }
        }
        #endregion

        #region Construtor
        public ResultadoInterceptacaoSittel() { }

        public ResultadoInterceptacaoSittel(string pCodProtocolo)
        {
            _codProtocolo = pCodProtocolo;
        }

        public ResultadoInterceptacaoSittel(string pCodProtocolo, ResultadoRequisicao pResultadoRequisicao)
        {
            _codProtocolo = pCodProtocolo;
            _resultadoRequisicao = pResultadoRequisicao;
        }     
        #endregion
    }
}
