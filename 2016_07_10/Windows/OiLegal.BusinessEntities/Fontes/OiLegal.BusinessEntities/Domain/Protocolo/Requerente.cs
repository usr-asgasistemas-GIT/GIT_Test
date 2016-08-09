#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class Requerente
    {

        #region Atributos

        private OrgaoEmissor _orgaoEmissor;
        private Emissor _emissor;
        private Cidade _cidade;
        private string _telefoneAutoridade;
        private string _emailAutoridade;

        #endregion

        #region Propriedades

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

        public Cidade Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public string TelefoneAutoridade
        {
            get { return _telefoneAutoridade; }
            set { _telefoneAutoridade = value; }
        }

        public string EmailAutoridade
        {
            get { return _emailAutoridade; }
            set { _emailAutoridade = value; }
        }

        #endregion

    }
}