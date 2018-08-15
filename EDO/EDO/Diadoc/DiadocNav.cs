using System;
using System.Runtime.InteropServices;

namespace EDO.Diadoc
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("Pronin P.S.")]
    public class DiadocNav
    {
        // Получение объекта типа Organization
        public DiadocComApiLib.Box GetBox(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        // Получение объекта типа DocumentEvent
        public DiadocComApiLib.BoxEvent GetBoxEvent(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        // Получение колличества элементов коллекции
        public Int32 GetCollectionlength(DiadocComApiLib.ValueCollection list) => Convert.ToInt32(list.Count);
        // Получение объекта типа Counteragent
        public DiadocComApiLib.CounteragentBox GetCounteragentBox(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        // Получение объекта типа CounteragentItem
        public DiadocComApiLib.CounteragentItem GetCounteragentItem(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        // Получение объекта типа Department
        public DiadocComApiLib.Department GetDepartment(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        // Получение объекта типа ExtendedSigner
        public DiadocComApiLib.ExtendedSigner GetExtendedSigner(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        // Получение объекта типа InvoiceForCorrectionInfo
        public DiadocComApiLib.InvoiceForCorrectionInfo GetInvoiceForCorrectionInfo(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        // Получение объекта типа InvoiceItem
        public DiadocComApiLib.InvoiceItem GetInvoiceItem(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        // Получение объекта типа OriginalInvoice
        public DiadocComApiLib.OriginalInvoice GetOriginalInvoice(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        // Получение объекта типа PaymentDocument
        public DiadocComApiLib.PaymentDocument GetPaymentDocument(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        // Получение объекта типа PersonalCertificate
        public DiadocComApiLib.CertificateInfo GetPersonalCertificate(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        // Получение объекта типа StructedAdditionalInfo
        public DiadocComApiLib.StructedAdditionalInfo GetStructedAdditionalInfo(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        // Получение объекта типа Document
        public DiadocComApiLib.DocumentBase GetDocumentBase(DiadocComApiLib.IValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));

        // Получение переменных примитивных типов + String и DateTime
        public Int32 GetIntElement(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        public Decimal GetDecimalElement(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        public DateTime GetDateElement(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        public String GetStringElement(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
        public Boolean GetBooleanElement(DiadocComApiLib.ValueCollection list, Int32 i) => list.GetItem(Convert.ToInt32(i));
    }
}