#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class Endereco
    {

        #region Atributos

        private string _logradouro;
        private string _numero;
        private string _complemento;
        private string _bairro;
        private string _cep;
        private Cidade _cidade;

        #endregion

        #region Propriedades

        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string Complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        public string CEP
        {
            get { return _cep; }
            set { _cep = value; }
        }

        public Cidade Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public override string ToString()
        {
            string str = string.Empty;
            const string espaco = " ";
            const string traco = " - ";

            str += Logradouro + espaco;
            str += Numero + espaco;
            str += Complemento + espaco;
            str += Bairro + espaco;

            if (Cidade != null)
            {
                str += Cidade.Nome + espaco;
                str += traco + Cidade.Uf.CodUf + espaco;
            }

            if (!string.IsNullOrEmpty(CEP))
            {
                str += "CEP: " + CEP + espaco;
            }

            return str;
        }

        #endregion
        
    }
}