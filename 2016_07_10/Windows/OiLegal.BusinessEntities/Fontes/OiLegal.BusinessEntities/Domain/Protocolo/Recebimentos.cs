#region Using

using System;
using System.Collections.Generic;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class Recebimentos : List<RecebimentoType> 
    {

        public bool HasThisRecebimento(RecebimentoType recebimentoType) {
            return Contains(recebimentoType);
        }

        public static Recebimentos GetAllPermissions() {
            Recebimentos recebimentos = new Recebimentos();
            foreach (RecebimentoType recebimentoType in Enum.GetValues(typeof(RecebimentoType))) {
                recebimentos.Add(recebimentoType);
            }
            return recebimentos;
        }    

    }
}