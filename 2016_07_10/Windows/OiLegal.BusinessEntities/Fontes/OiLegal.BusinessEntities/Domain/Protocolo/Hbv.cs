using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    
    [Serializable]
    public class Hbv
    {

        #region Atributos

        private string _uf;
        private DateTime _dt_inicio;
        private DateTime _dt_fim;        
        private bool _ativo;        

        #endregion

        #region Propriedades

      
        public string Uf
        {
            get { return _uf; }
            set { _uf = value; }
        }

        public DateTime Data_Hora_Inicio
        {
            get { return _dt_inicio; }
            set { _dt_inicio = value; }
        }

        public DateTime Data_Hora_Fim
        {
            get { return _dt_fim; }
            set { _dt_fim = value; }
        }        

        public bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }
       

        #endregion

        #region Construtores

        public Hbv() { }

        public Hbv(string pUf, DateTime pDt_Inicio, DateTime pDt_Fim, bool pAtivo)
        {
            _uf = pUf;
            _dt_inicio = pDt_Inicio;
            _dt_fim = pDt_Fim;            
            _ativo = pAtivo;
        }
     
        #endregion
    }

}
