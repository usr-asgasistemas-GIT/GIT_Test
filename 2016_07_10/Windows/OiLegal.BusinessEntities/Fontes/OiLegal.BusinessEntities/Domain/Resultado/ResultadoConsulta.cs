#region Using

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado
{

    /// <summary>
    /// Classe que representa o resultado definitivo de uma busca por parâmetro.
    /// </summary>
    [Serializable]
    [XmlRoot("ResultadoConsulta")] 
    public class ResultadoConsulta
    {

        public ResultadoConsulta()
        {
            ChamadasDirecaoIndefinidaFixa = new List<ChamadaFixa>();
            ChamadasDirecaoIndefinidaMovel = new List<ChamadaMovel>();
            ChamadasEfetuadasFixa = new List<ChamadaFixa>();
            ChamadasEfetuadasMovel = new List<ChamadaMovel>();
            ChamadasEncaminhadasMovel = new List<ChamadaMovel>();
            ChamadasRecebidasFixa = new List<ChamadaFixa>();
            ChamadasRecebidasMovel = new List<ChamadaMovel>();
            DadosCadastrais = new List<Assinante>();
            DadosAssinantes = new List<Assinante>();

            ChamadasMSGRecebidas = new List<ChamadaMensagem>();
            ChamadasMSGEnviadas = new List<ChamadaMensagem>();
            RequestAssinante = new RequestDadosAssinantes();

            ListAssinantesFixa = new List<ParametroAssinante>();
            ListAssinantesMovel = new List<ParametroAssinante>();
            ListAlvo = new List<string>();

        }

        /// <summary>
        /// Lista de chamadas fixas recebidas.
        /// </summary>
        [XmlElement("ChamadasRecebidasFixa")]
        public List<ChamadaFixa> ChamadasRecebidasFixa { get; set; }

        /// <summary>
        /// Lista de chamadas efetuadas fixas.
        /// </summary>
        [XmlElement("ChamadasEfetuadasFixa")]
        public List<ChamadaFixa> ChamadasEfetuadasFixa { get; set; }

        /// <summary>
        /// Lista de chamadas da fixa com sentido Indefinido.
        /// </summary>
        [XmlElement("ChamadasDirecaoIndefinidaFixa")]
        public List<ChamadaFixa> ChamadasDirecaoIndefinidaFixa { get; set; }
        
        /// <summary>
        /// Lista de chamadas recebidas móvel.
        /// </summary>
        [XmlElement("ChamadasRecebidasMovel")]
        public List<ChamadaMovel> ChamadasRecebidasMovel { get; set; }

        /// <summary>
        /// Lista de chamadas efetuadas móvel.
        /// </summary>
        [XmlElement("ChamadasEfetuadasMovel")]
        public List<ChamadaMovel> ChamadasEfetuadasMovel { get; set; }

        /// <summary>
        /// Lista de chamadas efetuadas móvel.
        /// </summary>
        [XmlElement("ChamadasEncaminhadasMovel")]
        public List<ChamadaMovel> ChamadasEncaminhadasMovel { get; set; }

        /// <summary>
        /// Lista de chamadas da móvel com sentido Indefinido.
        /// </summary>
        [XmlElement("ChamadasDirecaoIndefinidaMovel")]
        public List<ChamadaMovel> ChamadasDirecaoIndefinidaMovel { get; set; }

        /// <summary>
        /// Dados cadastrais recuperados pela consulta.
        /// </summary>
        [XmlElement("DadosCadastrais")]
        public List<Assinante> DadosCadastrais { get; set; }

        /// <summary>
        /// Dados assinantes recuperados pela consulta.
        /// </summary>
        [XmlElement("DadosAssinantes")]
        public List<Assinante> DadosAssinantes { get; set; }

        /// <summary>
        /// Registro de uso de IP.
        /// </summary>
        [XmlElement("RegistrosIp")]
        public List<RegistroIp> RegistrosIp { get; set; }

        /// <summary>
        /// Parametro utilizado para a realização da pesquisa atual.
        /// </summary>
        [XmlElement("Parametro")]
        public Parametro Parametro
        {
            get
            {
                return _parametro;
            }
            set
            {
                _parametro = value;
            }
        }
        private Parametro _parametro;

        private List<ChamadaFixaCompleta> _chamadasFixasCompletas;

        /// <summary>
        /// Lista de chamadas Fixas com todos os dados do arquivo de retorno, usadas em pesquisas Anatel, Mediacao, JecProcon
        /// </summary>
        [XmlElement("ChamadasFixasCompletas")]
        public List<ChamadaFixaCompleta> ChamadasFixasCompletas
        {
            get { return _chamadasFixasCompletas; }
            set { _chamadasFixasCompletas = value; }
        }

        [XmlElement("_chamadasMoveisCompletas")]
        private List<ChamadaMovelCompleta> _chamadasMoveisCompletas;

        /// <summary>
        /// Lista de chamadas Móveis com todos os dados do arquivo de retorno, usadas em pesquisas Anatel, Mediacao, JecProcon
        /// </summary>
        [XmlElement("ChamadasMoveisCompletas")]
        public List<ChamadaMovelCompleta> ChamadasMoveisCompletas
        {
            get { return _chamadasMoveisCompletas; }
            set { _chamadasMoveisCompletas = value; }
        }

        /// <summary>
        /// Lista de mensagens enviadas.
        /// </summary>
        [XmlElement("ChamadasMSGEnviadas")]
        public List<ChamadaMensagem> ChamadasMSGEnviadas { get; set; }

        /// <summary>
        /// Lista de chamadas mensagens recebidas.
        /// </summary>
        [XmlElement("ChamadasMSGRecebidas")]
        public List<ChamadaMensagem> ChamadasMSGRecebidas { get; set; }

        [XmlElement("ListAssinantesFixa")]
        public List<ParametroAssinante> ListAssinantesFixa { get; set; }

        [XmlElement("ListAssinantesMovel")]
        public List<ParametroAssinante> ListAssinantesMovel { get; set; }

        [XmlIgnore]
        public RequestDadosAssinantes RequestAssinante { get; set; }

        [XmlIgnore]
        public List<string> ListAlvo { get; set; }
    }
}