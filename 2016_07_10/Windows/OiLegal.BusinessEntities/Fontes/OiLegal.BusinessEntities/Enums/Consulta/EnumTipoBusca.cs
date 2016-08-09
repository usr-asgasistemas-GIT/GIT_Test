#region Using

using System;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta
{

    #region Enumerador

    [Serializable]
    [XmlRoot]
    public enum EnumTipoBusca
    {
        [Description("Oi Fixa")]
        Fixa = 1, 
        [DescriptionAttribute("Oi Movel")]
        Movel = 2,
        [DescriptionAttribute("Amazônia")]
        Amazonia = 3,
        [DescriptionAttribute("Cadastral Amazônia")]
        CadastralAmazonia = 4,
        [DescriptionAttribute("Cadastral CRM - Online")]
        CadastralCrm = 5,
        [DescriptionAttribute("Cadastral Oi Móvel")]
        CadastralMovel = 6,
        [DescriptionAttribute("Cadastral Oi Fixa")]
        CadastralFixa = 7,
        [DescriptionAttribute("IPDR")]
        IP = 8,

        [DescriptionAttribute("Anatel Fixa - Voz")]
        AnatelFixaVoz = 9,
        [DescriptionAttribute("Anatel Movel - Voz")]
        AnatelMovelVoz = 10,
        [DescriptionAttribute("Anatel Movel - SMS")]
        AnatelMovelSMS = 11,
        [DescriptionAttribute("Anatel Movel - OCS")]
        AnatelMovelOCS = 12,
        [DescriptionAttribute("Anatel Movel - MMS")]
        AnatelMovelMMS = 13,
        [DescriptionAttribute("Anatel Movel - GPRS")]
        AnatelMovelGPRS = 14,
        [DescriptionAttribute("Anatel Amazonia Movel - Voz")]
        AnatelAmazoniaMovelVoz = 15,

        [DescriptionAttribute("Jec Procon Fixa - Voz")]
        JecProconFixaVoz = 16,
        [DescriptionAttribute("Jec Procon Movel - Voz")]
        JecProconMovelVoz = 17,
        [DescriptionAttribute("Jec Procon Movel - SMS")]
        JecProconMovelSMS = 18,
        [DescriptionAttribute("Jec Procon Movel - OCS")]
        JecProconMovelOCS = 19,
        [DescriptionAttribute("Jec Procon Movel - MMS")]
        JecProconMovelMMS = 20,
        [DescriptionAttribute("Jec Procon Movel - GPRS")]
        JecProconMovelGPRS = 21,
        [DescriptionAttribute("Jec Procon Amazonia Movel - Voz")]
        JecProconAmazoniaMovelVoz = 22,

        [DescriptionAttribute("Mediação Fixa - Voz")]
        MediacaoFixaVoz = 23,
        [DescriptionAttribute("Mediação Movel - Voz")]
        MediacaoMovelVoz = 24,
        [DescriptionAttribute("Mediação Movel - SMS")]
        MediacaoMovelSMS = 25,
        [DescriptionAttribute("Mediação Movel - OCS")]
        MediacaoMovelOCS = 26,
        [DescriptionAttribute("Mediação Movel - MMS")]
        MediacaoMovelMMS = 27,
        [DescriptionAttribute("Mediação Movel - GPRS")]
        MediacaoMovelGPRS = 28,
        [DescriptionAttribute("Mediação Amazonia Movel - Voz")]
        MediacaoAmazoniaMovelVoz = 29,
        [DescriptionAttribute("IP - ADSL")]
        IpAdsl = 30,
        [DescriptionAttribute("IP - GPRS")]
        IpGprs = 31,
        [DescriptionAttribute("IP - DIAL")]
        IpDial = 32,
        [DescriptionAttribute("IP - TODAS")]
        IpTodas = 33,
        [DescriptionAttribute("Mediação Fixa - Ipdr")]
        MediacaoFixaIpdr = 34,

        [DescriptionAttribute("BackOffice Fixa - Voz")]
        BackOfficeFixaVoz = 35,
        [DescriptionAttribute("BackOffice Movel - Voz")]
        BackOfficeMovelVoz = 36,
        [DescriptionAttribute("BackOffice Movel - SMS")]
        BackOfficeMovelSMS = 37,
        [DescriptionAttribute("BackOffice Movel - OCS")]
        BackOfficeMovelOCS = 38,
        [DescriptionAttribute("BackOffice Movel - MMS")]
        BackOfficeMovelMMS = 39,
        [DescriptionAttribute("BackOffice Movel - GPRS")]
        BackOfficeMovelGPRS = 40,
        [DescriptionAttribute("BackOffice Amazonia Movel - Voz")]
        BackOfficeAmazoniaMovelVoz = 41,
        [DescriptionAttribute("BackOffice Fixa - Ipdr")]
        BackOfficeFixaIpdr = 42,

        // Nono Digito
        [DescriptionAttribute("Nono Digito Fixa - Voz")]
        FixaNonoDigito = 43,
        [DescriptionAttribute("Nono Digito Fixa Mista - Voz")]
        FixaNonoDigitoMista = 44,

        [DescriptionAttribute("Nono Digito Anatel Fixa - Voz")]
        AnatelFixaNonoDigito = 45,
        [DescriptionAttribute("Nono Digito Anatel Fixa Mista - Voz")]
        AnatelFixaNonoDigitoMista = 46,

        [DescriptionAttribute("Nono Digito Jec Procon Fixa - Voz")]
        JecProconFixaNonoDigito = 47,
        [DescriptionAttribute("Nono Digito Jec Procon Fixa Mista - Voz")]
        JecProconFixaNonoDigitoMista = 48,

        [DescriptionAttribute("Nono Digito Jec Procon Fixa - Voz")]
        MediacaoFixaNonoDigito = 49,
        [DescriptionAttribute("Nono Digito Jec Procon Fixa Mista - Voz")]
        MediacaoFixaNonoDigitoMista = 50,

        [DescriptionAttribute("Nono Digito BackOffice Fixa - Voz")]
        BackOfficeFixaNonoDigito = 49,
        [DescriptionAttribute("Nono Digito BackOffice Fixa Mista - Voz")]
        BackOfficeFixaNonoDigitoMista = 50,

        [DescriptionAttribute("Oi Movel - SMS")]
        MovelSMS = 51,
        [DescriptionAttribute("Oi Movel - MMS")]
        MovelMMS = 52,

         [DescriptionAttribute("IP - SYSLOG")]
        IpSysLog = 53,

        [DescriptionAttribute("Fixo e Movel - CPMI")]
        Cpmi = 54


    }

    #endregion

}