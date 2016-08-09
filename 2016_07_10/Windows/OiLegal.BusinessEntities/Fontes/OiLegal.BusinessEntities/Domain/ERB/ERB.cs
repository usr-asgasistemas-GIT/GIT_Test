#region using

using System;
using System.Collections.Generic;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.ERB
{
    [Serializable]
    public class ERB
    {
        //#REQ#0170-001-25-1;1;2

        public Int64 Cell { get; set; }

        /// <summary>
        /// Criado para processamento do arquivo da Amazônia Celular.
        /// </summary>

        public string Celula { get; set; }

        public string Uf { get; set; }

        public string Cn { get; set; }

        public string Cnl { get; set; }        

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Azimute { get; set; }

        public string Endereco { get; set; }        

        public string Bairro { get; set; }

        public string Municipio { get; set; }

        public string LACSimples { get; set; }

        public string Central { get; set; }

        public string GMT { get; set; }

        #region Lac

        public string LUF { get; set; }
        public int LacMax { get; set; }
        public int LacMin { get; set; }

        #endregion

        public string Gtt { get; set; }
        
        public int MCC { get; set; }

        public int MNC { get; set; }

        public int Lac { get; set; }

        public DateTime? DataAtivacao { get; set; }

        public DateTime? DataDesativacao { get; set; }
        
    }
}