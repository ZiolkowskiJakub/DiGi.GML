
//namespace DiGi.GML.Classes
//{
//    public class featureMember
//    {
//        private AbstractGML abstractGML;

//        public override bool Equals(object obj)
//        {
//            if (abstractGML == null)
//            {
//                if (obj == null)
//                {
//                    return true;
//                }

//                return false;
//            }

//            if (obj is featureMember)
//            {
//                return abstractGML == ((featureMember)obj).abstractGML;
//            }

//            return abstractGML.Equals(obj);
//        }

//        public override int GetHashCode()
//        {
//            if (abstractGML == null)
//            {
//                return base.GetHashCode();
//            }

//            return abstractGML.GetHashCode();
//        }

//        public override string ToString()
//        {
//            return abstractGML?.ToString();
//        }

//        public static implicit operator featureMember(AbstractGML abstractGML)
//        {
//            return new featureMember() { abstractGML = abstractGML };
//        }

//        public static implicit operator AbstractGML(featureMember featureMember)
//        {
//            return featureMember?.abstractGML;
//        }
//    }
//}
