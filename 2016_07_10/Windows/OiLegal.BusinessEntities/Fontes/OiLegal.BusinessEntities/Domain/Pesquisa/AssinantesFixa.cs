#region using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class AssinantesFixa
    {
        #region Atributos
        #endregion

        #region Propriedades

        public string TERMINAL { get ; set; }
        public string DDD { get ; set; }
        public string CPFCNPJ { get ; set; }
        public string DATAATIVACAO { get ; set; }
        public string DATADESATIVACAO { get ; set; }
        public string NOMETITULAR { get ; set; }
        public string MATRICULAUSUARIO { get ; set; }

        #region Endereço 

        public string ENDCLIBAIRRO { get ; set; }
        public string ENDCLICEP { get ; set; }
        public string ENDCLICIDADE { get ; set; }
        public string ENDCLICODLOCALIDADE { get ; set; }
        public string ENDCLICODLOGRADOURO { get ; set; }
        public string ENDCLICOMPLEMENTO { get ; set; }
        public string ENDCLINOMELOGRADOURO { get ; set; }
        public string ENDCLINUMERO { get ; set; }
        public string ENDCLITIPOLOGRADOURO { get ; set; }
        public string ENDCLIUF { get ; set; }
        public string ENDCOBBAIRRO { get ; set; }
        public string ENDCOBCEP { get ; set; }
        public string ENDCOBCIDADE { get ; set; }
        public string ENDCOBCODLOCALIDADE { get ; set; }
        public string ENDCOBCODLOGRADOURO { get ; set; }
        public string ENDCOBCOMPLEMENTO { get ; set; }
        public string ENDCOBNOMELOGRADOURO { get ; set; }
        public string ENDCOBNUMERO { get ; set; }
        public string ENDCOBTIPOLOGRADOURO { get ; set; }
        public string ENDCOBUF { get; set; }

        #endregion

        #endregion

    }
}