using System.Collections.Generic;

namespace DiGi.GML.Classes
{
    /// <summary>
    /// Represents a LinearRing, which is a closed boundary consisting of a linear sequence of points.
    /// </summary>
    public class LinearRing : Ring
    {
        /// <summary>
        /// Gets or sets the list of coordinate positions that define the linear ring.
        /// </summary>
        public List<double> posList { get; set; } = [];
    }
}
