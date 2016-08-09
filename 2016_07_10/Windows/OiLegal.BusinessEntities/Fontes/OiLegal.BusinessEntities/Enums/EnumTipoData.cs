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
    public enum TipoData
    {
        [Description("Data Cadastro")]
        DataCadastro = 1,
        [Description("Data do Recebimento na Área")]
        DataRecebimentoArea = 2,
        [Description("Data Recebimento Oi")]
        DataRecebimentoOi = 3,
        [Description("Data de Vencimento de Prazo")]
        DataVencimentoPrazo = 4
    }
}
