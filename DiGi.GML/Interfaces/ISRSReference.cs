namespace DiGi.GML.Interfaces
{
    public interface ISRSReference : ISRSInformation
    {
        string? srsName { get; set; }
        ushort? srsDimension { get; set; }
    }
}
