using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Sittel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Sittel
{
    public class RelatorioAtividadeSittel
    {

        #region Atributos

        private DateTime? _dataInicio;
        private DateTime? _dataFim;
        private bool _todosOsTipos;
        private EnumAtividadeSittel _tipoAtividade;
        private bool _onlySittel;

        #endregion

        #region Propriedades

        public DateTime? DataInicio 
        {
            get { return _dataInicio; }
            set { _dataInicio = value; }
        }

        public DateTime? DataFim
        {
            get { return _dataFim; }
            set { _dataFim = value; }
        }

        public bool TodosOsTipos
        {
            get { return _todosOsTipos; }
            set { _todosOsTipos = value; }
        }

        public EnumAtividadeSittel TipoAtividade
        {
            get { return _tipoAtividade; }
            set { _tipoAtividade = value; _todosOsTipos = false; }
        }

        public bool OnlySittel
        {
            get { return _onlySittel; }
            set { _onlySittel = value; }
        }

        #endregion

        #region Construtor
        
        public RelatorioAtividadeSittel()
        {
            _todosOsTipos = true;
            _dataInicio = null;
            _dataFim = null;
            _onlySittel = false;
        }
        
        #endregion
    }
}
