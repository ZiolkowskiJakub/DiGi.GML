using DiGi.GML.Interfaces;
using System.Collections.Generic;

namespace DiGi.GML.Classes
{
    /// <summary>
    /// Represents a collection of GML features, inheriting from the base abstract feature class.
    /// </summary>
    public class FeatureCollection : AbstractFeature
    {
        /// <summary>
        /// Gets or sets the list of feature members contained within this feature collection.
        /// </summary>
        public List<IFeatureMember> featureMember { get; set; } = [];
    }
}
