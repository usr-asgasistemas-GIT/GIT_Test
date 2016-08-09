#region Using

using System.ComponentModel;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa
{
    #region Enumerador

    public enum EnumResultadoPersistencia
    {
        [Description("Normal")]
        Sucesso = 0,
        [Description("Número de terminal inválido.")]
        PesquisaNumeroSemIdTerminal = 1,
        [Description("Tabela temporária não criada.")]
        TabelaTemporariaNaoCriada = 2,
        [Description("Erro desconhecido ao popular view.")]
        ErroAoPopularView = 3,
        [Description("Erro ao montar Query da Sub Partição.")]
        ErroAoMontarQuerySubParticao = 4,
        [Description("Erro ao pesquisar id terminal.")]
        ErroAoPesquisarIdTerminal = 5,
        [Description("Erro inesperado.")]
        ErroInesperado = 6,
        [Description("Erro ao pesquisar id ip.")]
        ErroAoPesquisarIdIp = 7
    }

    #endregion
}
