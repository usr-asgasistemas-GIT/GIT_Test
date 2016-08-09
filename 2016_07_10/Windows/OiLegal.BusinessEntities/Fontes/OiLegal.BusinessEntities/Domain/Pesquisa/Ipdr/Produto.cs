using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa.Ipdr
{
    [Serializable]
    public class Produto
    {
         #region Atributos

        private int _id;
        private string _codigoProduto;
        private string _nome;                
        private string _tecnologia;
        private string _descricao;

        #endregion

        #region Propriedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string CodigoProduto
        {
            get { return _codigoProduto; }
            set { _codigoProduto = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
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

        public Produto() { }
      
        public Produto(int pID, string pCodigoProduto ,string pNome, string pTecnologia, string pDescricao)
        {
            _id = pID;
            _codigoProduto = pCodigoProduto;
            _nome = pNome;            
            _tecnologia = pTecnologia;
            _descricao = pDescricao;
        }
        public Produto(int pID, string pCodigoProduto, string pNome, string pTecnologia)
        {
            _id = pID;
            _codigoProduto = pCodigoProduto;
            _nome = pNome;            
            _tecnologia = pTecnologia;
            
        } 

        #endregion
    }
}
