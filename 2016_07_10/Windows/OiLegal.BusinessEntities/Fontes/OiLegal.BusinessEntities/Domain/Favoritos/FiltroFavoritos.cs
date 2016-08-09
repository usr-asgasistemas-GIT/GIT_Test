using System;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Favoritos;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Favoritos
{
    [Serializable]
    public class FiltroFavoritos
    {
        #region Atributos
        private DadosFavoritos _dadoFavorito;
        #endregion

        #region Propriedades
        public int? ID { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public FieldsTypes FieldType { get; set; }
        public DadosFavoritos DadoFavoritos
        {
            get
            {
                if (this._dadoFavorito == null)
                    this._dadoFavorito = new DadosFavoritos();
                return this._dadoFavorito;
            }
            set { this._dadoFavorito = value; }
        }
        #endregion
    }
}
