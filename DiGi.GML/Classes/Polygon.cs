using System.Collections.Generic;

namespace DiGi.GML.Classes
{
    public class Polygon : Surface
    {
        public LinearRing? exterior { get; set; }

        public List<LinearRing>? interior { get; set; }
    }
}
