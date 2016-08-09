using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa
{

    /// <summary>
    /// Tipos de tecnologia que podem ser recebidas nos arquivos de CDR.
    /// </summary>
    [System.Flags]
    public enum OcorrenciaLimitanteResultado
    {
        SemLimitante = 0,
        LimiteDeTerminaisPesquisados = 1,
        CriacaoDaVw = 2,
        ArquivoDeResultadoBuscador = 4,
        ArquivoFinalDispatcher = 8,
        LimiteDispatcherCelula = 9

    }

}