#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{

    #region Enumerador

    [Serializable]
    public enum StatusRequisicaoType
    {
        Aberto = 1,
        Recebido = 2,
        ComPesquisa = 3,
        Finalizado = 4,
        Vencido = 5
    }

    #endregion

}