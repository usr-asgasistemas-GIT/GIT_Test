using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa.Ipdr
{
    [Serializable]
    public class Bilhetador
    {
        #region Atributos

        private int _id;
        private string _sigla;
        private string _cn;        
        private string _uf;
        private string _tecnologia;
        private string _descricao;

        #endregion

        #region Propriedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Sigla
        {
            get { return _sigla; }
            set { _sigla = value; }
        }

        public string Cn
        {
            get { return _cn; }
            set { _cn = value; }
        }

        public string Uf
        {
            get { return _uf; }
            set { _uf = value; }
        }

        public string Tecnologia
        {
            get { return _tecnologia; }
            set { _tecnologia = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        #endregion

                  #region Construtor

        public Bilhetador() { }
      
        public Bilhetador(int pID, string pSigla ,string pCn, string pUf, string pTecnologia, string pDescricao)
        {
            _id = pID;
            _sigla = pSigla;
            _cn = pCn;
            _uf = pUf;
            _tecnologia = pTecnologia;
            _descricao = pDescricao;
        }
        public Bilhetador(int pID, string pSigla, string pCn, string pTecnologia)
        {
            _id = pID;
            _sigla = pSigla;
            _cn = pCn;            
            _tecnologia = pTecnologia;
            
        } 

        #endregion
    }
}
