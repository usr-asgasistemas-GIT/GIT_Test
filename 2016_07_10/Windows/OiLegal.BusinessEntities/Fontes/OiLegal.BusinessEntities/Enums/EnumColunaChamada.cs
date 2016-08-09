#region Using

using System.ComponentModel;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums
{

    #region Enumerador

    public enum EnumColunaChamada
    {        
        [DescriptionAttribute("Sentido")]
        Sentido = 1,
        [DescriptionAttribute("Atendimento")]
        Indicador = 2,
        [DescriptionAttribute("EnumTipo de telefone")]
        Categoria = 3,
        [DescriptionAttribute("EnumTipo de chamada")]
        Servico = 4,
        [DescriptionAttribute("Código da Prestadora")]
        CSP = 5,
        [DescriptionAttribute("Operadora")]
        Operadora = 6,
        [DescriptionAttribute("Responsável")]
        Responsavel = 7,
        [DescriptionAttribute("Grupo")]
        Grupo = 8,
        [DescriptionAttribute("País")]
        Pais = 9,
        [DescriptionAttribute("Estado")]
        UF = 10,
        [DescriptionAttribute("Cidade")]
        Cidade = 11
    }

    #endregion

}