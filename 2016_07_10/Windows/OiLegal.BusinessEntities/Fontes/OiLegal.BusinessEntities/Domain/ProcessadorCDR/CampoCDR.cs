using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.ProcessadorCDR;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.ProcessadorCDR
{
    [Serializable]
    public class CampoCDR
    {
        private int _idTipoCDR;
        private EnumTipoLinhaCDR _tipo;
        private int _posicao;
        private int? _inicio;
        private string _nome;
        private int? _tamanho;
        private string _nomeDispatcher;

        public int IdTipoCDR
        {
            get { return _idTipoCDR; }
            set { _idTipoCDR = value; }
        }

        public EnumTipoLinhaCDR Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public int Posicao
        {
            get { return _posicao; }
            set { _posicao = value; }
        }

        public int? Inicio
        {
            get { return _inicio; }
            set { _inicio = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int? Tamanho
        {
            get { return _tamanho; }
            set { _tamanho = value; }
        }

        public string NomeDispatcher
        {
            get { return _nomeDispatcher; }
            set { _nomeDispatcher = value; }
        }

    }
}
