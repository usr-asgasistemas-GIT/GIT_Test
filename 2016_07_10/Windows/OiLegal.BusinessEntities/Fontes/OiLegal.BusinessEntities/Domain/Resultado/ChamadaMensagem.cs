using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado
{
    [Serializable]
    public class ChamadaMensagem : Chamada
    {
        public string Eot_A { get; set; }
        public string Eot_B { get; set; }
        public Enums.TipoSentido Sentido { get; set; }
        public byte TipoCdr { get; set; }
        public string Flag_9digito_a { get; set; }
        public string Flag_9digito_b { get; set; }
        public string Flag_9digito_c { get; set; }

        #region Metodos
        public bool ValidarEot()
        {
            bool result = false;
            if (Sentido == AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.TipoSentido.Recebida)
            {
                if (string.IsNullOrEmpty(Eot_A) || Convert.ToInt32(Eot_A) == 0 || ListaEot().Contains(Eot_A))
                    result = true;
            }
            else
            {
                if (string.IsNullOrEmpty(Eot_B) || Convert.ToInt32(Eot_B) == 0 || ListaEot().Contains(Eot_B))
                    result = true;
            }
            return result;
        }
        #endregion
    }
}
