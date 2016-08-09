using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Logging
{
    public enum EnumSubModuloFrotEnd
    {
        [Description("Consultas")]
        Consultas = 1
        ,
        [Description("Protocolo")]
        Protocolo = 2
        ,
        [Description("Consulta Numero Sensivel")]
        ConsultaNumeroSensivel = 3
        ,
        [Description("Permissao")]
        Permissao = 4
        ,
        [Description("Controle Grupo")]
        ControleGrupo = 5
        ,
        [Description("Controle Usuario")]
        ControleUsuario = 6
        ,
        [Description("Controle Hierarquia")]
        ControleHierarquia = 7
        ,
        [Description("Login")]
        Login = 8
        ,
        [Description("ERB")]
        ERB = 9
        ,
        [Description("PesquisaCadastralCRM")]
        PesquisaCadastralCRM = 10
        ,
        [Description("Carta Resposta")]
        CartaResposta = 11
        ,
        [Description("Pesquisa Anatel")]
        PesquisaAnatel = 12
        ,
        [Description("Pesquisa Mediação")]
        PesquisaMediacao = 13
        ,
        [Description("Pesquisa Jec Procon")]
        PesquisaJecProcon = 14
        ,
        [Description("Pesquisa IPDR")]
        PesquisaIP = 15,

        [Description("Pesquisa Back Office")]
        PesquisaBackOffice = 16

    }
}
