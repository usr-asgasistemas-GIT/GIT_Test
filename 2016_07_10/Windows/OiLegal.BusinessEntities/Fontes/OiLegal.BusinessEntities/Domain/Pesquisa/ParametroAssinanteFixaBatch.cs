using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa.Wll;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    /// <summary>
    /// Entidade que identifica as propriedades do Assinante da Fixa a se solicitar ao SOA, referente as pesquisas Batch.
    /// </summary>
    [Serializable]
    [XmlRoot]
    public class ParametroAssinanteFixaBatch : ParametroAssinanteBatch
    {
        [XmlAttribute("Uf")]
        public string Uf { get; set; }

        [XmlAttribute("CodLocalidade")]
        public string CodLocalidade { get; set; }

        [XmlAttribute("Complemento")]
        public string Complemento { get; set; }

        [XmlAttribute("Ddd")]
        public string Ddd { get; set; }

        [XmlAttribute("MatriculaUsuario")]
        public string MatriculaUsuario { get; set; }

        [XmlAttribute("NomeCliente")]
        public string NomeCliente { get; set; }

        [XmlAttribute("NumeroImovel")]
        public string NumeroImovel { get; set; }

        [XmlAttribute("Terminal")]
        public string Terminal { get; set; }

        [XmlAttribute("TipoLogradouro")]
        public string TipoLogradouro { get; set; }

        [XmlIgnore]
        public List<RequestCadastralCrmFixa> ListaDeRequestsCadastralCrmFixa { get; set; }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            if (TipoBusca == EnumTipoBusca.CadastralFixa && CpfCnpj != null)
            {
                s.Append(this.CpfCnpj.ToString());
                s.Append(" - ");
            }
            if (TipoBusca == EnumTipoBusca.CadastralFixa && NomeCliente != null)
            {
                s.Append(this.NomeCliente.ToString());
                s.Append(" - ");
            }
            if (this.ValorParametro != 0)
            {
                s.Append(this.ValorParametro.ToString());
                s.Append(" - ");
            }
            if (this.Terminal != null)
            {
                if (ValorParametro == null || ValorParametro == 0)
                {
                    string terminal = String.Empty;

                    if (this.Ddd != null)
                        terminal = this.Ddd;
                    terminal = terminal + this.Terminal;

                    s.Append(terminal);
                    s.Append(" - ");
                }
            }

            if ((this.DataInicial != null) && (this.DataFinal != null))
            {
                s.Append(this.DataInicial.Value.ToString());
                s.Append(" à ");
                s.Append(this.DataFinal.Value.ToString());
            }

            return s.ToString();
        }

        public string ToString(int a)
        {
            StringBuilder s = new StringBuilder();
            if (TipoBusca == EnumTipoBusca.CadastralFixa && CpfCnpj != null)
            {
                s.Append(this.CpfCnpj.ToString());
                s.Append(" - ");
            }
            if (this.ValorParametro != 0)
            {
                s.Append(this.ValorParametro.ToString());
                s.Append(" - ");
            }
            if (this.Terminal != null)
            {
                string terminal = String.Empty;

                if (this.Ddd != null)
                    terminal = this.Ddd;
                terminal = terminal + this.Terminal;

                s.Append(terminal);
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
