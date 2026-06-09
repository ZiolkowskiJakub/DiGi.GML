using System.Collections.Generic;

namespace DiGi.GML.Classes
{
    /// <summary>
    /// Represents a geometric point consisting of a sequence of coordinate values.
    /// </summary>
    public class Point : GeometricPrimitive
    {
        /// <summary>
        /// Gets or sets the list of coordinates representing the position of the point.
        /// </summary>
        public List<double> pos { get; set; } = [];
    }
}
