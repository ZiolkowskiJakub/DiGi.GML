using DiGi.GML.CityGML.Interfaces;
using System.Collections.Generic;

namespace DiGi.GML.CityGML.Classes
{
    public class CityModel : ICityGML
    {
        public List<IcityObjectMember> cityObjectMembers { get; set; }
    }
}
