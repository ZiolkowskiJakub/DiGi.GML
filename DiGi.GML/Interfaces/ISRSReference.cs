namespace DiGi.GML.Interfaces
{
    /// <summary>
    /// Defines the properties for a spatial reference system reference.
    /// </summary>
    public interface ISRSReference : ISRSInformation
    {
        /// <summary>
        /// Gets or sets the name of the spatial reference system.
        /// </summary>
        string? srsName { get; set; }

        /// <summary>
        /// Gets or sets the dimension of the spatial reference system.
        /// </summary>
        ushort? srsDimension { get; set; }
    }
}
