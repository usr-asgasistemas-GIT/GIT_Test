#region Using

using System;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums;
using System.Collections.Generic;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado
{

    /// <summary>
    /// Classe que representa uma chamada telefônica.
    /// </summary>
    [Serializable]
    public class Chamada : IComparable<Chamada>, IComparable<ChamadaFixa>, IComparable<ChamadaMovel>
    {

        #region Propriedades

        /// <summary>
        /// Tipo de layout da chamada utilizada no CDR.
        /// </summary>
        public EnumTecnologiaCDR TecnologiaCDR
        {
            get
            {
                return _tecnologiaCDR;
            }
            set
            {
                _tecnologiaCDR = value;
            }
        }
        private EnumTecnologiaCDR _tecnologiaCDR;

        /// <summary>
        /// Informações do assinante A.
        /// </summary>
        public Assinante AssinanteA
        {
            get { return _assinanteA; }
            set { _assinanteA = value; }
        }
        private Assinante _assinanteA;

        /// <summary>
        /// Informações do assinante B.
        /// </summary>
        public Assinante AssinanteB
        {
            get { return _assinanteB; }
            set { _assinanteB = value; }
        }
        private Assinante _assinanteB;

        /// <summary>
        /// Número do assinante A.
        /// </summary>
        public string NC
        {
            get { return _nc; }
            set { _nc = value; }
        }
        private string _nc;

        /// <summary>
        /// Número do assinante B.
        /// </summary>
        public string NB
        {
            get { return _nb; }
            set { _nb = value; }
        }
        private string _nb;

        /// <summary>
        /// Número do assinante A.
        /// </summary>
        public string NA
        {
            get { return _na; }
            set { _na = value; }
        }
        private string _na;

        /// <summary>
        /// Número do assinante de Orígem. Quando a chamada for encaminhada, este número estará preenchido, e NA terá outro valor.
        /// </summary>
        public string NumeroTerminalOrigemEncaminhada
        {
            get { return _numeroTerminalOrigemEncaminhada; }
            set { _numeroTerminalOrigemEncaminhada = value; }
        }
        private string _numeroTerminalOrigemEncaminhada;

        /// <summary>
        /// Data em que a chamada foi realizada.
        /// </summary>
        public DateTime DataChamada
        {
            get { return _dataChamada; }
            set { _dataChamada = value; }
        }
        private DateTime _dataChamada;

        /// <summary>
        /// Tempo de duração da chamada.
        /// </summary>
        public long? Duracao
        {
            get { return _duracao; }
            set { _duracao = value; }
        }
        private long? _duracao;

        /// <summary>
        /// Tipo de registro. Header, Efetuada ou Recebida.
        /// </summary>
        public string TipoRegistro
        {
            get
            {
                return _tipoRegistro;
            }
            set
            {
                _tipoRegistro = value;
            }
        }
        private string _tipoRegistro;

        /// <summary>
        /// Origem do CDR.
        /// </summary>
        public string OrigemCDR
        {
            get
            {
                return _origemCDR;
            }
            set
            {
                _origemCDR = value;
            }
        }
        private string _origemCDR;

        /// <summary>
        /// A Portado.
        /// </summary>
        public string Aportado
        {
            get
            {
                return _aportado;
            }
            set
            {
                _aportado = value;
            }
        }
        private string _aportado;

        /// <summary>
        /// B Portado.
        /// </summary>
        public string Bportado
        {
            get
            {
                return _bportado;
            }
            set
            {
                _bportado = value;
            }
        }
        private string _bportado;

        /// <summary>
        /// Latitude.
        /// </summary>
        public string Latitude
        {
            get
            {
                return _latitude;
            }
            set
            {
                _latitude = value;
            }
        }
        private string _latitude;

        /// <summary>
        /// Longitude.
        /// </summary>
        public string Longitude
        {
            get
            {
                return _longitude;
            }
            set
            {
                _longitude = value;
            }
        }
        private string _longitude;

        /// <summary>
        /// Nos tipos de pesquisa onde é necessário armazenar apenas os 10 dígitos a direita do NA ou NOrígem, para comparação e regras, esse valor é armazenado aqui.
        /// </summary>
        public string NaFormatado { get; set; }

        /// <summary>
        /// Nos tipos de pesquisa onde é necessário armazenar apenas os 10 dígitos a direita do NOrígem, para comparação e regras, esse valor é armazenado aqui.
        /// </summary>
        public string NumeroOrigemFormatado { get; set; }

        /// <summary>
        /// Nos tipos de pesquisa onde é necessário armazenar apenas os 10 dígitos a direita do NB, para comparação e regras, esse valor é armazenado aqui.
        /// </summary>
        public string NbFormatado { get; set; }

        /// <summary>
        /// Para uso de ordenação para aplicação de regras.
        /// </summary>
        public string NaOuNbFormatado { get; set; }

        /// <summary>
        /// Para uso de ordenação para aplicação de regras.
        /// </summary>
        public string NaOuOrigemFormatado { get; set; }

        public int LinhaCDR { get; set; }

        public bool PertenceBrt { get; set; }

        public string GMT { get; set; }

        public static List<string> ListaEot()
        {
            List<string> lista = new List<string>();
            //EOT OI FIXA
            lista.Add("021");
            lista.Add("027");
            lista.Add("031");
            lista.Add("071");
            lista.Add("079");
            lista.Add("081");
            lista.Add("082");
            lista.Add("083");
            lista.Add("084");
            lista.Add("085");
            lista.Add("086");
            lista.Add("091");
            lista.Add("092");
            lista.Add("095");
            lista.Add("096");
            lista.Add("098");
            lista.Add("110");
            lista.Add("115");
            lista.Add("118");
            lista.Add("119");
            lista.Add("120");
            lista.Add("122");
            lista.Add("123");
            lista.Add("128");
            lista.Add("130");
            lista.Add("132");
            lista.Add("133");
            //EOT OI MOVEL
            lista.Add("301");
            lista.Add("305");
            lista.Add("306");
            lista.Add("307");
            lista.Add("308");
            lista.Add("309");
            lista.Add("310");
            lista.Add("321");
            lista.Add("322");
            lista.Add("327");
            lista.Add("331");
            lista.Add("342");
            lista.Add("347");
            lista.Add("352");
            lista.Add("371");
            lista.Add("379");
            lista.Add("381");
            lista.Add("382");
            lista.Add("383");
            lista.Add("384");
            lista.Add("385");
            lista.Add("386");
            lista.Add("391");
            lista.Add("392");
            lista.Add("395");
            lista.Add("396");
            lista.Add("398");
            lista.Add("399");
            //EOT OI MOVEL BRT
            lista.Add("540");
            lista.Add("547");
            lista.Add("551");
            lista.Add("555");
            lista.Add("561");
            lista.Add("562");
            lista.Add("565");
            lista.Add("567");
            lista.Add("593");
            lista.Add("594");
            //EOT OI MOVEL AMAZONIA
            lista.Add("002");
            lista.Add("005");
            lista.Add("090");
            lista.Add("097");
            lista.Add("099");
            // BRT
            lista.Add("041");
            lista.Add("047");
            lista.Add("051");
            lista.Add("052");
            lista.Add("055");
            lista.Add("061");
            lista.Add("062");
            lista.Add("065");
            lista.Add("067");
            lista.Add("093");
            lista.Add("094");
            lista.Add("511");
            lista.Add("513");
            lista.Add("516");
            lista.Add("521");
            lista.Add("525");
            lista.Add("527");
            lista.Add("531");
            lista.Add("535");
            lista.Add("542");
            lista.Add("548");
            lista.Add("549");
            lista.Add("571");
            lista.Add("579");
            lista.Add("581");
            lista.Add("582");
            lista.Add("583");
            lista.Add("584");
            lista.Add("585");
            lista.Add("586");
            lista.Add("591");
            lista.Add("592");
            lista.Add("595");
            lista.Add("596");
            lista.Add("598");

            return lista;
        }

        #endregion

        public static List<string> ListaEotBRTFixa()
        {
            List<string> lista = new List<string>();


            return lista;
        }


        #region IComparable<Chamada> Members

        /// <summary>
        /// Realiza a comparação entre as datas de chamada e horários de duas chamadas.
        /// </summary>
        /// <param name="other">Entidade contendo as informações da chamada a ser comparada.</param>
        /// <returns>Valor da comparação.</returns>
        public int CompareTo(Chamada other)
        {
            try
            {
                return this._dataChamada.CompareTo(other._dataChamada);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Realiza a comparação entre as datas de chamada e horários de duas chamadas.
        /// </summary>
        /// <param name="other">Entidade contendo as informações da chamada a ser comparada.</param>
        /// <returns>Valor da comparação.</returns>
        public int CompareTo(ChamadaFixa other)
        {
            try
            {
                return this._dataChamada.CompareTo(other._dataChamada);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Realiza a comparação entre as datas de chamada e horários de duas chamadas.
        /// </summary>
        /// <param name="other">Entidade contendo as informações da chamada a ser comparada.</param>
        /// <returns>Valor da comparação.</returns>
        public int CompareTo(ChamadaMovel other)
        {
            try
            {
                return this._dataChamada.CompareTo(other._dataChamada);
            }
            catch
            {
                return 0;
            }
        }

        #endregion


    }
}
