using DiGi.GML.Interfaces;
using System.Collections.Generic;

namespace DiGi.GML.Classes
{
    public class FeatureCollection : AbstractFeature
    {
        public List<IFeatureMember> featureMember { get; set; }
    }
}
