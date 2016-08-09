using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Sittel
{
        public enum EnumStatusSittel : int
        {
            [Description("Recebida")]
            Recebida = 0,
            [DescriptionAttribute("Protocolada")]
            Protocolada = 1,
            [DescriptionAttribute("Executando")]
            Executando = 2,
            [DescriptionAttribute("Respondida")]
            Respondida = 3,
            [DescriptionAttribute("Concluida")]
            Concluida = 4,
            [DescriptionAttribute("Rejeitada")]
            Rejeitada = 5,
            [DescriptionAttribute("Erro")]
            Erro = 6,
            [DescriptionAttribute("Recusada")]
            Recusada = 7,
            [DescriptionAttribute("Processada")]
            Processada = 8,
            [DescriptionAttribute("Enviado")]
            Enviado = 9,
            [DescriptionAttribute("Resposta da recusa")]
            RecusaRespondida = 10
        }
}