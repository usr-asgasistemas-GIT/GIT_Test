using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa;


namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class ParametroCircuito : ParametroAuxiliar
    {
        private const int NUMERO = 0;
        private const int DATA_INICIAL = 1;
        private const int DATA_FINAL = 2;
        private const int FUSO_HORARIO = 3;
        private const int TIPO_BUSCA = 4;
        private const int TIPO_NUMERO = 5;
        private const int FLAG = 6;
        private const int LOCALIDADE = 7;

        public long NumeroDoCircuito { get; set; }

        public static IList<Parametro> RecuperarCircuitos(IEnumerable todosItens, string protocolo, Pesquisa pesquisa)
        {
            var listaDeParametros = new List<Parametro>();
            var listaDeCircuitos = (from arrayCircuito in
                                        (from ListItem item in todosItens select item.Value.Split(';'))
                                    where arrayCircuito[TIPO_NUMERO] == TipoDeNumero.Circuito.ToString()
                                    select new ParametroCircuito()
                                    {
                                        NumeroDoCircuito = long.Parse(arrayCircuito[NUMERO].ToString().Split('-')[0].Trim()),
                                        DataInicial = Convert.ToDateTime(arrayCircuito[DATA_INICIAL]),
                                        DataFinal = Convert.ToDateTime(arrayCircuito[DATA_FINAL]),
                                        FusoHorario = arrayCircuito[FUSO_HORARIO],
                                        TipoBusca = (EnumTipoBusca)int.Parse(arrayCircuito[TIPO_BUSCA]),
                                        Localidade = arrayCircuito[LOCALIDADE]
                                    }).ToList();

            foreach (var circuito in listaDeCircuitos)
            {
                var parametro = ObterParametro(protocolo, pesquisa);
                parametro.DataInicial = circuito.DataInicial.Value;
                parametro.ValorParametro = circuito.NumeroDoCircuito;
                parametro.FusoHorario = circuito.FusoHorario;
                parametro.TipoBusca = circuito.TipoBusca;
                parametro.TipoPesquisa = EnumTipoPesquisa.Circuito;
                parametro.DataFinal = circuito.DataFinal.Value;
                parametro.Localidade = circuito.Localidade;

                listaDeParametros.Add(parametro);
            }

            return listaDeParametros;
        }
    }


}