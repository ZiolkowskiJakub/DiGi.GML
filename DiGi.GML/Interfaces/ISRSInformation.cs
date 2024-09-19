using System;
using System.Collections.Generic;
using System.Text;

namespace DiGi.GML.Interfaces
{
    public interface ISRSInformation
    {
        List<string>? axisLabels { get; set; }
        List<string>? uomLabels { get; set; }
    }
}
