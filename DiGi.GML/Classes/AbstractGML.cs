using DiGi.GML.Interfaces;

namespace DiGi.GML.Classes
{
    /// <summary>
    /// Represents the base abstract class for Geography Markup Language (GML) objects, providing common properties.
    /// </summary>
    public abstract class AbstractGML : IAbstractGML
    {
        /// <summary>
        /// Gets or sets the unique identifier for the GML object.
        /// </summary>
        public string? id { get; set; }
    }
}
