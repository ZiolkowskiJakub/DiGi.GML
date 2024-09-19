using DiGi.GML.Interfaces;
using System.Collections.Generic;

namespace DiGi.GML.Classes
{
    public abstract class Geometry : GML, ISRSReference
    {
        public string? srsName { get; set; }
        public ushort? srsDimension { get; set; }
        public List<string>? axisLabels { get; set; }
        public List<string>? uomLabels { get; set; }
    }
}
