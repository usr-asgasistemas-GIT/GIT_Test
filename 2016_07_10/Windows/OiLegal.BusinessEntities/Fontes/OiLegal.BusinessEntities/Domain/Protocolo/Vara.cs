#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class Vara : IEnumerableClass
    {

        #region Atributos

        private int _id;
        private string _descricao;
        private Comarca _comarca;

        #endregion

        #region Propriedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        
        public Comarca Comarca
        {
            get { return _comarca; }
            set { _comarca = value; }
        }

        #region IEnumerableClass Members

        public string Text
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public string Key
        {
            get { return _id.ToString(); }
            set { _id = Int32.Parse(value); }
        }

        #endregion
        
        #endregion

        #region Construtor

        public Vara() { }

        public Vara(int pID, string pDescricao, Comarca pComarca)
        {
            _id = pID;
            _descricao = pDescricao;
            _comarca = pComarca;
        }

        public Vara(string pDescricao, Comarca pComarca)
        {
            _descricao = pDescricao;
            _comarca = pComarca;
        }

        #endregion
       
    }
}