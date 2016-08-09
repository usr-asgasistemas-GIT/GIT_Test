using System;
using System.Collections.Generic;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    /// <summary>
    /// Classe que agrupa dados de pesquisa da fase 3
    /// atualmente usado para Mediação e  Back-Office.
    /// </summary>
    [Serializable]
    public class AgrupadorDeDadosDaPesquisa
    {
        public Pesquisa Pesquisa { get; set; }
        public ParametroAnatelMediacaoJec Parametro { get; set; }
        public List<ParametroBasePesquisa> ParametrosBasePesquisa { get; set; }
        public List<ParametroBilhetador> ParametrosBilhetador { get; set; }
        public List<ParametroTerminais> ParametrosTerminais { get; set; }
        public List<ParametroIp> ParametrosIpdr { get; set; }
        public List<ParametroCamposCDRFiltro> ParametrosCamposCdrFiltro { get; set; }
        public List<ParametroCamposCDRRetornados> ParametrosCamposCdrRetornados { get; set; }

        /// <summary>
        /// Construtor utilizado para salvar dados de pesquisa Mediação e Back-Office em Session.
        /// </summary>
        public AgrupadorDeDadosDaPesquisa(
            Pesquisa pesquisa, ParametroAnatelMediacaoJec parametro, 
            List<ParametroBasePesquisa> parametrosBasePesquisa,
            List<ParametroBilhetador> parametrosBilhetador, 
            List<ParametroTerminais> parametrosTerminais, 
            List<ParametroIp> parametrosIpdr,
            List<ParametroCamposCDRFiltro> parametrosCamposCdrFiltro,
            List<ParametroCamposCDRRetornados> parametrosCamposCdrRetornados)
        {
            Pesquisa = pesquisa;
            Parametro = parametro;
            ParametrosBasePesquisa = parametrosBasePesquisa;
            ParametrosBilhetador = parametrosBilhetador;
            ParametrosTerminais = parametrosTerminais;
            ParametrosIpdr = parametrosIpdr;
            ParametrosCamposCdrFiltro = parametrosCamposCdrFiltro;
            ParametrosCamposCdrRetornados =  parametrosCamposCdrRetornados;
        }

        /// <summary>
        /// Construtor utilizado para criação de pesquisas Mediação e Back-Office.
        /// </summary>
        public AgrupadorDeDadosDaPesquisa(
           List<ParametroBasePesquisa> parametrosBasePesquisa,
           List<ParametroBilhetador> parametrosBilhetador,
           List<ParametroTerminais> parametrosTerminais,
           List<ParametroIp> parametrosIpdr,
           List<ParametroCamposCDRFiltro> parametrosCamposCdrFiltro,
           List<ParametroCamposCDRRetornados> parametrosCamposCdrRetornados)
        {
            ParametrosBasePesquisa = parametrosBasePesquisa;
            ParametrosBilhetador = parametrosBilhetador;
            ParametrosTerminais = parametrosTerminais;
            ParametrosIpdr = parametrosIpdr;
            ParametrosCamposCdrFiltro = parametrosCamposCdrFiltro;
            ParametrosCamposCdrRetornados = parametrosCamposCdrRetornados;
        }
    }
}
