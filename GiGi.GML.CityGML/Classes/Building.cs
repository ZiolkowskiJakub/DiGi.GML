using DiGi.GML.CityGML.Interfaces;
using DiGi.GML.Interfaces;

namespace DiGi.GML.CityGML.Classes
{
    public class Building : IcityObjectMember, IAbstractGML
    {
        public string id { get; set; }
        public int roofType { get; set; }
    }
}
