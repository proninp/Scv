using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EDO.Exite.Order
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("Pronin P.S.")]

    [Serializable()]
    [XmlRoot(Tags.Order)]
    public class Order
    {
        [XmlElement(Tags.DocumentId)]
        public int DocumentId { get; set; }
        [XmlElement(Tags.DocumentNumber)]
        public string DocumentNo { get; set; }
        [XmlElement(Tags.DocumentDate)]
        public string DocumentDate { get; set; }
        [XmlElement(Tags.Promo)]
        public string Promo { get; set; } // optional
        [XmlElement(Tags.DeliveryDate)]
        public string DeliveryDate { get; set; }
        [XmlElement(Tags.DeliveryTime)]
        public string DeliveryTime { get; set; } // optional
        [XmlElement(Tags.ShipmentDate)]
        public string ShipmentDate { get; set; } // optional
        [XmlElement(Tags.AgreementNo)]
        public string AgreementNo { get; set; } // optional
        [XmlElement(Tags.Currency)]
        public string Currency { get; set; } // optional
        [XmlElement(Tags.TransportQuantity)]
        public int TransportQuantity { get; set; } // optional
        [XmlElement(Tags.TransportDetails)]
        public List<Limes> TransportDetails { get; set; } // <LIMES> all optional
        [XmlElement(Tags.VatPerc)]
        public string Vat { get; set; } // optional
        [XmlElement(Tags.TransportationTypes)]
        public string TransportationTypes { get; set; } // optional
        [XmlElement(Tags.TransportationMeans)]
        public string TransportationMeans { get; set; } // optional
        [XmlElement(Tags.TransportationPaymentType)]
        public string TransportationPaymentType { get; set; } // optional
        [XmlElement(Tags.TransportationRoute)]
        public string TransportationRoute { get; set; } // optional
        [XmlElement(Tags.BlanketOrderNumber)]
        public string BlanketOrderNumber { get; set; } // optional
        [XmlElement(Tags.InfoCoded)]
        public string InfoCoded { get; set; } // optional
        [XmlElement(Tags.DocType)]
        public string DocType { get; set; } // optional
        [XmlElement(Tags.SupOrder)]
        public string SupOrder { get; set; } // optional
        [XmlElement(Tags.KdkNum)]
        public string KdkNum { get; set; } // optional
        [XmlElement(Tags.OrderType)]
        public string OrderType { get; set; } // optional
        [XmlElement(Tags.SelfShipment)]
        public string SelfShipment { get; set; } // optional
        [XmlElement(Tags.PartialDelivery)]
        public string PartialDelivery { get; set; } // optional
        [XmlElement(Tags.Info)]
        public string Info { get; set; } // optional
        [XmlElement(Tags.Type)]
        public string ContentType { get; set; } // optional
        [XmlElement(Tags.EarliestDeliveryDate)]
        public string EarliestDeliveryDate { get; set; } // optional
        [XmlElement(Tags.ProductType)]
        public string ProductType { get; set; } // optional
        [XmlElement(Tags.LatestDeliveryDate)]
        public string LatestDeliveryDate { get; set; } // optional
        [XmlElement(Tags.PostingNo)]
        public string PostingNo { get; set; } // POSTINGNO
        [XmlElement(Tags.Header)]
        public Header Header { get; set; } // <HEAD>

        public int GetLimesCount() => TransportDetails.Count;

        public Limes GetLimesElement(int i) => TransportDetails[i];

        public void RemoveNullAttributes()
        {
            #region Order
            // <ORDER>
            if (DocumentNo == null) DocumentNo = "";
            if (DocumentDate == null) DocumentDate = "";
            else
            {
                DateTime dt = DateTime.ParseExact(DocumentDate + Param.ZERO_TIME, Param.DATE_FORMAT, System.Globalization.CultureInfo.InvariantCulture);
                DocumentDate = string.Format(Param.STRING_DATE_FORMAT, dt);
            }

            if (DeliveryDate == null) DeliveryDate = "";
            else
            {
                DateTime dt = DateTime.ParseExact(DeliveryDate + Param.ZERO_TIME, Param.DATE_FORMAT, System.Globalization.CultureInfo.InvariantCulture);
                DeliveryDate = string.Format(Param.STRING_DATE_FORMAT, dt);
            }

            if (Promo == null) Promo = "";
            if (DeliveryTime == null) DeliveryTime = "";
            if (ShipmentDate == null) ShipmentDate = "";
            else
            {
                DateTime dt = DateTime.ParseExact(ShipmentDate + Param.ZERO_TIME, Param.DATE_FORMAT, System.Globalization.CultureInfo.InvariantCulture);
                ShipmentDate = string.Format(Param.STRING_DATE_FORMAT, dt);
            }
            if (AgreementNo == null) AgreementNo = "";
            if (Currency == null) Currency = "";
            #region Limes
            // <LIMES>
            for (int i = 0; i < TransportDetails.Count; i++)
            {
                if (TransportDetails[i].limesName == null) TransportDetails[i].limesName = "";
                if (TransportDetails[i].limesDateFrom == null) TransportDetails[i].limesDateFrom = "";
                else
                {
                    DateTime dt = DateTime.ParseExact(TransportDetails[i].limesDateFrom + Param.ZERO_TIME, Param.DATE_FORMAT, System.Globalization.CultureInfo.InvariantCulture);
                    TransportDetails[i].limesDateFrom = string.Format(Param.STRING_DATE_FORMAT, dt);
                }
                if (TransportDetails[i].limesTimeFrom == null) TransportDetails[i].limesTimeFrom = "";
                if (TransportDetails[i].limesDateTo == null) TransportDetails[i].limesDateTo = "";
                else
                {
                    DateTime dt = DateTime.ParseExact(TransportDetails[i].limesDateTo + Param.ZERO_TIME, Param.DATE_FORMAT, System.Globalization.CultureInfo.InvariantCulture);
                    TransportDetails[i].limesDateTo = string.Format(Param.STRING_DATE_FORMAT, dt);
                }
                if (TransportDetails[i].limesTimeTo == null) TransportDetails[i].limesTimeTo = "";
            }
            // </LIMES>
            #endregion
            if (Vat == null) Vat = "";
            if (TransportationTypes == null) TransportationTypes = "";
            if (TransportationMeans == null) TransportationMeans = "";
            if (TransportationPaymentType == null) TransportationPaymentType = "";
            if (TransportationRoute == null) TransportationRoute = "";
            if (BlanketOrderNumber == null) BlanketOrderNumber = "";
            if (InfoCoded == null) InfoCoded = "";
            if (DocType == null) DocType = "";
            if (SupOrder == null) SupOrder = "";
            if (KdkNum == null) KdkNum = "";
            if (OrderType == null) OrderType = "";
            if (SelfShipment == null) SelfShipment = "";
            if (PartialDelivery == null) PartialDelivery = "";
            if (Info == null) Info = "";
            if (ContentType == null) ContentType = "";
            if (EarliestDeliveryDate == null) EarliestDeliveryDate = "";
            else
            {
                DateTime dt = DateTime.ParseExact(EarliestDeliveryDate + Param.ZERO_TIME, Param.DATE_FORMAT, System.Globalization.CultureInfo.InvariantCulture);
                EarliestDeliveryDate = string.Format(Param.STRING_DATE_FORMAT, dt);
            }
            if (ProductType == null) ProductType = "";
            if (LatestDeliveryDate == null) LatestDeliveryDate = "";
            else
            {
                DateTime dt = DateTime.ParseExact(LatestDeliveryDate + Param.ZERO_TIME, Param.DATE_FORMAT, System.Globalization.CultureInfo.InvariantCulture);
                LatestDeliveryDate = string.Format(Param.STRING_DATE_FORMAT, dt);
            }
            #region Head
            // <HEAD>
            if (Header.vendorGLN == null) Header.vendorGLN = "";
            if (Header.buyerGLN == null) Header.buyerGLN = "";
            if (Header.deliveryPlace == null) Header.deliveryPlace = "";
            if (Header.senderGLN == null) Header.senderGLN = "";
            if (Header.recipientGLN == null) Header.recipientGLN = "";
            if (Header.buyerCode == null) Header.buyerCode = "";
            if (Header.finalRecipient == null) Header.finalRecipient = "";
            if (Header.invoicePartner == null) Header.invoicePartner = "";
            if (Header.recipientCode == null) Header.recipientCode = "";
            if (Header.recipientName == null) Header.recipientName = "";
            if (Header.recipientContactFace == null) Header.recipientContactFace = "";
            if (Header.recipientPhone == null) Header.recipientPhone = "";
            if (Header.recipientCity == null) Header.recipientCity = "";
            if (Header.recipientAddress == null) Header.recipientAddress = "";
            if (Header.ediEnterchangeId == null) Header.ediEnterchangeId = "";
            #region Position
            // <POSITION>
            for (int i = 0; i < Header.position.Count; i++)
            {
                if (Header.position[i].Product == null) Header.position[i].Product = "";
                if (Header.position[i].ProductIdBuyer == null) Header.position[i].ProductIdBuyer = "";
                if (Header.position[i].OrderUnit == null) Header.position[i].OrderUnit = "";
                if (Header.position[i].ProductIdSupplier == null) Header.position[i].ProductIdSupplier = "";
                if (Header.position[i].BuyerPartNumber == null) Header.position[i].BuyerPartNumber = "";
                if (Header.position[i].ClaimedDeliveryDate == null) Header.position[i].ClaimedDeliveryDate = "";
                else
                {
                    DateTime dt = DateTime.ParseExact(Header.position[i].ClaimedDeliveryDate + Param.ZERO_TIME, Param.DATE_FORMAT, System.Globalization.CultureInfo.InvariantCulture);
                    Header.position[i].ClaimedDeliveryDate = string.Format(Param.STRING_DATE_FORMAT, dt);
                }
                if (Header.position[i].ClaimedDeliveryTime == null) Header.position[i].ClaimedDeliveryTime = "";
                if (Header.position[i].PosInfoCoded == null) Header.position[i].PosInfoCoded = "";
                if (Header.position[i].PosInfo == null) Header.position[i].PosInfo = "";
                if (Header.position[i].CompaigNumber == null) Header.position[i].CompaigNumber = "";
                if (Header.position[i].EarliestDeliveryDate == null) Header.position[i].EarliestDeliveryDate = "";
                else
                {
                    DateTime dt = DateTime.ParseExact(Header.position[i].EarliestDeliveryDate + Param.ZERO_TIME, Param.DATE_FORMAT, System.Globalization.CultureInfo.InvariantCulture);
                    Header.position[i].EarliestDeliveryDate = string.Format(Param.STRING_DATE_FORMAT, dt);
                }
                if (Header.position[i].PosLatestDeliveryDate == null) Header.position[i].PosLatestDeliveryDate = "";
                else
                {
                    DateTime dt = DateTime.ParseExact(Header.position[i].PosLatestDeliveryDate + Param.ZERO_TIME, Param.DATE_FORMAT, System.Globalization.CultureInfo.InvariantCulture);
                    Header.position[i].PosLatestDeliveryDate = string.Format(Param.STRING_DATE_FORMAT, dt);
                }
                if (Header.position[i].PosLatestDeliveryTime == null) Header.position[i].PosLatestDeliveryTime = "";
                if (Header.position[i].ConditionStatus == null) Header.position[i].ConditionStatus = "";
                #region Characteristic
                // <CHARACTERISTIC>
                for (int j = 0; j < Header.position[i].Characteristic.Count; j++)
                    if (Header.position[i].Characteristic[j].ItemDescription == null) Header.position[i].Characteristic[j].ItemDescription = "";
                // </CHARACTERISTIC>
                #endregion
            }
            // </POSITION>
            #endregion
            // </HEAD>
            #endregion
            // </ORDER>
            #endregion
        }
    }
}
