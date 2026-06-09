using System.Collections.Generic;

namespace DiGi.GML.Classes
{
    /// <summary>
    /// Represents a GML Polygon, which is a surface defined by one exterior boundary and optional interior boundaries.
    /// </summary>
    public class Polygon : Surface
    {
        /// <summary>
        /// Gets or sets the exterior boundary of the polygon.
        /// </summary>
        public LinearRing? exterior { get; set; }

        /// <summary>
        /// Gets or sets the list of interior boundaries (holes) of the polygon.
        /// </summary>
        public List<LinearRing>? interior { get; set; }
    }
}
