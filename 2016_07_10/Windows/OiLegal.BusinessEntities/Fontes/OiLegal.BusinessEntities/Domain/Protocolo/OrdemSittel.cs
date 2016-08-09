using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Requisicao;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Sittel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    public class OrdemSittel
    {
        #region Attributes
        private Cidade _cidade;
        private TipoRejeicao _tipoRejeicao;
        #endregion

        #region Properties
        public long? CodigoOrdem { get; set; }
        public string NumeroOficioJudicial { get; set; }
        public string NumeroOficioExtraJudicial { get; set; }
        public string NumeroCaso { get; set; }
        public string NumeroProcesso { get; set; }
        public string NumeroInquerito { get; set; }
        public DateTime? DataExpedicaoOficioJudicial { get; set; }
        public DateTime? DataExpedicaoOficioExtra { get; set; }
        public string Comarca { get; set; }
        public string Vara { get; set; }
        public string CargoMagistrado { get; set; }
        public string NomeMagistrado { get; set; }
        public DateTime? DataRequisicao { get; set; }
        public DateTime? DataCumprimentoInicial { get; set; }
        public DateTime? DataCumprimentoFinal { get; set; }
        public string TipoAutoridade { get; set; }
        public string NomeAutoridade { get; set; }
        public string TelefoneAutoridade { get; set; }
        public string EmailAutoridade { get; set; }
        public int? QuantidadeRequisicoes { get; set; }
        public EnumStatusSittel Status { get; set; }
        public int? CodigoErro { get; set; }
        public string DescricaoErro { get; set; }
        public DateTime? DataRecebimentoInicial { get; set; }
        public DateTime? DataRecebimentoFinal { get; set; }
        public string CaminhoArquivoDecisao { get; set; }
        public DateTime? DataResposta { get; set; }
        public DateTime? DataConclusao { get; set; }
        public EnumTipoDeRequisicao? TipoSolicitacao { get; set; }
        public string TipoSolicitacoes { get; set; }
        public int? IdUsuario { get; set; }
        public string JustificativaRejeicao { get; set; }
        public string NomeOrgao { get; set; }
        public int? PercentualRequisicoesRejeitadas { get; set; }
        public DateTime? DataRecusaInicial { get; set; }
        public DateTime? DataRecusaFinal { get; set; }

        public Cidade Cidade
        {
            get
            {
                if (this._cidade == null)
                    this._cidade = new Cidade();
                return this._cidade;
            }
            set { this._cidade = value; }
        }

        public TipoRejeicao TipoRejeicao 
        {
            get
            {
                if (this._tipoRejeicao == null)
                    this._tipoRejeicao = new TipoRejeicao();
                return this._tipoRejeicao;
            }
            set { this._tipoRejeicao = value; }
        }
        #endregion
    }
}
