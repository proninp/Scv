using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EDO.Exite.Order
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("Pronin P.S.")]

    [Serializable()]
    [System.Xml.Serialization.XmlRoot(Tags.Header)]
    public class Header
    {
        [System.Xml.Serialization.XmlElement(Tags.Supplier)]
        public string vendorGLN;
        [System.Xml.Serialization.XmlElement(Tags.BuyerGLN)]
        public string buyerGLN;
        [System.Xml.Serialization.XmlElement(Tags.BuyerCode)]
        public string buyerCode;                                          // optional
        [System.Xml.Serialization.XmlElement(Tags.DeliveryPlace)]
        public string deliveryPlace;                                       // optional
        [System.Xml.Serialization.XmlElement(Tags.FinalRecipient)]
        public string finalRecipient;                                      // optional
        [System.Xml.Serialization.XmlElement(Tags.InvoicePartner)]
        public string invoicePartner;                                      // optional
        [System.Xml.Serialization.XmlElement(Tags.SenderGLN)]
        public string senderGLN;
        [System.Xml.Serialization.XmlElement(Tags.RecipientGLN)]
        public string recipientGLN;
        [System.Xml.Serialization.XmlElement(Tags.RecipientCode)]
        public string recipientCode;                                       // optional
        [System.Xml.Serialization.XmlElement(Tags.RecipientName)]
        public string recipientName;                                       // optional
        [System.Xml.Serialization.XmlElement(Tags.RecipientContactFace)]
        public string recipientContactFace;                                // optional
        [System.Xml.Serialization.XmlElement(Tags.RecipientPhone)]
        public string recipientPhone;                                      // optional
        [System.Xml.Serialization.XmlElement(Tags.RecipientCity)]
        public string recipientCity;                                      // optional
        [System.Xml.Serialization.XmlElement(Tags.RecipientAddress)]
        public string recipientAddress;                                   // optional
        [System.Xml.Serialization.XmlElement(Tags.EdiEnterchangeId)]
        public string ediEnterchangeId;                                   // optional
        [System.Xml.Serialization.XmlElement(Tags.Position)]
        public List<Position> position;                                   // <POSITION>

        public int GetOrderLineCount() => position.Count;
        public Position GetOrderLine(int i) => position[i];
    }
}
