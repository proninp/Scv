namespace EDO.Exite.Order
{
    public class Tags
    {
        #region Order tags
        // <ORDER>
        public const string Order = "ORDER";
        public const string DocumentId = "DOCUMENTNAME";
        public const string DocumentNumber = "NUMBER";
        public const string DocumentDate = "DATE";
        public const string Promo = "PROMO";
        public const string DeliveryDate = "DELIVERYDATE";
        public const string DeliveryTime = "DELIVERYTIME";
        public const string ShipmentDate = "SHIPMENTDATE";
        public const string AgreementNo = "CAMPAIGNNUMBER";
        public const string Currency = "CURRENCY";
        public const string TransportQuantity = "TRANSPORTQUANTITY";
        #region Limes Tags
        // <LIMES>
        public const string TransportDetails = "LIMES";
        public const string LimesName = "LIMESNAME";
        public const string LimesDateFrom = "DATEFROM";
        public const string LimesTimeFrom = "TIMEFROM";
        public const string LimesDateTo = "DATETO";
        public const string LimesTimeTo = "TIMETO";
        // </LIMES>
        #endregion
        public const string VatPerc = "VAT";                                         // Ставка НДС заголовка
        public const string TransportationTypes = "TRANSPORTATIONTYPES";             // Вид транспортировки
        public const string TransportationMeans = "TRANSPORTATIONMEANS";             // Условия транспортировки
        public const string TransportationPaymentType = "TRANSPORTATIONPAYMENTTYPE"; // Условия транспортировки
        public const string TransportationRoute = "TRANSPORTATIONROUTE";             // Маршрут доставки
        public const string BlanketOrderNumber = "BLANKETORDERNUMBER";               // Маршрут доставки
        public const string InfoCoded = "INFOCODED";                                 // Инфокод
        public const string DocType = "DOCTYPE";                                     // Тип документа: O - оригинал; R - замена; D - удаление
        public const string SupOrder = "SUPORDER";                                   // Номер заказа поставщика
        public const string KdkNum = "KDKNUM";                                       // Номер общего заказа КДК
        public const string OrderType = "ORDERTYPE";                                 // Тип заказа: поле не передаётся - оригинал; 1 - корректировка; 2 - отмена
        // ** NOT IN SPEC
        public const string SelfShipment = "SELFSHIPMENT";                           // Нет в Спецификации
        public const string PartialDelivery = "PARTIALDELIVERY";                     // Нет в Спецификации
        // ***
        public const string Info = "INFO";                                           // Свободный текст
        public const string Type = "TYPE";                                           // 1 - оборудование; 2 - расходные материалы; 3 - оборудование и услуга
        public const string EarliestDeliveryDate = "EARLIESTDELIVERYDATE";           // Дата не раньше
        public const string ProductType = "PRODUCTTYPE";                             // 1 - оборудование; 2 - услуга
        public const string LatestDeliveryDate = "LATESTDELIVERYDATE";               // Дата не позднее
        #region Head Tags                                                            
        // <HEAD>
        public const string Header = "HEAD";                                         // 
        public const string Supplier = "SUPPLIER";                                   // GLN Постащика
        public const string BuyerGLN = "BUYER";                                      // GLN Покупателя (== отправитель сообщения)
        public const string BuyerCode = "BUYERCODE";                                 // Код покупателя
        public const string DeliveryPlace = "DELIVERYPLACE";                         // GLN места доставки
        public const string FinalRecipient = "FINALRECIPIENT";                       // GLN конечного консигнатора
        public const string InvoicePartner = "INVOICEPARTNER";                       // GLN плательщика
        public const string SenderGLN = "SENDER";                                    // Отправитель сообщения
        public const string RecipientGLN = "RECIPIENT";                              // Получатель сообщения (== поставщик)
        public const string RecipientCode = "RECIPIENTCODE";                         // Код получателя
        public const string RecipientName = "RECIPIENTNAME";                         // Имя получателя
        public const string RecipientContactFace = "RECIPIENTCONTACTFACE";           // Контактное лицо
        public const string RecipientPhone = "RECIPIENTPHONE";                       // Телефон получателя
        public const string RecipientCity = "RECIPIENTCITY";                         // Город получателя
        public const string RecipientAddress = "RECIPIENTADRESS";                    // Адрес получателя
        public const string EdiEnterchangeId = "EDIINTERCHANGEID";                   // Номер транзакции

        #region Position Tags
        // <POSITION>
        public const string Position = "POSITION";
        public const string PositionNo = "POSITIONNUMBER";
        public const string Product = "PRODUCT";                                     // Штрих-код товара
        public const string ProductIdSupplier = "PRODUCTIDSUPPLIER";                 // Внутренний штрих-код поставщика (может быть null)
        public const string ProductIdBuyer = "PRODUCTIDBUYER";                       // Штрих-код покупателя
        public const string BuyerPartNumber = "BUYERPARTNUMBER";                     // Внутренний системный номер в БД покупателя
        public const string OrderedQuantity = "ORDEREDQUANTITY";
        public const string QuantityInPack = "QUANTITYOFCUINTU";                     // Кол-во в упаковке
        public const string BoxesQuantity = "BOXESQUANTITY";                         // Кол-во упаковок
        public const string OrderUnit = "ORDERUNIT";                                 // Единицы измерения
        public const string OrderPrice = "ORDERPRICE";
        public const string PriceWithVat = "PRICEWITHVAT";
        public const string PosVatPerc = "VAT";                                      // Ставка НДС строки
        public const string ClaimedDeliveryDate = "CLAIMEDDELIVERYDATE";             // Объявленная дата доставки
        public const string ClaimedDeliveryTime = "CLAIMEDDELIVERYTIME";             // Объявленная время доставки
        public const string PosInfoCoded = "INFOCODED";                              // Объявленная время доставки
        public const string MinimumOrderedQuantity = "MINIMUMORDERQUANTITY";         // Минимальное заказанное кол-во
        public const string PosInfo = "INFO";                                        // Свободный текст
        public const string CompaigNumber = "COMPAIGNNUMBER";                        // Номер поставщика
        public const string PosEarliestDeliveryDate = "EARLIESTDELIVERYDATE";        // Поставка не раньше указанной даты
        public const string PosLatestDeliveryDate = "LATESTDELIVERYDATE";            // Поставка не позднее указанной даты
        public const string PosLatestDeliveryTime = "LATESTDELIVERYTIME";            // Поставка не позднее указанного времени
        public const string ConditionStatus = "CONDITIONSTATUS";                     // Статус кондиции
        public const string PackageID = "PACKAGEID";                                 // Идентификатор упаковки

        #region Characteristic Tags
        // <CHARACTERISTIC>
        public const string Characteristic = "CHARACTERISTIC";
        public const string ItemDescription = "DESCRIPTION";                         // Описание продукта
        //</CHARACTERISTIC>
        #endregion
        // </POSITION>
        #endregion
        // </HEAD>
        #endregion
        // </ORDER>
        #endregion

        #region Additional Tags
        public const string PostingNo = "POSTINGNO";                                 // Установка учетного номера в ТД для выгрузки на заводы
        #endregion

    }
}
