#region using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.ERB
{
    [Serializable]
    public class LAC
    {
        public int LacMin { get; set; }
        public int LacMax { get; set; }
        public string Uf { get; set; }
    }
}
