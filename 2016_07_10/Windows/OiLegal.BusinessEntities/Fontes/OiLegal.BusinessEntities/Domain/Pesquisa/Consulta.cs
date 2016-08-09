using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class Consulta
    {
        #region Atributos

        private int _idConsulta;
        private int _idUsuario;
        private IList<Pesquisa> _pesquisas;
        private Protocolo.Protocolo _protocolo;
        private string _statusProtocolo;
        private DateTime _dataConsulta;
        
        #endregion

        #region Propriedades

        public int IdConsulta
        {
            get { return _idConsulta; }
            set { _idConsulta = value; }
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public IList<Pesquisa> Pesquisas
        {
            get { return _pesquisas; }
            set { _pesquisas = value; }
        }

        public Protocolo.Protocolo Protocolo
        {
            get { return _protocolo; }
            set { _protocolo = value; }
        }

        public string StatusProtocolo
        {
            get { return _statusProtocolo; }
            set { _statusProtocolo = value; }
        }

        public DateTime DataConsulta
        {
            get { return _dataConsulta; }
            set { _dataConsulta = value; }
        }
        #endregion

        public override string ToString()
        {
            return
                string.Format("IDCONSULTA : {0} | IDUSUARIO: {1} | PROTOCOLO: {2} |", 
                    IdConsulta, IdUsuario,Protocolo.CodProtocolo);
        }
    }
}
