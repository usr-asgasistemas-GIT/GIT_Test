using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Logging
{
    public enum EnumLogSistemaAcao
    {
        Incluir = 1,
        Alterar = 2,
        Excluir = 3,
        Consultar = 4,
        Visualizar = 5,
        AcessoNegado = 6,
        Exportar = 7,
        Protocolar = 8,
        Rejeitar = 9,
        Desistir = 10,
        Concluir = 11,
        Fechar = 12,
        Enviar = 13,
        Importar = 14,
        AdicionarNumero = 15,
        AdicionarPesquisa = 16,
        ExecutarPesquisa = 17,
        Assumir = 18
    }

    public enum EnumLogSistemaFuncionalidade
    {
        [Description("ACEITE")]
        Aceite=1,

        [DescriptionAttribute("REJEIÇÃO")]
        Rejeicao=2,

        [DescriptionAttribute("PROTOCOLO")]
        Protocolo=3,

        [DescriptionAttribute("PESQUISA")]
        Pesquisa=4,

        [DescriptionAttribute("RESPOSTA")]
        Resposta=5,

        [DescriptionAttribute("BAIXA INTERMEDIARIA")]
        BaixaIntermediaria=6,

        [DescriptionAttribute("BAIXA FINAL")]
        BaixaFinal=7,

        [DescriptionAttribute("ARQUIVO ANEXO")]
        ArquivoAnexo=8,

        [DescriptionAttribute("USUARIO")]
        Usuário=9,

        [DescriptionAttribute("LOGIN")]
        Login=10,

        [DescriptionAttribute("CADASTROS GERAIS")]
        CadastrosGerais=11,

        [DescriptionAttribute("HIERARQUIA")]
        Hierarquia=12,

        [DescriptionAttribute("CAIXA DE ENTRADA")]
        CaixaEntrada = 13,

        [DescriptionAttribute("OPERAÇÃO")]
        Operacao = 14,

        [DescriptionAttribute("RECUSA")]
        Recusa = 15,

        [DescriptionAttribute("CONTROLE SITTEL")]
        ControleSittel = 16,

        [DescriptionAttribute("FILA DE MENSAGENS SITTEL")]
        FilaMensagens = 17,

        [DescriptionAttribute("FORMATADOR MANUAL")]
        FormatadorManual = 18       
    }
}
