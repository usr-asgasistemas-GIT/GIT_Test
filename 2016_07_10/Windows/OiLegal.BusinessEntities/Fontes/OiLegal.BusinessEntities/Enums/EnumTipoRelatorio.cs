using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums
{
    /// <summary>
    /// Tipo de data usado para fazer a busca
    /// </summary>
    public enum TipoRelatorio
    {
        [Description("Quantidade de Pesquisas em andamento de acordo com a classificação das mesmas(simples, média, complexa ou crítica).")]
        QtdPesquisaAndamento = 1,
        [Description("Tempo médio de execução das pesquisas de acordo com a classificação das mesmas(simples, média, complexa ou crítica).")]
        TempoMedioDeExecucao = 2,
        [Description("Tempo total de execução das pesquisas de acordo com a classificação das mesmas(simples, média, complexa ou crítica).")]
        TempoTotalDeExecucao = 3,
        [Description("Quantidade de pesquisas que ultrapassaram o SLA acordado de desempenho de acordo com a classificação das mesmas(simples, média, complexa ou crítica).")]
        QtdPesquisaUltrapassouSla = 4,
        [Description("Número máximo de pesquisas rodando em paralelo por ano, mês e dia.")]
        NumMaximoPesquisasRodando = 5,
        [Description("Número mínimo de pesquisas rodando em paralelo por ano, mês e dia.")]
        NumMinimoPesquisasRodando = 6,
        [Description("Porcentagem de ocupação da máquina por dia, mês e ano em relação as pesquisas.")]
        PorcentagemOcupacaoMaquina = 7,
        [Description("Volumetria média de CDRs por pesquisa por ano, mês e dia.")]
        VolumetriaMediaCdrPorPesquisa = 8,
        [Description("Volumetria média de CDRs pesquisados por dia, mês e ano.")]
        VolumetriaMediaCdrPorPeriodo = 9,
        [Description("Por tipo de busca cadastral.")]
        Portipobuscacadastral = 10,
        [Description("Por pesquisa de CDR/CDR + CRM.")]
        Porpesquisacdr = 11,
        [Description("Mapa Físico")]
        MapaFisico = 12,
        [Description("Mapa Lógico")]
        MapaLogico = 13,
        [Description("Quantidade estimada x carregada acumulada")]
        EstimadoCarregadoAcumulado = 14,
        [Description("Quantidade de dias indexados")]
        QtdDiasIndexados = 15,
        [Description("Quantidade estimada x carregada por dia")]
        EstimadoCarregadoDia = 16,
        [Description("Quantidade CDRs carregados")]
        QtdCDRsCarregados = 17,
        [Description("Quantidade CDRs recepção")]
        QtdCDRsRecepcao = 18,
        [Description("Mapa Indexação")]
        MapaIndexacao = 19



    }
}
