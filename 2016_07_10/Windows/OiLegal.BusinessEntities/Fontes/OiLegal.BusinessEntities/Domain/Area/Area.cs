#region Using

using System;


#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Area
{
    [Serializable]
    public class Area
    {

        #region Atributos

        private int _idArea;
        private string _nomeArea;
        private int _qtdeLimiteUsers;
        private int _qtdeUsersOnline;

        #endregion

        #region Construtores

        #endregion

        #region Propriedades
        
        public int IdArea
        {
            get { return _idArea; }
            set { _idArea = value; }
        }

        public string NomeArea
        {
            get { return _nomeArea; }
            set { _nomeArea = value; }
        }

        public int QtdeLimiteUsers
        {
            get { return _qtdeLimiteUsers; }
            set { _qtdeLimiteUsers = value; }
        }

        public int QtdeUsersOnline
        {
            get { return _qtdeUsersOnline; }
            set { _qtdeUsersOnline = value; }
        }


        #endregion


        #region IEnumerableClass Members

        public string Text
        {
            get { return _nomeArea; }
            set { _nomeArea = value; }
        }

        public string Key
        {
            get { return _idArea.ToString(); }
            set { _idArea = Int32.Parse(value); }
        }

        #endregion

    }
}