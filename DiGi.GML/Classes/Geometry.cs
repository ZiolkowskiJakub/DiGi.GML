using DiGi.GML.Interfaces;
using System.Collections.Generic;

namespace DiGi.GML.Classes
{
    /// <summary>
    /// Represents a base abstract class for GML geometry objects, providing spatial reference system (SRS) information.
    /// </summary>
    public abstract class Geometry : GML, ISRSReference
    {
        /// <summary>
        /// Gets or sets the name of the Spatial Reference System used by this geometry.
        /// </summary>
        public string? srsName { get; set; }

        /// <summary>
        /// Gets or sets the dimension of the Spatial Reference System.
        /// </summary>
        public ushort? srsDimension { get; set; }

        /// <summary>
        /// Gets or sets a list of labels for the axes of the coordinate system.
        /// </summary>
        public List<string>? axisLabels { get; set; }

        /// <summary>
        /// Gets or sets a list of units of measure labels for the axes.
        /// </summary>
        public List<string>? uomLabels { get; set; }
    }
}
