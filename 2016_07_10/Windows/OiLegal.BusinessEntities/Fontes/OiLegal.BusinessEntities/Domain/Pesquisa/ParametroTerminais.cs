using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa;
using System.Collections;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa.NonoDigito;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class ParametroTerminais : ParametroAuxiliar
    {
        #region Atributos

        private long _numTerminal;
        private BuscaPorNaNb _buscaPorNaNb;
        private const int NUMERO = 0;
        private const int DATA_INICIAL = 1;
        private const int DATA_FINAL = 2;
        private const int FUSO_HORARIO = 3;
        private const int TIPO_BUSCA = 4;
        private const int TIPO_NUMERO = 5;
        private const int FLAG = 6;
        private const int LOCALIDADE = 7;

        #endregion

        #region Propriedades

        public long NumTerminal
        {
            get
            {
                return _numTerminal;
            }
            set
            {
                _numTerminal = value;
            }
        }

        public BuscaPorNaNb BuscaPorNaNb
        {
            get { return _buscaPorNaNb; }
            set { _buscaPorNaNb = value; }
        }
        #endregion

        public static IList<Parametro> RecuperarTerminais(IEnumerable todosItens, string protocolo, Pesquisa pesquisa)
        {
            var listaDeParametros = new List<Parametro>();
            var listaDeTerminais = (from arrayNumero in
                                        (from ListItem item in todosItens select item.Value.Split(';'))
                                    where arrayNumero[TIPO_NUMERO] == TipoDeNumero.Terminal.ToString()
                                    select new ParametroTerminais()
                                    {
                                        NumTerminal = long.Parse(arrayNumero[NUMERO]),
                                        DataInicial = Convert.ToDateTime(arrayNumero[DATA_INICIAL]),
                                        DataFinal = Convert.ToDateTime(arrayNumero[DATA_FINAL]),
                                        FusoHorario = arrayNumero[FUSO_HORARIO],
                                        TipoBusca = (EnumTipoBusca)int.Parse(arrayNumero[TIPO_BUSCA]),
                                        FlagNonoDigito = (EnumFlagExistenciaNonoDigito)int.Parse(arrayNumero[FLAG]),
                                        Localidade = arrayNumero[LOCALIDADE]
                                    }).ToList();

            foreach (var terminal in listaDeTerminais)
            {
                var parametro = ObterParametro(protocolo, pesquisa);
                parametro.DataInicial = terminal.DataInicial.Value;
                parametro.ValorParametro = terminal.NumTerminal;
                parametro.FusoHorario = terminal.FusoHorario;
                parametro.TipoBusca = terminal.TipoBusca;
                parametro.TipoPesquisa = EnumTipoPesquisa.Numero;
                parametro.DataFinal = terminal.DataFinal.Value;
                parametro.FlagNonoDigito = terminal.FlagNonoDigito;
                parametro.Localidade = terminal.Localidade;

                listaDeParametros.Add(parametro);
            }

            return listaDeParametros;


        }
    }
}

