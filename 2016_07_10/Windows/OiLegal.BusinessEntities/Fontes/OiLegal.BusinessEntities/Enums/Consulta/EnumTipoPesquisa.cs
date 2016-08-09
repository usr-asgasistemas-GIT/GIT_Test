#region Using

using System;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta
{

    [Serializable]
    [XmlRoot]
    public enum EnumTipoPesquisa
    {
        [Description("Número")]
        Numero = 1,
        [DescriptionAttribute("IMEI")]
        Imei = 2,
        [DescriptionAttribute("IMSI")]
        Imsi = 3,
        [DescriptionAttribute("CGI")]
        Celula = 4,
        [DescriptionAttribute("CPMI(CPF/CNPJ)")]
        Cpmi = 5,
        [DescriptionAttribute("UF")]
        UF,
        [DescriptionAttribute("Bilhetador")]
        Bilhetador,
        [DescriptionAttribute("Anatel")]
        Anatel = 6,
        [DescriptionAttribute("Mediação")]
        Mediacao = 7,
        [DescriptionAttribute("Jec/Procon")]
        JecProcon = 8,
        [DescriptionAttribute("Lote de Terminais")]
        LoteDeTerminais = 9,
        [DescriptionAttribute("Ip")]
        Ip = 10,
        [DescriptionAttribute("Circuito")]
        Circuito = 11,
        [DescriptionAttribute("Lote de IPs")]
        LoteDeIps = 12,
        [DescriptionAttribute("Número + Imei")]
        NumeroComImei = 13,
        [DescriptionAttribute("Back Office")]
        BackOffice = 14,
        [DescriptionAttribute("Nome")]
        Nome = 15,
        [DescriptionAttribute("CPF/CNPJ")]
        CpfCnpj = 16,
        [DescriptionAttribute("Email")]
        Email = 17,
        [DescriptionAttribute("Nao Gera Pesquisa")]
        NaoGeraPesquisa= 18,
        [DescriptionAttribute("Bloqueio e Desbloqueio")]
        BloqueioDesbloqueio = 19,



    }
}