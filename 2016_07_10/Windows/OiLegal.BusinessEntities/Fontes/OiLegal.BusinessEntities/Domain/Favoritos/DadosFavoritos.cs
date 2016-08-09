using System;
using System.Collections.Generic;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Favoritos
{
    [Serializable]
    public class DadosFavoritos
    {
        #region Atributos
        private List<FiltroFavoritos> _filtrosFavotitos;
        #endregion

        #region Propriedades
        public int? ID { get; set; }
        public string PageName { get; set; }
        public string FavoritoName { get; set; }
        public int IDUsuario { get; set; }
        public DateTime? DataHoraInclusao { get; set; }
        public List<FiltroFavoritos> ListaFiltrosFavoritos
        {
            get
            {
                if (_filtrosFavotitos == null)
                    _filtrosFavotitos = new List<FiltroFavoritos>();
                return _filtrosFavotitos;
            }
            set { _filtrosFavotitos = value; }
        }
        #endregion
    }
}
