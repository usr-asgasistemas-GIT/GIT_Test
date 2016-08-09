#region Using

using System;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta
{
        [Serializable]
        [XmlRoot]
        public enum EnumStatusPesquisa
        {
            [Description("Criada")]
            Criada = 0,
            [Description("Em Execução")]
            EmExecucao = 1,
            [Description("Pausada")]
            Parada = 2,
            [Description("Cancelada")]
            Cancelada = 3,
            [Description("Com Erro")]
            Erro = 4,
            [Description("Concluída")]
            Concluida = 5,
            [Description("O resultado de CDRs já está concluído.")]
            CDRProcessados = 6,
            [Description("Os dados de assinantes já foram recebidos. Aguardando processamento final.")]
            DadosAssinantesRecebidos = 7,
            [Description("Completa")]
            Completa = 8,
            [Description("Em processamento.")]
            EmProcessamento = 9,
            [Description("Aguardando os dados do assinante.")]
            DadosAssinanteAguardando = 10,
            [Description("Gerado arquivo parcial.")]
            GeradoArquivoParcial = 11,
            [Description("Processando dados de assinantes.")]
            ProcessandoDadosAssinantes = 12,
            [Description("Solicitando dados de assinantes.")]
            SolicitandoDadosAssinantes = 13,
            [Description("Solicitando dados cadastrais.")]
            SolicitandoDadosCadastrais = 14,
            [Description("Gerando relatório cadastral.")]
            GerandoRelatorioCadastral = 15
        }
}
