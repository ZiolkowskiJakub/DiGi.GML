using System.Collections.Generic;

namespace DiGi.GML.Interfaces
{
    /// <summary>
    /// Defines the structure for Spatial Reference System (SRS) information, 
    /// providing labels for axes and units of measure.
    /// </summary>
    public interface ISRSInformation
    {
        /// <summary>
        /// Gets or sets the list of labels identifying the axes of the coordinate reference system.
        /// </summary>
        List<string>? axisLabels { get; set; }

        /// <summary>
        /// Gets or sets the list of labels identifying the units of measure (UOM) for the coordinate reference system.
        /// </summary>
        List<string>? uomLabels { get; set; }
    }
}
