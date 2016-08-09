#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class CnAmazoniaCeluarPrazo
    {
        #region Atributos
        private string _cn;
        private DateTime _dataInicio;
        private DateTime _dataFim;

        #endregion

        #region Propriedades
        public string CN
        {
            get { return _cn;}
            set { _cn = value;}
        }

        public DateTime DataInicio
        {
            get { return _dataInicio; }
            set { _dataInicio = value; }
        }

        public DateTime DataFim
        {
            get { return _dataFim; }
            set { _dataFim = value; }
        }
        #endregion

        #region Construtor
        public CnAmazoniaCeluarPrazo(){ }

        public CnAmazoniaCeluarPrazo(string pCN, DateTime pDataInicio, DateTime pDataFim) 
        {
            _cn = pCN;
            _dataInicio = pDataInicio;
            _dataFim = pDataFim;
        }

        public CnAmazoniaCeluarPrazo( DateTime pDataInicio, DateTime pDataFim)
        {            
            _dataInicio = pDataInicio;
            _dataFim = pDataFim;
        }
        #endregion

    }
}
