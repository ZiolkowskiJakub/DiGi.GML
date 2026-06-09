using DiGi.GML.CityGML.Interfaces;
using System.Collections.Generic;

namespace DiGi.GML.CityGML.Classes
{
    /// <summary>
    /// Represents a CityGML city model containing a collection of city object members.
    /// </summary>
    public class CityModel : ICityGML
    {
        /// <summary>
        /// Gets or sets the list of city object members associated with this city model.
        /// </summary>
        public List<IcityObjectMember> cityObjectMembers { get; set; }
    }
}
