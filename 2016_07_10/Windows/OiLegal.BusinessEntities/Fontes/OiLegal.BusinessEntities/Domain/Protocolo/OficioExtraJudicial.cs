#region Using

using System;
using System.Text;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class OficioExtraJudicial    
    {

        #region Atributos

        private int _id;
        private string _numExtraJudicial;
        private DateTime? _data;
        private Cidade _cidade;
        private OrgaoEmissor _orgaoEmissor;
        private Emissor _emissor;
        private string _tipoAutoridade;
        private string _nomeAutoridade;

        #endregion

        #region Propriedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string NumExtraJudicial
        {
            get { return _numExtraJudicial; }
            set { _numExtraJudicial = value; }
        }
        
        public DateTime? Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public Cidade Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        
        public OrgaoEmissor OrgaoEmissor
        {
            get { return _orgaoEmissor; }
            set { _orgaoEmissor = value; }
        }

        public Emissor Emissor
        {
            get { return _emissor; }
            set { _emissor = value; }
        }

        /// <summary>
        /// Tipo de autoridade demandante
        /// </summary>
        public string TipoAutoridade
        {
            get { return _tipoAutoridade; }
            set { _tipoAutoridade = value; }
        }

        /// <summary>
        /// Nome da autoridade/responsável demandante
        /// </summary>
        public string NomeAutoridade
        {
            get { return _nomeAutoridade; }
            set { _nomeAutoridade = value; }
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            if (!string.IsNullOrEmpty(_numExtraJudicial))
            {
                s.Append("Número Documento : " + _numExtraJudicial);
            }

            if (_data != null)
            {
                if (s.Length > 0)
                    s.Append("-");

                s.Append("Data : " + _data);
            }


            if (_cidade != null)
            {
                if (s.Length > 0)
                    s.Append("-");

                s.Append("Cidade : " + _cidade.Nome);
            }

            if (_orgaoEmissor != null)
            {
                if (s.Length > 0)
                    s.Append("-");

                s.Append("Orgão Emissor : " + _orgaoEmissor.Descricao);
            }

            if (_emissor != null)
            {
                if (s.Length > 0)
                    s.Append("-");

                s.Append("Emissor : " + _emissor.NomeEmissor);
            }


            return s.ToString();

        }

        #endregion


    }
}