using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.ProcessadorCDR;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa.Ipdr
{
    [Serializable]
    public class Visao
    {
        #region Atributos

        private int _id;
        private string _nome;
        private string _descricao;
        private int _idTipoCdr;
        private List<Campo> _lstcampos;
        

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

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public int IdTipoCDR
        {
            get { return _idTipoCdr; }
            set { _idTipoCdr = value; }
        }

        public List<Campo> LstCampos
        {
            get { return _lstcampos; }
            set { _lstcampos =  value; }
        }
        
        #endregion

        #region Construtor

        public Visao() { }
      
        public Visao(int pID, string pNome, string pDescricao, int pIdTipoCDR, List<Campo> pLstCampos)
        {
            _id = pID;          
            _nome = pNome;
            _descricao = pDescricao;
            _idTipoCdr = pIdTipoCDR;   
            _lstcampos = pLstCampos;
        }
        public Visao(int pID, string pNome, int pIdTipoCDR, string pDescricao)
        {
            _id = pID;
            _nome = pNome;
            _descricao = pDescricao;
            _idTipoCdr = pIdTipoCDR;   
        }

        public Visao(int pID, string pNome, string pDescricao)
        {
            _id = pID;
            _nome = pNome;
            _descricao = pDescricao;
            
        }
        public Visao(int pID, string pNome, int pIdTipoCDR, List<Campo> pLstCampos)
        {
            _id = pID;
            _nome = pNome;
            _idTipoCdr = pIdTipoCDR;   
            _lstcampos = pLstCampos;
        }

        #endregion
    }

    [Serializable]
    public class Campo
    {
        private int _id;
        private string _nome;

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

        public Campo() { }

        public Campo(int pID, string pNome)
        {
            _id = pID;
            _nome = pNome;              
        }
    }
}
