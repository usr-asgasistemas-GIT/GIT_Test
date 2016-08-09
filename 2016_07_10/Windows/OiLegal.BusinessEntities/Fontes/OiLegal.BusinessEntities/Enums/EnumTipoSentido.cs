namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums
{

    /// <summary>
    /// Sentido da chamada.
    /// </summary>
    public enum TipoSentido
    {
        /// <summary>
        /// Quando é possível distinguir uma chamada como Efetuada
        /// </summary>
        Efetuada,
        /// <summary>
        /// Quando é possível distinguir uma chamada como Encaminhada
        /// </summary>
        Encaminhada,
        /// <summary>
        /// Quando é possível distinguir uma chamada como Recebida
        /// </summary>
        Recebida,
        /// <summary>
        /// Quando uma chamada não pode ser distinguida no CDR recebido pelo buscador entre Efetuada, Recebida ou Encaminhada
        /// </summary>
        Indefinida
    }

}
