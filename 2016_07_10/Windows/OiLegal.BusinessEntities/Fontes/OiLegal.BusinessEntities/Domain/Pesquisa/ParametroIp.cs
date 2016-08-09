using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta;
using System.Web.UI.WebControls;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa.NonoDigito;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    //#REQ#0170-001-13-1;1;6

    [Serializable]
    [XmlRoot]
    public class ParametroIp : ParametroAuxiliar
    {
        private const int NUMERO = 0;
        private const int DATA_INICIAL = 1;
        private const int DATA_FINAL = 2;
        private const int FUSO_HORARIO = 3;
        private const int TIPO_BUSCA = 4;
        private const int TIPO_NUMERO = 5;
        private const int FLAG = 6;
        private const int LOCALIDADE = 7;
        private const int PORTA = 8;

        [XmlAttribute("Ip")]
        public string Ip { get; set; }

        public static IList<Parametro> RecuperarIps(IEnumerable todosItens, string protocolo, Pesquisa pesquisa)
        {
            var listaDeParametros = new List<Parametro>();
            var listaDeIps = (from arrayIp in
                                  (from ListItem item in todosItens select item.Value.Split(';'))
                              where arrayIp[TIPO_NUMERO] == TipoDeNumero.Ip.ToString()
                              select new ParametroIp
                              {
                                  Ip = arrayIp[NUMERO],
                                  DataInicial = Convert.ToDateTime(arrayIp[DATA_INICIAL]),
                                  DataFinal = Convert.ToDateTime(arrayIp[DATA_FINAL]),
                                  FusoHorario = arrayIp[FUSO_HORARIO],
                                  TipoBusca = (EnumTipoBusca)int.Parse(arrayIp[TIPO_BUSCA]),
                                  FlagNonoDigito = (EnumFlagExistenciaNonoDigito)int.Parse(arrayIp[FLAG]),
                                  Localidade = arrayIp[LOCALIDADE],
                                  Porta = arrayIp[PORTA]
                              }).ToList();

            foreach (var ip in listaDeIps)
            {
                var parametro = ObterParametro(protocolo, pesquisa);
                parametro.DataInicial = ip.DataInicial.Value;
                if (ip.Ip.Contains("."))
                    parametro.ValorParametro = long.Parse(ip.Ip.Replace(".", ""));
                parametro.Ip = ip.Ip;
                parametro.FusoHorario = ip.FusoHorario;
                parametro.TipoBusca = ip.TipoBusca;
                parametro.TipoPesquisa = EnumTipoPesquisa.Ip;
                parametro.DataFinal = ip.DataFinal.Value;
                parametro.FlagNonoDigito = EnumFlagExistenciaNonoDigito.NaoExiste;
                parametro.Localidade = ip.Localidade;
                parametro.Porta = ip.Porta;

                listaDeParametros.Add(parametro);
            }

            return listaDeParametros;
        }


    }
}
