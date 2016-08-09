
using System.ComponentModel;
namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Requisicao
{

    #region Enumerador

    public enum EnumTipoDeRequisicao
    {
        [DescriptionAttribute("Quebra de sigilo fixa")]
        QuebraDeSigiloFixa = 5,
        
        [DescriptionAttribute("Quebra de sigilo móvel")]
        QuebraDeSigiloMovel = 6,
        
        [DescriptionAttribute("Dados cadastrais")]
        DadosCadastrais = 7,
        
        [DescriptionAttribute("Quebra de sigilo IP")]
        QuebraDeSigiloIp = 18,
        
        [DescriptionAttribute("Anexo quebra de sigilo móvel")]
        AnexoQuebraDeSigiloMovel = 21,
        
        [DescriptionAttribute("Anexo quebra de sigilo fixa")]
        AnexoQuebraDeSigiloFixa = 22,
        
        [DescriptionAttribute("Anexo quebra de sigilo IP")]
        AnexoQuebraDeSigiloIp = 23,
        
        [DescriptionAttribute("Anexo dado cadastrais")]
        AnexoDadosCadastrais = 24,
        
        [DescriptionAttribute("Plantão quebra de sigilo movel")]
        PlantaoQuebraDeSigiloMovel = 26,
        
        [DescriptionAttribute("Plantão quebra de sigilo fixa")]
        PlantaoQuebraDeSigiloFixa = 27,
        
        [DescriptionAttribute("Plantão quebra de sigilo IP")]
        PlantaoQuebraDeSigiloIp = 28,
        
        [DescriptionAttribute("Plantão dados cadastrais")]
        PlantaoDadosCadastrais = 29,
        
        [DescriptionAttribute("Extrato")]
        Extrato = 200,
        
        [DescriptionAttribute("Extrato cadastro interlocutor")]
        ExtratoCadastroInterlocutor = 201,

        [DescriptionAttribute("Interceptação")]
        Interceptacao = 202,

        [DescriptionAttribute("Interceptação Móvel")]
        InterceptacaoMovel = 203,

        [DescriptionAttribute("Interceptação permissão acesso")]
        InterceptacaoPermissaoAcesso = 204,

        [DescriptionAttribute("Plantão Bloqueio e Desbloqueio")]
        PlantaoBloqueioDesbloqueio = 205,

        [DescriptionAttribute("Plantão Dados cadastrais complementares de interlocutor")]
        PlantaoCadastraisInterlocutor = 206,

        [DescriptionAttribute("Plantão Dados cadastrais complementares de outros")]
        PlantaoCadastraisOutros = 207,

        [DescriptionAttribute("Plantão ERB em tempo real de interlocutor")]
        PlantaoErbTempoRealInterlocutor = 208,

        [DescriptionAttribute("Plantão ERB em tempo real de outros")]
        PlantaoErbTempoRealOutros = 209,

        [DescriptionAttribute("Plantão Extrato complementar de interlocutor'")]
        PlantaoExtratoComplementarInterlocutor = 210,

        [DescriptionAttribute("Plantão Extrato complementar de outros")]
        PlantaoExtratoComplementarOutros = 211,

        [DescriptionAttribute("Plantão Última ERB de interlocutor")]
        PlantaoUltimaErbInterlocutor = 212,

        [DescriptionAttribute("Plantão Última ERB de outros")]
        PlantaoUltimaErbOutros = 213,

        [Description("Outras Requisições")]
        OutrasRequisicoes = 214,
    }

    #endregion

}
