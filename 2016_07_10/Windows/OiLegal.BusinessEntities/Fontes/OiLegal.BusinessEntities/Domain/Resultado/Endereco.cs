#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado
{
    [Serializable]
    public class Endereco
    {
        public string CodigoLocalidade { get; set; }
        public string Localidade { get; set; }
        public string TipoLogradouro { get; set; }
        public string DescricaoLogradouro { get; set; }
        public string CodigoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string PontoReferencia { get; set; }
        public string TipoComplemento1 { get; set; }
        public string NumeroComplemento1 { get; set; }
        public string TipoComplemento2 { get; set; }
        public string NumeroComplemento2 { get; set; }
        public string TipoComplemento3 { get; set; }
        public string NumeroComplemento3 { get; set; }
        
        #region Métodos Públicos

        public override string ToString()
        {
            string str = string.Empty;
            const string ESPACO = " ";

            str += this.TipoLogradouro + ESPACO;
            str += this.Logradouro + ESPACO;
            str += this.Numero + ESPACO;
            str += this.Complemento + ESPACO;
            str += this.Bairro + ESPACO;
            str += this.Cidade + ESPACO;
            if (!string.IsNullOrEmpty(this.Cep))
            {
                str += "CEP: " + this.Cep + ESPACO;
            }
            if (!string.IsNullOrEmpty(this.Estado))
            {
                str += "UF: " + this.Estado + ESPACO;
            }
            return str;
        }

        public string ToString2()
        {
            string str = string.Empty;
            const string ESPACO = " ";

            str += this.CodigoLocalidade + ESPACO;
            str += this.TipoLogradouro + ESPACO;
            str += this.Logradouro + ESPACO;
            str += this.Numero + ESPACO;
            str += this.Complemento + ESPACO;
            str += this.Bairro + ESPACO;
            str += this.Cidade + ESPACO;
            str += this.Cep + ESPACO;
            str += this.Estado;

            return str;
        }

        #endregion

    }
}
