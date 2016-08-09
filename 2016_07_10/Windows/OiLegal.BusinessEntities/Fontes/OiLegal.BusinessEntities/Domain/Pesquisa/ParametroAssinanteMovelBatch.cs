using System;
using System.Text;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    /// <summary>
    /// Entidade que identifica as propriedades do Assinante da Móvel a se solicitar ao SOA, referente as pesquisas Batch.
    /// </summary>
    [Serializable]
    public class ParametroAssinanteMovelBatch : ParametroAssinanteBatch
    {
        public DateTime DataSolicitacao { get; set; }
        public string Msisdn { get; set; }
        public string DescricaoLogradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string NomeEstado { get; set; }
        public string NomeCliente { get; set; }
        public string NumeroComplemento1 { get; set; }
        public string NumeroComplemento2 { get; set; }
        public string NumeroComplemento3 { get; set; }
        public string NumeroPorta { get; set; }
        public string Pais { get; set; }
        public string TipoComplemento1 { get; set; }
        public string TipoComplemento2 { get; set; }
        public string TipoComplemento3 { get; set; }
        public string Cod_Localidade { get; set; }
        
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            if (TipoBusca == EnumTipoBusca.CadastralMovel && CpfCnpj != null)
            {
                s.Append(this.CpfCnpj.ToString());
                s.Append(" - ");
            }
            if (TipoBusca == EnumTipoBusca.CadastralMovel && NomeCliente != null)
            {
                s.Append(this.NomeCliente.ToString());
                s.Append(" - ");
            }
            if (this.ValorParametro != 0)
            {
                s.Append(this.ValorParametro.ToString());
                s.Append(" - ");
            }
            if (this.Msisdn != null)
            {
                s.Append(this.Msisdn.ToString());
                s.Append(" - ");
            }
            if (TipoPesquisa == EnumTipoPesquisa.NumeroComImei)
            {
                s.Append(this.Imei.ToString());
                s.Append(" - ");
            }
            if ((this.DataInicial != null) && (this.DataFinal != null))
            {
                s.Append(this.DataInicial.Value.ToString());
                s.Append(" à ");
                s.Append(this.DataFinal.Value.ToString());
            }

            return s.ToString();
        }


        
    }
}
