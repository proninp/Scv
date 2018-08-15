namespace EDO
{
    public class EDO_Tags
    {
        public const string FILE = "Файл"; // Извещение о получении электронного документа

        public const string PARTICIPANTS_INFO = "СвУчДокОбор"; // Сведения об участниках электронного документооборота
        public const string ELDOC_OPERATOR_INFO = "СвОЭДОтпр"; // Сведения об операторе электронного документооборота
        public const string DOCUMENT = "Документ"; // Состав и структура документа
        public const string HEADER = "СвСчФакт"; // Сведения заголовка счета-фактуры
        public const string HEADER_C = "СвКСчФ"; // Сведения заголовка корректировочного счета-фактуры
        public const string HEADER_C_ORIG = "СчФ"; // № оригинальной СФ
        public const string ISPR_SCHF = "ИспрСчФ"; // № исправления
        public const string SELLER_INFO = "СвПрод"; // Сведения о продавце
        public const string IDENT_INFO = "ИдСв"; //Идентификационные сведения
        public const string ORG_INFO = "СвЮЛУч"; //Сведения об организации
        public const string ADDR = "Адрес"; // Адрес
        public const string ADDR_RF = "АдрРФ"; // Адрес в Российской Федерации
        public const string CONTACT = "Контакт"; // Контакт продавца
        public const string BANK_INFO = "БанкРекв"; // Номер банковского счета продавца
        public const string BANK_INFO_DATA = "СвБанк"; // Информация о банке продавца
        public const string CONSIGNOR = "ГрузОт"; // Грузоотправитель
        public const string SAME = "ОнЖе"; // Он же
        public const string CONSIGNEE = "ГрузПолуч"; // Грузополучатель
        public const string BUYER = "СвПокуп"; // Сведения об организации покупателя
        public const string ADD_INFO_FHD1 = "ДопСвФХЖ1";
        public const string HEADER_ADDIT_INFO = "ИнфПолФХЖ1"; // Информация о получателе
        public const string TEXT_INFO = "ТекстИнф"; // Информация о получателе текст
        public const string SCHF_TABLE = "ТаблСчФакт"; // Сведения таблицы счета-фактуры
        public const string SCHF_TABLE_C = "ТаблКСчФ"; // Сведения таблицы корректировочного счета-фактуры
        public const string ITEM_INFO = "СведТов"; // Сведения о товаре (работе, слуге)
        public const string ITEM_INFO_WITHOUT_VAT = "СтТовБезНДС"; // Для КСЧФ
        public const string EXCISE = "Акциз"; // Сумма акциза
        public const string EXCISE_B = "АкцизДо"; // Акциз До
        public const string EXCISE_A = "АкцизПосле"; // Акциз После
        public const string EXCISE_D = "АкцизРазн"; // Акциз разница
        public const string WITHOUT_EXCISE = "БезАкциз"; // В том числе сумма акциза
        public const string EXCISE_D_SUM = "СумУм"; // Сумма умножения
        public const string VAT_AMOUNT_DESCR = "СумНал"; // Сумма НДС
        public const string VAT_AMOUNT_DESCR_B = "СумНалДо"; // Сумма НДС до
        public const string VAT_AMOUNT_DESCR_A = "СумНалПосле"; // Сумма НДС после
        public const string VAT_AMOUNT_VAL = "СумНДС"; // Сумма НДС, предъявленная покупателю
        public const string VAT_AMOUNT_VAL_D = "СумНалРазн"; // Сумма НДС, разница
        public const string AMOUNT_INCL_VAT = "СтТовУчНал"; // Для УКД
        public const string LINES_ADDIT_INFO = "ИнфПолФХЖ2"; // Информация о получателе
        public const string ITEMS_ADDIT_INFO = "ДопСведТов"; // Доп. сведения о товаре
        public const string TOTAL_AMOUNT = "ВсегоОпл"; // Всего оплачено
        public const string TOTAL_AMOUNT_DEC = "ВсегоУм"; // Всего уменьшение (УКД)
        public const string TOTAL_AMOUNT_INC = "ВсегоОпл"; // Всего увеличение (УКД)
        public const string TOTAL_VAT_AMOUNT = "СумНалВсего";
        public const string TOTAL_NETTO = "НеттоВс";
        public const string SALE_INFO_DESCR = "СвПродПер";
        public const string TRANSFET_INFO = "СвПер"; // Сведения о передаче
        public const string TRANSFER_BASIS = "ОснПер"; // Наименование документа - основания
        public const string TRANSFER_PERSON_INFORMATION = "СвЛицПер";
        public const string OTHER_PERSON = "ИнЛицо";
        public const string TRANSFER_ORG_PERSON = "ПредОргПер";
        public const string TRANSFER_ORG_PERSON_FIO = "ФИО";
        public const string TRANS_CARGO = "ТранГруз";
        public const string CONSIGNMENT = "ТранНакл";
        public const string SODFHD3 = "СодФХЖ3"; // (УКД) Содержание события (ФХД)
        public const string CORRECTION_BASIS = "ОснКор"; // (УКД) Основания корректировки
        public const string SIGNED_PERSON = "Подписант";
        public const string LEGAL_ENTITY = "ЮЛ";
    }
}
