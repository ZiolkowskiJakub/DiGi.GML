using DiGi.GML.CityGML.Interfaces;
using DiGi.GML.Interfaces;

namespace DiGi.GML.CityGML.Classes
{
    /// <summary>
    /// Represents a building object within the CityGML model, implementing city object member and abstract GML interfaces.
    /// </summary>
    public class Building : IcityObjectMember, IAbstractGML
    {
        /// <summary>
        /// Gets or sets the unique identifier for the building.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the numeric representation of the roof type for the building.
        /// </summary>
        public int roofType { get; set; }
    }
}
