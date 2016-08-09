#region Usings

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado
{

    /// <summary>
    /// Registro de utilização de recurso IP.
    /// </summary>
    [Serializable]
    public class RegistroIp : IComparable<RegistroIp>
    {

        #region Propriedades

        public string IpClienteAlvo { get; set; }
        public string IpNas { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public string Fuso { get; set; }
        public string Produto { get; set; }
        public long NumeroDoCircuito { get; set; }
        public string LocalidadeDoAssinante { get; set; }
        public string Flag_9digito_a { get; set; }
        public int LinhaCDR { get; set; }

        public string NasPort { get; set; }
        public string NomeUsuario { get; set; }
        public string NasPortType { get; set; }
        public string Ident_Sessao { get; set; }
        public string Codigo_Provedor { get; set; }
        public string Localidade { get; set; }
        public string Gmt { get; set; }

        public Int64 Trafegado { get; set; }
        public string Framed { get; set; }
        public string Delegated { get; set; }
        public string Ip_addr_ipv6 { get; set; }

        #region SysLog
        public string IdEvento { get; set; }
        public int? IpPublicoA { get; set; }
        public int? IpPublicoB { get; set; }
        public int? IpPublicoC { get; set; }
        public int? IpPublicoD { get; set; }
        public int? PortaInicial { get; set; }
        public int? PortaFinal { get; set; }
        public int? IpPrivadoA { get; set; }
        public int? IpPrivadoB { get; set; }
        public int? IpPrivadoC { get; set; }
        public int? IpPrivadoD { get; set; }
        public string Evento { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public int? IpPublicoInicialA { get; set; }
        public int? IpPublicoInicialB { get; set; }
        public int? IpPublicoInicialC { get; set; }
        public int? IpPublicoInicialD { get; set; }
        public int? IpPublicoFinalA { get; set; }
        public int? IpPublicoFinalB { get; set; }
        public int? IpPublicoFinalC { get; set; }
        public int? IpPublicoFinalD { get; set; }
        #endregion


        /// <summary>
        /// 
        /// Número do celular que realizou o acesso.
        /// </summary>
        public string NA
        {
            get;
            set;
        }

        /// <summary>
        /// IMSI do celular que realizou o acesso.
        /// </summary>
        public string IMSI
        {
            get;
            set;
        }

        /// <summary>
        /// IMEI do celular que realizou o acesso.
        /// </summary>
        public string IMEI
        {
            get;
            set;
        }

        /// <summary>
        /// Duração do acesso.
        /// </summary>
        public long? Duracao
        {
            get;
            set;
        }

        /// <summary>
        /// Data do acesso.
        /// </summary>
        public DateTime DataAcesso
        {
            get;
            set;
        }

        /// <summary>
        /// Célula em que ocorreu o acesso.
        /// </summary>
        public string Celula
        {
            get;
            set;
        }

        /// <summary>
        /// LAC em que ocorreu o acesso.
        /// </summary>
        public string Lac
        {
            get;
            set;
        }

        /// <summary>
        /// Para pesquisas ADSL ou DIAL, pode conter os valores A, U ou O.
        /// A = start, U = interim, O = stop
        /// </summary>
        public string TipoRegistro
        {
            get;
            set;
        }

        /// <summary>
        /// Sigla UF.
        /// </summary>
        public string Uf
        {
            get;
            set;
        }
        
        #endregion

        #region IComparable<RegistroGPRS> Members

        /// <summary>
        /// Realiza a comparação entre dois registro para realizar a ordenação.
        /// </summary>
        /// <param name="other">Instância do outro registro.</param>
        /// <returns>Resulado da comparação.</returns>
        public int CompareTo(RegistroIp other)
        {
            try
            {
                return this.DataAcesso.CompareTo(other.DataAcesso);
            }
            catch
            {
                return 0;
            }
        }

        #endregion

    }
}
