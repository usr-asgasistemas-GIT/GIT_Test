#region Using

using System;
using System.Collections.Generic;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Permissao
{
    [Serializable]
    public class Permissao : List<EnumPermissao>
    {

        #region Propriedades

        public bool HasThisPermission(EnumPermissao enumPermissao)
        {
            return Contains(enumPermissao);
        }

        /// <summary>
        /// Popula List Item de permissões.
        /// </summary>
        /// <returns>Lista com permissões que serão inseridas na List Item de Permissões.</returns>
        public static Permissao GetAllProtocolPermissions()
        {
            Array arrayPermissoesProtocolo = Enum.GetValues(typeof(EnumPermissao));
            return RetornarPermissoesProtocolo(arrayPermissoesProtocolo);
        }
        public static string GetPermissionTypeDescription(EnumPermissao enumPermissao)
        {
            switch (enumPermissao)
            {
                case EnumPermissao.CriarCadastros:
                    return "Criar Cadastros";
                case EnumPermissao.VisualizarCadastros:
                    return "Visualizar Cadastros";
                case EnumPermissao.AlterarCadastros:
                    return "Alterar Cadastros";
                case EnumPermissao.ExcluirCadastros:
                    return "Excluir Cadastros";
                case EnumPermissao.CriarPesquisasFixas:
                    return "Criar Pesquisas Fixas";
                case EnumPermissao.VisualizarPesquisasFixas:
                    return "Visualizar Pesquisas Fixas";
                case EnumPermissao.AlterarPesquisasFixas:
                    return "Alterar Pesquisas Fixas";
                case EnumPermissao.ExcluirPesquisasFixas:
                    return "Excluir Pesquisas Fixas";
                case EnumPermissao.CriarPesquisasMoveis:
                    return "Criar Pesquisas Móveis";
                case EnumPermissao.VisualizarPesquisasMoveis:
                    return "Visualizar Pesquisas Móveis";
                case EnumPermissao.AlterarPesquisasMoveis:
                    return "Alterar Pesquisas Móveis";
                case EnumPermissao.ExcluirPesquisasMoveis:
                    return "Excluir Pesquisas Móveis";
                case EnumPermissao.CriarPesquisasCadastrais:
                    return "Criar Pesquisas Cadastrais";
                case EnumPermissao.VisualizarPesquisasCadastrais:
                    return "Visualizar Pesquisas Cadastrais";
                case EnumPermissao.AlterarPesquisasCadastrais:
                    return "Alterar Pesquisas Cadastrais";
                case EnumPermissao.ExcluirPesquisasCadastrais:
                    return "Excluir Pesquisas Cadastrais";
                case EnumPermissao.CriarPesquisasIP:
                    return "Criar Pesquisas IP";
                case EnumPermissao.VisualizarPesquisasIP:
                    return "Visualizar Pesquisas IP";
                case EnumPermissao.AlterarPesquisasIP:
                    return "Alterar Pesquisas IP";
                case EnumPermissao.ExcluirPesquisasIP:
                    return "Excluir Pesquisas IP";
                case EnumPermissao.CriarPesquisasAnatel:
                    return "Criar Pesquisas Anatel";
                case EnumPermissao.VisualizarPesquisasAnatel:
                    return "Visualizar Pesquisas Anatel";
                case EnumPermissao.AlterarPesquisasAnatel:
                    return "Alterar Pesquisas Anatel";
                case EnumPermissao.ExcluirPesquisasAnatel:
                    return "Excluir Pesquisas Anatel";
                case EnumPermissao.CriarPesquisasJecProcon:
                    return "Criar Pesquisas JecProcon";
                case EnumPermissao.VisualizarPesquisasJecProcon:
                    return "Visualizar Pesquisas JecProcon";
                case EnumPermissao.AlterarPesquisasJecProcon:
                    return "Alterar Pesquisas JecProcon";
                case EnumPermissao.ExcluirPesquisasJecProcon:
                    return "Excluir Pesquisas JecProcon";
                case EnumPermissao.CriarPesquisasMediacao:
                    return "Criar Pesquisas Mediacao";
                case EnumPermissao.VisualizarPesquisasMediacao:
                    return "Visualizar Pesquisas Mediacao";
                case EnumPermissao.AlterarPesquisasMediacao:
                    return "Alterar Pesquisas Mediacao";
                case EnumPermissao.ExcluirPesquisasMediacao:
                    return "Excluir Pesquisas Mediacao";
                case EnumPermissao.CriarPesquisasBackOffice:
                    return "Criar Pesquisas Back Office";
                case EnumPermissao.VisualizarPesquisasBackOffice:
                    return "Visualizar Pesquisas Back Office";
                case EnumPermissao.AlterarPesquisasBackOffice:
                    return "Alterar Pesquisas Back Office";
                case EnumPermissao.ExcluirPesquisasBackOffice:
                    return "Excluir Pesquisas Back Office";
                case EnumPermissao.CriarModeloCartaResposta:
                    return "Criar Modelos de Cartas-Resposta";
                case EnumPermissao.VisualizarModelosCartaResposta:
                    return "Visualizar Modelos de Cartas-Resposta";
                case EnumPermissao.AlterarModeloCartaResposta:
                    return "Alterar Modelos de Cartas-Resposta";
                case EnumPermissao.ExcluirModeloCartaResposta:
                    return "Excluir Modelos de Cartas-Resposta";
                case EnumPermissao.CriarProtocolos:
                    return "Criar Protocolos";
                case EnumPermissao.BuscarProtocolos:
                    return "Buscar Protocolos";
                case EnumPermissao.VisualizarProtocolos:
                    return "Visualizar Protocolos";
                case EnumPermissao.AlterarProtocolos:
                    return "Alterar Protocolos";
                case EnumPermissao.VerEstatisticas:
                    return "Ver Estatísticas";
                case EnumPermissao.VerEstatisticasTI:
                    return "Ver Estatísticas TI";
                case EnumPermissao.VerRelatorioIndexacao:
                    return "Ver Relatório Indexação";
                case EnumPermissao.RemoverOficioExtraJudicial:
                    return "Remover Oficio Extra Judicial";
                case EnumPermissao.CadastrarComarca:
                    return "Cadastrar Comarca";
                case EnumPermissao.CadastrarVara:
                    return "Cadastrar Vara";
                case EnumPermissao.CadastrarTipoEmissor:
                    return "Cadastrar Tipo Emissor";
                case EnumPermissao.CadastrarEmissor:
                    return "Cadastrar Emissor";
                case EnumPermissao.CadastrarTipoOrgaoEmissor:
                    return "Cadastrar Tipo Orgão Emissor";
                case EnumPermissao.CadastrarOrgaoEmissor:
                    return "Cadastrar Orgão Emissor";
                case EnumPermissao.CadastrarTipoAutoridade:
                    return "Cadastrar Tipo Autoridade";
                case EnumPermissao.CadastrarAutoridade:
                    return "Cadastrar Autoridade";
                case EnumPermissao.AlterarRequisicao:
                    return "Alterar Requisição";
                case EnumPermissao.CriarRequisicao:
                    return "Criar Requisição";
                case EnumPermissao.VerRequisicao:
                    return "Ver Requisição";
                case EnumPermissao.ExcluirRequisicao:
                    return "Excluir Requisição";
                case EnumPermissao.AlterarPrazoRequisicao:
                    return "Alterar Prazo Requisição";
                case EnumPermissao.AlterarCodProtocolo:
                    return "Alterar Código do Protocolo";
                case EnumPermissao.VisualizarCadastrosGerais:
                    return "Ver Itens de Cadastro";
                case EnumPermissao.CadastrarUf:
                    return "Cadastrar UF";
                case EnumPermissao.CadastrarCidade:
                    return "Cadastrar Cidade";
                case EnumPermissao.CadastrarOrigem:
                    return "Cadastrar Origem";
                case EnumPermissao.CadastrarPrazo:
                    return "Cadastrar Prazo";
                case EnumPermissao.CadastrarTipoDocumento:
                    return "Cadastrar Tipo de Documento";
                case EnumPermissao.CadastrarTipoRequisicao:
                    return "Cadastrar Tipo de Requisição";
                case EnumPermissao.CadastrarEmpresa:
                    return "Cadastrar Empresa";
                case EnumPermissao.VisualizarCartaResposta:
                    return "Visualizar Cartas-Resposta";
                case EnumPermissao.BuscaDeProtocoloPorParametro:
                    return "Busca de Protocolo Por Parâmetro";
                case EnumPermissao.VisualizarCadastrosCsc:
                    return "Visualizar CadastrosCsc";
                case EnumPermissao.CadastrarProduto:
                    return "Cadastrar Produto";
                case EnumPermissao.CadastrarVisao:
                    return "Cadastrar Visão";
                case EnumPermissao.CadastrarBilhetador:
                    return "Cadastrar Bilhetador";
                case EnumPermissao.IniciarMultiplasSessoes:
                    return "Iniciar Múltiplas Sessões";
                case EnumPermissao.VisualizarTelaControle:
                    return "Visualizar Tela Controle";
                case EnumPermissao.CriarPesquisaCDR:
                    return "Criar Pesquisa CDR";
                case EnumPermissao.VisualizarPesquisaCDR:
                    return "Visualizar Pesquisa CDR";
                case EnumPermissao.AlterarPesquisaCDR:
                    return "Alterar Pesquisa CDR";
                case EnumPermissao.ExcluirPesquisaCDR:
                    return "Excluir Pesquisa CDR";
                case EnumPermissao.VisualizarSolicitacoesAceitasSITTEL:
                    return "Visualizar Solicitações Aceitas SITTEL";
                case EnumPermissao.ProtocoloarSolicitacoesAceitasSITTEL:
                    return "Protocoloar Solicitações Aceitas SITTEL";
                case EnumPermissao.RejeitarSolicitacoesAceitasSITTEL:
                    return "Rejeitar Solicitações Aceitas SITTEL";
                case EnumPermissao.CriarPesquisaSolicitacoesAceitasSITTEL:
                    return "Criar Pesquisa Solicitações Aceitas SITTEL";
                case EnumPermissao.VisualizarSolicitacoesRejeitadasSITTEL:
                    return "Visualizar Solicitações Rejeitadas SITTEL";
                case EnumPermissao.VisualizarArquivoMortoSolicitacoesRejeitadasSITTEL:
                    return "Visualizar Arquivo Morto Solicitações Rejeitadas SITTEL";
                case EnumPermissao.ExecutarStatus:
                    return "Executar Status";
                case EnumPermissao.AlterarOperacoesSITTEL:
                    return "Alterar Operações SITTEL";
                case EnumPermissao.VisualizarOperacoesSITTEL:
                    return "Visualizar Operações SITTEL";
                case EnumPermissao.VisualizarLogs:
                    return "Visualizar Logs";
                case EnumPermissao.VisualizarMensagensLivresChat:
                    return "Visualizar Mensagens Livres - Chat";
                case EnumPermissao.ResponderMensagensLivresChat:
                    return "Responder Mensagens Livres - Chat";
                case EnumPermissao.CriarNovaMensagenLivreChart:
                    return "Criar Nova Mensagen Livre - Chart";
                case EnumPermissao.CriarOrgaosSITTEL:
                    return "Criar Órgãos SITTEL";
                case EnumPermissao.VisualizarOrgaosSITTEL:
                    return "Visualizar Órgãos SITTEL";
                case EnumPermissao.ConfiguracaoSITTEL:
                    return "Configuração SITTEL";
                case EnumPermissao.CadastroEmailEnvioMensagemSITTEL:
                    return "Cadastro de E-mail Envio de Mensagem SITTEL";
                case EnumPermissao.CadastrarTrocaMensagensLivresPrazoEmail:
                    return "Cadastrar Troca de Mensagens Livres(chat) - Prazo e Email";
                case EnumPermissao.RelatorioAcompanhamento:
                    return "Relatório de Acompanhamento";
                case EnumPermissao.ListagemEmailsEnviados:
                    return "Listagem E-mails Enviados";
                case EnumPermissao.FormatadorManual:
                    return "Formatador Manual";
                case EnumPermissao.ListagemEnvioEmail:
                    return "Listagem de Envio de E-mails";
                case EnumPermissao.EditarPrazoRelatorioGeral:
                    return "Editar Prazo Relatorio Geral";
                case EnumPermissao.CadastrarHBV:
                    return "Cadastrar HBV";

                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Retornar todas as permissões de protocolo do usuário comum logado.  
        /// </summary>
        /// <param name="permissoesUsuarioComumLogado">Todas as permissões do usuário comum logado.</param>
        /// <returns>Permissões de protocolo do usuário comum logado.</returns>
        public static Permissao GetAllCommonUserPermissions(Permissao permissoesUsuarioComumLogado)
        {
            Array arrayPermissoesProtocolo = permissoesUsuarioComumLogado.ToArray();
            return RetornarPermissoesProtocolo(arrayPermissoesProtocolo);
        }

        /// <summary>
        /// Retornar todas as permissões de protocolo do usuário super logado.  
        /// </summary>
        /// <returns>Permissões de protocolo do usuário super logado.</returns>
        public static Permissao GetAllPermissions()
        {
            Permissao permissao = new Permissao();
            foreach (EnumPermissao permissionType in Enum.GetValues(typeof(EnumPermissao)))
            {
                permissao.Add(permissionType);
            }
            return permissao;
        }

        public static Permissao GetPermissionsMediacao()
        {
            Permissao permissoesProtocolo = new Permissao();
            foreach (EnumPermissao permissao in Enum.GetValues(typeof(EnumPermissao)))
            {
                switch (permissao)
                {
                    case EnumPermissao.VisualizarCadastrosCsc:
                    case EnumPermissao.CadastrarBilhetador:
                    case EnumPermissao.CadastrarProduto:
                    case EnumPermissao.CadastrarVisao:
                        permissoesProtocolo.Add(permissao);
                        break;
                    default:
                        break;
                }
            }
            return permissoesProtocolo;
        }

        private static Permissao RetornarPermissoesProtocolo(Array arrayPermissoesProtocolo)
        {
            Permissao permissoesProtocolo = new Permissao();
            foreach (EnumPermissao permissao in arrayPermissoesProtocolo)
            {
                switch (permissao)
                {
                    case EnumPermissao.VerEstatisticas:
                    case EnumPermissao.VerEstatisticasTI:
                    case EnumPermissao.RemoverOficioExtraJudicial:
                    case EnumPermissao.CadastrarComarca:
                    case EnumPermissao.CadastrarVara:
                    case EnumPermissao.CadastrarTipoEmissor:
                    case EnumPermissao.CadastrarEmissor:
                    case EnumPermissao.CadastrarTipoOrgaoEmissor:
                    case EnumPermissao.CadastrarOrgaoEmissor:
                    case EnumPermissao.CadastrarTipoAutoridade:
                    case EnumPermissao.CadastrarAutoridade:
                    case EnumPermissao.CadastrarUf:
                    case EnumPermissao.CadastrarCidade:
                    case EnumPermissao.CadastrarOrigem:
                    case EnumPermissao.CadastrarPrazo:
                    case EnumPermissao.CadastrarTipoDocumento:
                    case EnumPermissao.CadastrarTipoRequisicao:
                    case EnumPermissao.CadastrarEmpresa:
                    case EnumPermissao.AlterarRequisicao:
                    case EnumPermissao.CriarRequisicao:
                    case EnumPermissao.VerRequisicao:
                    case EnumPermissao.ExcluirRequisicao:
                    case EnumPermissao.AlterarPrazoRequisicao:
                    case EnumPermissao.AlterarCodProtocolo:
                    case EnumPermissao.VerRelatorioIndexacao:
                    case EnumPermissao.VisualizarCadastrosGerais:
                    case EnumPermissao.VisualizarCartaResposta:
                    case EnumPermissao.BuscaDeProtocoloPorParametro:
                    case EnumPermissao.VisualizarCadastrosCsc:
                    case EnumPermissao.CadastrarBilhetador:
                    case EnumPermissao.CadastrarProduto:
                    case EnumPermissao.CadastrarVisao:
                    case EnumPermissao.ConfiguracaoSITTEL:
                    case EnumPermissao.CadastroEmailEnvioMensagemSITTEL:
                    case EnumPermissao.CadastrarTrocaMensagensLivresPrazoEmail:
                    case EnumPermissao.RelatorioAcompanhamento:
                    case EnumPermissao.ListagemEmailsEnviados:                    
                    case EnumPermissao.FormatadorManual:
                    case EnumPermissao.ListagemEnvioEmail:
                    case EnumPermissao.EditarPrazoRelatorioGeral:
                    case EnumPermissao.CadastrarHBV:
                        permissoesProtocolo.Add(permissao);
                        break;
                    case EnumPermissao.ConcederMultiplasSessoes:
                        permissoesProtocolo.Add(EnumPermissao.IniciarMultiplasSessoes);
                        break;
                    default:
                        break;
                }
            }
            return permissoesProtocolo;
        }

        private static Permissao RetornarPermissoesMediacao(Array arrayPermissoesProtocolo)
        {
            Permissao permissoesProtocolo = new Permissao();
            foreach (EnumPermissao permissao in arrayPermissoesProtocolo)
            {
                switch (permissao)
                {
                    case EnumPermissao.VisualizarCadastrosCsc:
                    case EnumPermissao.CadastrarBilhetador:
                    case EnumPermissao.CadastrarProduto:
                    case EnumPermissao.CadastrarVisao:
                        permissoesProtocolo.Add(permissao);
                        break;
                    default:
                        break;
                }
            }
            return permissoesProtocolo;
        }


        #endregion
    }
}
