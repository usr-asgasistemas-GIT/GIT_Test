#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Usuario.Hierarquia
{
    [Serializable]
    public class Hierarquia
    {

        #region Atributos

        private int _id;
        private int _idPai;
        private int _idReal;
        private string _nome;
        private string _tipo;

        #endregion

        #region Construtores

        public Hierarquia() { }

        public Hierarquia(int pID, int pIdPai, int pIdReal, string pNome, string pTipo) {
            _id = pID;
            _idPai = pIdPai;
            _idReal = pIdReal;
            _nome = pNome;
            _tipo = pTipo;
        }

        #endregion

        #region Propriedades

        public int Id {
            get { return _id; }
            set { _id = value; }
        }

        public int IdPai {
            get { return _idPai; }
            set { _idPai = value; }
        }

        public int IdReal {
            get { return _idReal; }
            set { _idReal = value; }
        }

        public string Nome {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Tipo {
            get { return _tipo; }
            set { _tipo = value; }
        }

        #endregion

    }
}