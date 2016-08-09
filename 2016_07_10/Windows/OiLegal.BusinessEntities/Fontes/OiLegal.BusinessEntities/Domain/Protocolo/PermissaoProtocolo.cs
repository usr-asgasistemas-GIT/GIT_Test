using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    public class PermissaoProtocolo
    {
        public int? CodPermissaoProtocolo { get; set; }
        public string CodProtocolo { get; set; }
        public long? OrdemSittel { get; set; }
        public string IndSolicitacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public bool DataQualquer { get; set; }
    }
}
