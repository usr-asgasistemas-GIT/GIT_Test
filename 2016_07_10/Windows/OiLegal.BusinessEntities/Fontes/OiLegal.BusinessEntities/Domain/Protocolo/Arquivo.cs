using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class Arquivo
    {
        public string Protocolo { get; set; }
        public int ID_Arquivo { get; set; }
        public string Caminho_Arquivo { get; set; }
        public string Caminho_Completo { get; set; }
        public byte[] Anexo { get; set; }
        public int FlagResultado { get; set; }
    }
}
