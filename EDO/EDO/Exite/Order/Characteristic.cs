using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EDO.Exite.Order
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("Pronin P.S.")]

    [Serializable()]
    [XmlRoot(Tags.Characteristic)]
    public class Characteristic
    {
        [XmlElement(Tags.ItemDescription)]
        public string ItemDescription { get; set; }
    }
}
