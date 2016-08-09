using System;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Request
{
    [Serializable]
    public enum  EnumStatusRequest
    {
        Criado = 0,
        Processando = 1,
        Sucesso = 2,
        TimeOut = 3,
        Erro = 4,
        Eot = 5
    }
}
