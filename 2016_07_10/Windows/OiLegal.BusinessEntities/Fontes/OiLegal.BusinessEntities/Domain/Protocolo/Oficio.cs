#region Using

using System;
using System.Collections.Generic;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class Oficio
    {

        #region Atributos

        private TipoDocumento _tipoDocumento;
        private string _numDocumento;
        private string _numCaso;
        private string _numProcesso;
        private string _numInquerito;
        private DateTime? _dataDocumento;
        private Cidade _cidade;
        private Vara _vara;
        private Emissor _emissor;
        private Origem _origem;
        private List<Empresa.Empresa> _empresas;
        private string _observacao;
        private string _parametro;
        private string _mensagem;
        private string _cargoMagistrado;
        private string _nomeMagistrado;

        #endregion

        #region Propriedades

        public string Mensagem
        {
            get { return _mensagem; }
            set { _mensagem = value; }
        }


        public TipoDocumento TipoDocumento
        {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; }
        }
        
        public string NumDocumento
        {
            get { return _numDocumento; }
            set { _numDocumento = value; }
        }

        public string NumCaso
        {
            get { return _numCaso; }
            set { _numCaso = value; }
        }
        
        public string NumProcesso
        {
            get { return _numProcesso; }
            set { _numProcesso = value; }
        }
        
        public string NumInquerito
        {
            get { return _numInquerito; }
            set { _numInquerito = value; }
        }
        
        public DateTime? DataDocumento
        {
            get { return _dataDocumento; }
            set { _dataDocumento = value; }
        }
        
        public Cidade Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        
        public Vara Vara
        {
            get { return _vara; }
            set { _vara = value; }
        }
        
        public Emissor Emissor
        {
            get { return _emissor; }
            set { _emissor = value; }
        }
        
        public Origem Origem
        {
            get { return _origem; }
            set { _origem = value; }
        }	

        public List<Empresa.Empresa> Empresas
        {
            get { return _empresas; }
            set { _empresas = value; }
        }

        public string Observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }

        public string Parametro
        {
            get { return _parametro; }
            set { _parametro = value; }
        }

        public string CargoMagistrado
        {
            get { return _cargoMagistrado; }
            set { _cargoMagistrado = value; }
        }

        public string NomeMagistrado
        {
            get { return _nomeMagistrado; }
            set { _nomeMagistrado = value; }
        }

        #endregion
       
    }
}