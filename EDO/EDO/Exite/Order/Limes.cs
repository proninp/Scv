using System.Xml.Serialization;

namespace EDO.Exite.Order
{
    //[ClassInterface(ClassInterfaceType.AutoDual)]
    //[ProgId("Pronin P.S.")]

    //[Serializable()]
    public class Limes
    {
        [XmlElement(Tags.LimesName)]
        public string limesName;                                        // optional
        [XmlElement(Tags.LimesDateFrom)]
        public string limesDateFrom;                                    // optional
        [XmlElement(Tags.LimesTimeFrom)]
        public string limesTimeFrom;                                    // optional
        [XmlElement(Tags.LimesDateTo)]
        public string limesDateTo;                                      // optional
        [XmlElement(Tags.LimesTimeTo)]
        public string limesTimeTo;
    }
}
