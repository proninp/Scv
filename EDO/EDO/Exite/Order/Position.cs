using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EDO.Exite.Order
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("Pronin P.S.")]

    [Serializable()]
    [XmlRoot(Tags.Position)]
    public class Position
    {
        [XmlElement(Tags.PositionNo)]
        public int PositionNo { get; set; }
        [XmlElement(Tags.Product)]
        public string Product { get; set; }
        [XmlElement(Tags.ProductIdSupplier)]
        public string ProductIdSupplier { get; set; } // optional
        [XmlElement(Tags.ProductIdBuyer)]
        public string ProductIdBuyer { get; set; }
        [XmlElement(Tags.BuyerPartNumber)]
        public string BuyerPartNumber { get; set; } // optional
        [XmlElement(Tags.OrderedQuantity)]
        public float OrderedQuantity { get; set; }
        [XmlElement(Tags.QuantityInPack)]
        public float QuantityInPack { get; set; } // optional
        [XmlElement(Tags.BoxesQuantity)]
        public float BoxesQuantity { get; set; } // optional
        [XmlElement(Tags.OrderUnit)]
        public string OrderUnit { get; set; }
        [XmlElement(Tags.OrderPrice)]
        public float OrderPrice { get; set; }
        [XmlElement(Tags.PriceWithVat)]
        public float PriceWithVat { get; set; } // optional
        [XmlElement(Tags.PosVatPerc)]
        public float PosVatPerc { get; set; } // optional
        [XmlElement(Tags.ClaimedDeliveryDate)]
        public string ClaimedDeliveryDate { get; set; } // optional
        [XmlElement(Tags.ClaimedDeliveryTime)]
        public string ClaimedDeliveryTime { get; set; } // optional
        [XmlElement(Tags.PosInfoCoded)]
        public string PosInfoCoded { get; set; } // optional
        [XmlElement(Tags.MinimumOrderedQuantity)]
        public float MinimumOrderedQuantity { get; set; } // optional
        [XmlElement(Tags.PosInfo)]
        public string PosInfo { get; set; } // optional
        [XmlElement(Tags.CompaigNumber)]
        public string CompaigNumber { get; set; } // optional
        [XmlElement(Tags.EarliestDeliveryDate)]
        public string EarliestDeliveryDate { get; set; } // optional
        [XmlElement(Tags.PosLatestDeliveryDate)]
        public string PosLatestDeliveryDate { get; set; } // optional
        [XmlElement(Tags.PosLatestDeliveryTime)]
        public string PosLatestDeliveryTime { get; set; } // optional
        [XmlElement(Tags.ConditionStatus)]
        public string ConditionStatus { get; set; } // optional
        [XmlElement(Tags.PackageID)]
        public string PackageID { get; set; } // optional
        [XmlElement(Tags.Characteristic)]
        public List<Characteristic> Characteristic { get; set; } // <CHARACTERISTIC>

        public int GetCharecteristicCount() => Characteristic.Count;

        public Characteristic GetChElement(int i) => Characteristic[i];
    }
}
