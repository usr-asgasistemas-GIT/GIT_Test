using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Logging
{
    public enum EnumModulo
    {
        [Description("Front end web")]
        FrontEndWeb = 1,
        [Description("Dispatcher")]
        Dispatcher = 2,
        [Description("Flat Files")]
        FlatFiles = 3,
        [Description("Sistemas OI")]
        SistemasOI = 4

    }
}
