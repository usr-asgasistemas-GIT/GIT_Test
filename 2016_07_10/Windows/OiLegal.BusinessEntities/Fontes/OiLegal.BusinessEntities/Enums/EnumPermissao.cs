using System;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums
{
    #region Enumerador

    [Serializable]
    public enum EnumPermissao
    {
        CriarCadastros = 1,
        VisualizarCadastros = 2,
        AlterarCadastros = 3,
        ExcluirCadastros = 4,
        CriarPesquisasFixas = 5,
        VisualizarPesquisasFixas = 6,
        AlterarPesquisasFixas = 7,
        ExcluirPesquisasFixas = 8,
        CriarProtocolos = 9,
        BuscarProtocolos = 10,
        VisualizarProtocolos = 11,
        AlterarProtocolos = 12,

        VerEstatisticas = 13, //Ver estatisticas

        RemoverOficioExtraJudicial = 14,

        CadastrarComarca = 15,
        CadastrarVara = 16,
        CadastrarTipoEmissor = 17,
        CadastrarEmissor = 18,
        CadastrarTipoOrgaoEmissor = 19,
        CadastrarOrgaoEmissor = 20,
        CadastrarTipoAutoridade = 21,
        CadastrarAutoridade = 22,

        AlterarRequisicao = 23,
        CriarRequisicao = 24,
        VerRequisicao = 25,
        ExcluirRequisicao = 26,

        AlterarPrazoRequisicao = 27,
        AlterarCodProtocolo = 28,

        CriarPesquisasMoveis = 29,
        VisualizarPesquisasMoveis = 30,
        AlterarPesquisasMoveis = 31,
        ExcluirPesquisasMoveis = 32,
        CriarPesquisasCadastrais = 33,
        VisualizarPesquisasCadastrais = 34,
        AlterarPesquisasCadastrais = 35,
        ExcluirPesquisasCadastrais = 36,

        VerRelatorioIndexacao = 37,

        CriarPesquisasIP = 38,
        VisualizarPesquisasIP = 39,
        AlterarPesquisasIP = 40,
        ExcluirPesquisasIP = 41,

        CriarModeloCartaResposta = 42,
        VisualizarModelosCartaResposta = 43,
        AlterarModeloCartaResposta = 44,
        ExcluirModeloCartaResposta = 45,

        CriarPesquisasAnatel = 46,
        VisualizarPesquisasAnatel = 47,
        AlterarPesquisasAnatel = 48,
        ExcluirPesquisasAnatel = 49,
        CriarPesquisasJecProcon = 50,
        VisualizarPesquisasJecProcon = 51,
        AlterarPesquisasJecProcon = 52,
        ExcluirPesquisasJecProcon = 53,
        CriarPesquisasMediacao = 54,
        VisualizarPesquisasMediacao = 55,
        AlterarPesquisasMediacao = 56,
        ExcluirPesquisasMediacao = 57,

        VerEstatisticasTI = 58,
        
        VisualizarCadastrosGerais = 63,
        VisualizarCartaResposta = 64,
        CadastrarUf = 65,
        CadastrarCidade = 66,
        CadastrarOrigem = 67,
        CadastrarTipoDocumento = 68,
        CadastrarTipoRequisicao = 69,
        CadastrarEmpresa = 70,
        CadastrarPrazo = 71,

        VisualizarCadastrosCsc = 72,
        CadastrarProduto = 73,
        CadastrarVisao = 74,
        CadastrarBilhetador = 75,

        BuscaDeProtocoloPorParametro = 76,
        ReativarProtocolos = 77,
        EditarPrazoProtocolo = 78,

        CriarPesquisasBackOffice = 79,
        VisualizarPesquisasBackOffice = 80,
        AlterarPesquisasBackOffice = 81,
        ExcluirPesquisasBackOffice = 82,

        IniciarMultiplasSessoes = 83,
        ConcederMultiplasSessoes = 84,

        VisualizarTelaControle = 85,
        CriarPesquisaCDR = 86,
        VisualizarPesquisaCDR = 87,
        AlterarPesquisaCDR = 88,
        ExcluirPesquisaCDR = 89,
        VisualizarSolicitacoesAceitasSITTEL = 90,
        ProtocoloarSolicitacoesAceitasSITTEL = 91,
        RejeitarSolicitacoesAceitasSITTEL = 92,
        CriarPesquisaSolicitacoesAceitasSITTEL = 93,
        VisualizarSolicitacoesRejeitadasSITTEL = 94,
        VisualizarArquivoMortoSolicitacoesRejeitadasSITTEL = 95,
        ExecutarStatus = 96,
        AlterarOperacoesSITTEL = 97,
        VisualizarOperacoesSITTEL = 98,
        VisualizarLogs = 99,
        VisualizarMensagensLivresChat = 100,
        ResponderMensagensLivresChat = 101,
        CriarNovaMensagenLivreChart = 102,
        CriarOrgaosSITTEL = 103,
        VisualizarOrgaosSITTEL = 104,        
        ConfiguracaoSITTEL = 105,
        CadastroEmailEnvioMensagemSITTEL = 106,
        CadastrarTrocaMensagensLivresPrazoEmail = 107,
        RelatorioAcompanhamento = 108,
        CriarEmails = 109,
        VisualizarEmails = 110,
        ListagemEmailsEnviados = 111,
        FormatadorManual = 112,
        AlterarEmails = 113,
        HabilitarDesabilitarEmails = 114,
        ListagemEnvioEmail = 115,
        EditarPrazoRelatorioGeral = 116,
        CadastrarHBV = 117
    }

    #endregion
}
