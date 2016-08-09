#region Using

using System;
using System.Text;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class EmailSittel
    {

        
        #region Atributos

        private int _id;
        private string _nome;
        private string _email;
        

        #endregion

        #region Propriedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Nome_Email
        {
            get { return _nome + ";" + _email; }
            
        }

        #endregion

        #region Construtor

        public EmailSittel() { }

        public EmailSittel(int pId, string pNome, string pEmail)
        {
            _id = pId;
            _nome = pNome;
            _email = pEmail;            
        }

        public EmailSittel(string pNome, string pEmail)
        {            
            _nome = pNome;
            _email = pEmail;
        }

        

        #endregion

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
           
                s.Append(this.Nome.ToString());
                s.Append(";");
                s.Append(this.Email.ToString());
                s.Append(" ");

            return s.ToString();
        }

    }
}
