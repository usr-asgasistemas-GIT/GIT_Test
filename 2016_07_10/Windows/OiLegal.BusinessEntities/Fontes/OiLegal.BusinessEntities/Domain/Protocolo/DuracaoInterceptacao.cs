using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class DuracaoInterceptacao
    {
        public int? ID { get; set; }
        public int? NumeroDias { get; set; }
        public DateTime? InicioPeriodoQuebra { get; set; }
        public int? Imediato { get; set; }
    }
}
