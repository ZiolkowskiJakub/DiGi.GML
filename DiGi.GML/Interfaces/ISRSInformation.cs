using System.Collections.Generic;

namespace DiGi.GML.Interfaces
{
    public interface ISRSInformation
    {
        List<string>? axisLabels { get; set; }
        List<string>? uomLabels { get; set; }
    }
}
