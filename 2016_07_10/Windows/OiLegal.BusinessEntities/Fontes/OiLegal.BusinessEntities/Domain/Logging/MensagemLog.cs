using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Logging;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Logging
{
    [Serializable]
    public class MensagemLog
    {
        public const string Erro = "ERRO";
        public const string Info = "INFO";

        #region Atributos

        private EnumModulo _moduloOrigem;

        private Enum _subModuloOrigem;

        private EnumModulo _moduloDestino;

        private Enum _subModuloDestino;

        private string _parametro;

        private string _tipo;

        private string _mensagem;

        #endregion

        #region Propriedades
        public EnumModulo ModuloOrigem
        {
            get { return _moduloOrigem; }
            set { _moduloOrigem = value; }
        }

        public Enum SubModuloOrigem
        {
            get { return _subModuloOrigem; }
            set { _subModuloOrigem = value; }
        }

        public EnumModulo ModuloDestino
        {
            get { return _moduloDestino; }
            set { _moduloDestino = value; }
        }

        public Enum SubModuloDestino
        {
            get { return _subModuloDestino; }
            set { _subModuloDestino = value; }
        }

        public string Parametro
        {
            get { return _parametro; }
            set { _parametro = value; }
        }

        public string TipoMensagem
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public string Mensagem
        {
            get { return _mensagem; }
            set { _mensagem = value; }
        }
        #endregion

        public MensagemLog(EnumModulo moduloOrigem, Enum subModuloOrigem, EnumModulo moduloDestino, Enum subModuloDestino, string tipoMensagem, string mensagem, string parametro)
        {
            ModuloOrigem = moduloOrigem;
            ModuloDestino = moduloDestino;
            SubModuloOrigem = subModuloOrigem;
            SubModuloDestino = subModuloDestino;
            TipoMensagem = tipoMensagem;
            Mensagem = mensagem;
            Parametro = parametro;
        }
    }
}
