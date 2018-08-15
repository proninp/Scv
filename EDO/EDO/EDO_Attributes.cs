namespace EDO
{
    public class EDO_Attributes
    {
        #region FILE
        public const string SERVICE_INFO = "xmlns:xsi";
        public const string EL_DOC_PARTICIPANT = "ИдФайл"; // Имя файла
        public const string PROG_VERS = "ВерсПрог"; // Версия программы
        public const string FORMAT_VERS = "ВерсФорм"; // Версия формата
        public const string SERVICE_DOP_INFO = "xsi:noNamespaceSchemaLocation";

        #region PARTICIPANTS_INFO
        public const string SENDER_ID = "ИдОтпр"; // 2LD + GUID отправителя
        public const string BUYER_ID = "ИдПол"; // 2LD + GUID покупателя

        #region ELDOC_OPERATOR_INFO
        public const string OPERATOR_NAME = "НаимОрг"; // Наименование
        public const string OPERATOR_INN = "ИННЮЛ"; // ИНН
        public const string OPERATOR_EDO_ID = "ИдЭДО"; // Уникальный идентификатор ЭДО 
        #endregion

        #endregion

        #region DOCUMENT Документ
        public const string KND = "КНД"; // Код формы по коду налоговой декларации (КНД)
        /* 1. СЧФДОП - стандартный УПД
         * 2. ДОП - для ИНН не плательщиков НДС
         * 3. СЧФ - УПД СЧФ - магнолия/метро/Лента
         */
        public const string DOC_FUNC = "Функция";
        public const string DOC_FUNC_DESCR = "ПоФактХЖ"; // Документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг)
        /*
         * При Функция = "СЧФ" не формируется
         * При Функция = "СЧФДОП": Счет-фактура и документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг)
         * При Функция = "ДОП": Документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг)
         */
        public const string DOC_NAME_OPR = "НаимДокОпр";
        public const string DATE_INF_PR = "ДатаИнфПр"; // Дата формирования файла обмена счета-фактуры (информации продовца)
        public const string TIME_INF_PR = "ВремИнфПр"; // Время формирования файла обмена счета-фактуры (информации продовца)
        public const string FILE_CREATOR_NAME = "НаимЭконСубСост"; // Наименование экономического субъекта - составителя файла обмена счета-фактуры

        #region HEADER/HEADER_K СвСчФакт/СвКСчФ
        public const string SCHF_NO = "НомерСчФ"; // Поорядковый номер счета-фактуры
        public const string CSCHF_NO = "НомерКСчФ"; // Поорядковый номер корректировочного счета-фактуры
        public const string SCHF_DATE = "ДатаСчФ"; // Дата составления счета-фактуры
        public const string CSCHF_DATE = "ДатаКСчФ"; // Дата составления корректировочного счета-фактуры
        public const string CURRENCY_CODE = "КодОКВ"; // Код валюты

        #region ИспрСчФ
        public const string ISPR_SCHF_NO = "НомИспрСчФ"; // № исправления
        public const string ISPR_SCHF_DATE = "ДатаИспрСчФ"; // Дата исправления
        #endregion

        #region СвЮЛУч
        public const string ORG_NAME = "НаимОрг"; // Наименование организации
        public const string ORG_INN = "ИННЮЛ"; // ИНН организации
        public const string ORG_KPP = "КПП"; // КПП организации
        #endregion

        public const string OKPO = "ОКПО"; // ОКПО организации

        #region АдрРФ
        public const string POST_CODE = "Индекс"; // Индекс
        public const string REGION_CODE = "КодРегион"; // Код региона
        public const string CITY = "Город"; // Город
        public const string STREET = "Улица"; // Улица
        public const string BUILDING = "Дом"; // Дом
        #endregion

        #region Контакт
        public const string CONTACT_PHONE = "Тлф"; // Телефон
        #endregion

        #region БанкРекв
        public const string ACCOUNT_NO = "НомерСчета"; // Номер расч. счета

        #region СвБанк
        public const string BANK_NAME = "НаимБанк"; // Наименование банка
        public const string BANK_BIC = "БИК"; // БИК банка
        #endregion
        #endregion

        public const string OKVED_NAME = "НаимОКВ"; // атрибут ДопСвФХЖ1

        public const string ID_REC_FILE_INFO = "ИдФайлИнфПол"; // атрибут ИнфПолФХЖ1
        #region ТекстИнф
        public const string TEXT_INF_IDENTIF = "Идентиф"; // Идентификатор текстовой информации
        public const string TEXT_INF_VAL = "Значен"; // Значение текстовой информации
        #endregion
        #endregion СвСчФакт

        #region СведТов
        public const string LINE_NO = "НомСтр"; // Номер строки
        public const string ITEM_NAME = "НаимТов"; // Наименование товара
        public const string MEASURE_CODE = "ОКЕИ_Тов"; // Код единицы измерения
        public const string MEASURE_CODE_B = "ОКЕИ_ТовДо"; // Код единицы измерения до изменения
        public const string MEASURE_CODE_A = "ОКЕИ_ТовПосле"; // Код единицы измерения после изменения
        public const string QUANTITY = "КолТов"; // Количество (объем)
        public const string QUANTITY_B = "КолТовДо"; // Количество (объем) до изменения
        public const string QUANTITY_A = "КолТовПосле"; // Количество (объем) после изменения
        public const string UNIT_PRICE = "ЦенаТов"; // Цена единицы
        public const string UNIT_PRICE_B = "ЦенаТовДо"; // Цена единицы до изменения
        public const string UNIT_PRICE_A = "ЦенаТовПосле"; // Цена единицы после изменения
        public const string AMOUNT = "СтТовБезНДС"; // Общая сумма Без НДС
        public const string AMOUNT_INC_VAT = "СтТовУчНал"; // Общая сумма с НДС
        public const string VAT = "НалСт"; // % Ставка налога
        public const string VAT_B = "НалСтДо"; // % Ставка налога до изменения
        public const string VAT_A = "НалСтПосле"; // % Ставка налога после изменения

        #region ITEM_INFO_WITHOUT_VAT СтТовБезНДС
        public const string AMOUNT_B = "СтоимДоИзм"; // Стоимость до
        public const string AMOUNT_A = "СтоимПослеИзм"; // Стоимость после
        public const string AMOUNT_DEC = "СтоимУм"; // для СтТовУчНал УКД
        public const string AMOUNT_INC = "СтоимУвел"; // // для СтТовУчНал УКД
        #endregion

        #region ДопСведТов
        /*
         * Признак Товар/Работа/Услуга/Право/Иное
         * 1. - Имущество;
         * 2. - Работа;
         * 3. - Услуга;
         * 4. - Имущественные права;
         * 5. - Иное
         */
        public const string ITEM_TYPE = "ПрТовРаб";
        public const string ITEM_CODE = "КодТов"; // Характеристика/код/артикул/сорт товара (выполненных работ, оказанных услуг), переданных имущественных прав
        public const string ITEM_MEASURE_NAME = "НаимЕдИзм"; // Наименование единицы измерения
        #endregion
        #endregion

        #region ВсегоОпл
        public const string TOTAL_AMOUNT_WITHOUT_VAT = "СтТовБезНДСВсего"; // Стоимость всего без НДС
        public const string TOTAL_AMOUNT_WITH_VAT = "СтТовУчНалВсего"; // Стоимость всего включая НДС
        #endregion

        #region СвПер
        public const string OPERATION_CONTENT = "СодОпер"; // Содержание действий
        public const string TRANSFER_DATE = "ДатаПер"; // Дата передачи
        #endregion

        #region ОснПер
        public const string BASIS_NAME = "НаимОсн"; // Наименование основания
        public const string BASIS_NO = "НомОсн"; // Номер документа - основания
        public const string BASIS_DATE = "ДатаОсн"; // Дата документа основания
        public const string BASIS_ADDIT_INFO = "ДопСвОсн"; // Доп. сведения основания
        #endregion

        #region ПредОргПер
        public const string POSITION = "Должность";
        public const string FULL_TRANSFER_BASIS = "ОснПолнПредПер";
        public const string TRANSFER_ORG_NAME = "НаимОргПер";
        public const string TRANSFER_ORG_PROXY = "ОснДоверОргПер";
        #endregion

        #region ФИО
        public const string TRANSFER_PERSON_SURNAME = "Фамилия";
        public const string TRANSFER_PERSON_NAME = "Имя";
        public const string TRANSFER_PERSON_PATRONYMIC = "Отчество";
        #endregion

        #region ТранНакл
        public const string CONSIGNMENT_NO = "НомТранНакл"; // Номер ТТН
        public const string CONSIGNMENT_DATE = "ДатаТранНакл"; // Дата ТТН
        #endregion

        #region Подписант
        /*
         * 0 - лицо, ответственное за подписание сч. ф.;
         * 1 - лицо, совершившее сделку, операцию;
         * 2 - лицо, совершившее сделку, операцию и ответственное за ее оформление;
         * 3 - лицо, ответственно за оформление свершившегося события;
         * 4 - лицо, совершившее сделку, операцию и ответственное за подписание счетов-фактур;
         * 5 - лицо, совершившее сделку, операцию и ответственное за ее оформление и за подписание счетов-фактур;
         * 6 - лицо, ответственное за оформление свершившегося события и за подписание счетов-фактур.
         */
        public const string SIGNED_PERSON_AUTHORITY = "ОблПолн";
        /*
         * 1 - работник организации продавца товаров;
         * 2 - работник организации - составителя информации продавца;
         * 3 - работник иной уполномоченной организации;
         * 4 - уполномоченное физ. лицо (в т.ч. ИП).
         */
        public const string SIGNED_STATUS = "Статус";
        public const string BASE_AUTHORITY = "ОснПолн"; // Основание полномочий ("Должностные обязанности")
        #endregion

        #region SODFHD3 СодФХЖ3
        public const string DOC_NO_POSTDATE = "ПередатДокум"; // Но. и дата кор-го документа
        public const string CORR_OPER_CONTENT = "СодОпер"; // Исправление док. №
        #endregion

        #region ЮЛ
        public const string INN_UL = "ИННЮЛ"; // ИНН подписанта
        public const string POSITION_DESCR = "Должн"; // ФИО подписанта
        #endregion

        #endregion

        #endregion
    }
}
