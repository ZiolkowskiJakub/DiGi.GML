namespace DiGi.GML.Interfaces
{
    /// <summary>
    /// Defines the basic structure for an abstract Geography Markup Language (GML) element, extending the feature member functionality.
    /// </summary>
    public interface IAbstractGML : IFeatureMember
    {
        /// <summary>
        /// Gets or sets the unique identifier of the GML element.
        /// </summary>
        string? id { get; set; }
    }
}
