using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Requisicao
{    
    #region Enumerador

    [Serializable]    
    public enum EnumRequisicaoAgrupada
    {
        [DescriptionAttribute("Interceptação")]
        Interceptacao = 0,
        [DescriptionAttribute("Quebra de Sigilo IP")]
        QuebraDeSigiloIp = 1,
        [DescriptionAttribute("Extrato")]
        Extrato = 2,
        [DescriptionAttribute("Extrato com cadastro de interlocutor")]
        ExtratoInterlocutor = 7,
        [DescriptionAttribute("Dados Cadastrais")]
        DadosCadastrais = 3,
        [DescriptionAttribute("Plantão")]
        Plantao = 4,
        [DescriptionAttribute("Incompletas")]
        Incompletas = 5,
        [DescriptionAttribute("Outras")]
        Outras = 6
    }

    #endregion
}
