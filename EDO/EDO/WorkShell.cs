using System;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using EDO.Exite.Order;
using System.Xml;

namespace EDO
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("Pronin P.S.")]
    public class WorkShell
    {
        /// <summary>
        /// Creating Frp_Connection class exemplar
        /// </summary>
        /// <param name="userName">User name</param>
        /// <param name="password">Password</param>
        /// <param name="ftpPath">FTP Path</param>
        /// <param name="dwnldFlsPth">Path for downloading file</param>
        /// <returns>Ftp_Connection class exemplar</returns>
        public Ftp_Connection CreateConnection(string userName, string password, string dwnldFlsPth, string ftpInbox, string ftpOutbox)
        {
            if (userName.Length != 0 && password.Length != 0 && ftpInbox.Length != 0 && dwnldFlsPth.Length != 0 && ftpOutbox.Length != 0)
                return new Ftp_Connection(userName, password, dwnldFlsPth, ftpInbox, ftpOutbox);
            else if (userName.Length != 0 && password.Length != 0 && dwnldFlsPth.Length != 0 && ftpInbox.Length != 0 && ftpOutbox.Length == 0)
                return new Ftp_Connection(userName, password, dwnldFlsPth, ftpInbox);
            else if (userName.Length != 0 && password.Length != 0 && dwnldFlsPth.Length != 0 && ftpInbox.Length == 0 && ftpOutbox.Length == 0)
                return new Ftp_Connection(userName, password, dwnldFlsPth);
            else if (userName.Length != 0 && password.Length != 0 && dwnldFlsPth.Length == 0 && ftpInbox.Length == 0 && ftpOutbox.Length == 0)
                return new Ftp_Connection(userName, password);
            else if (userName.Length == 0 && password.Length == 0 && dwnldFlsPth.Length != 0 && ftpInbox.Length == 0 && ftpOutbox.Length == 0)
                return new Ftp_Connection(dwnldFlsPth);
            else return new Ftp_Connection();
        }

        /// <summary>
        /// Move file method
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <param name="dwnldFlsPth">Downloaded file's full name. Directory, where you want to download file + file name.</param>
        /// <param name="loadedFilesPath">Parsed file's path + parsed file name</param>
        /// <returns>Movement result (true/false)</returns>
        public bool MoveFile(string fileName, string dwnldFlsPth, string loadedFilesPath)
        {
            if (dwnldFlsPth.Equals("")) dwnldFlsPth = Param.NEW_EXITE_FILES;
            if (loadedFilesPath.Equals("")) loadedFilesPath = Param.LOADED_EXITE_ORDERS;
            if (File.Exists(dwnldFlsPth + fileName) && (Directory.Exists(loadedFilesPath)))
            {
                string newFileName = fileName;
                if (File.Exists(loadedFilesPath + newFileName))
                    newFileName = Path.GetFileNameWithoutExtension(newFileName) + "_" + DateTime.Now.ToString(Param.FILE_DATE_FORMAT) + Path.GetExtension(newFileName);
                File.Move(dwnldFlsPth + fileName, loadedFilesPath + newFileName);
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Receiving orders list method
        /// </summary>
        /// <param name="con">FTP-Connection class exemplar</param>
        /// <returns>OrderList class exemplar</returns>
        public OrderList GetOrderList(Ftp_Connection con, string searchFilesTemplate)
        {
            OrderList orderList = new OrderList();
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(con.FtpIn);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential(con.UserName, con.Password);
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line.Contains((searchFilesTemplate == "") ? Param.EXITE_ORDER_ID : searchFilesTemplate)) orderList.List.Add(line);
                }
            return orderList;
        }
        /// <summary>
        /// Receiving order from FTP by order file name
        /// </summary>
        /// <param name="con">Connection class exemplar</param>
        /// <param name="docName">document name file name
        /// Example: order_20180621124445_2212524051.xml</param>
        /// <returns>Is download complee succsessfully</returns>
        public bool DownloadFile(Ftp_Connection con, string docName, ref string exceptionText)
        {
            exceptionText = "";
            WebClient request = new WebClient();
            request.Credentials = new NetworkCredential(con.UserName, con.Password);
            try { request.DownloadFile(con.FtpIn + docName, con.DwnldFlsPth + docName); }
            catch (Exception ex)
            {
                exceptionText = ex.Message + " Не удалось записать файл " + con.FtpIn + docName + " по адресу " + con.DwnldFlsPth + docName + "!";
                return false;
            }
            request.Dispose();
            return true;
        }

        /// <summary>
        /// Receiving all orders from FTP by order list
        /// </summary>
        /// <param name="con">Connection class exemplar</param>
        /// <param name="list">Orders list</param>
        /// <param name="exceptionText">linked exception variable</param>
        /// <returns>Is download complee succsessfully</returns>
        public bool DownloadAllFiles(Ftp_Connection con, OrderList list, ref string exceptionText)
        {
            if (list.List.Count == 0) return true;
            exceptionText = "";
            WebClient request = new WebClient();
            request.Credentials = new NetworkCredential(con.UserName, con.Password);
            for (int i = 0; i < list.List.Count; i++)
            {
                string filename = list.GetListElement(i);
                try { request.DownloadFile(con.FtpIn + filename, con.DwnldFlsPth + filename); }
                catch (Exception ex)
                {
                    exceptionText = ex + "\nНе удалось записать файл " + con.FtpIn + filename + " по адресу " + con.DwnldFlsPth + filename + "!";
                    return false;
                }
            }
            request.Dispose();
            return true;
        }

        /// <summary>
        /// Order class exemplar parser from xml-file
        /// </summary>
        /// <param name="orderFilePath">Full order file name</param>
        /// <returns>Order class exemplar</returns>
        public Order ParseExiteOrder(string orderFilePath)
        {
            Order order = new Order();
            using (TextReader textReader = new StreamReader(orderFilePath))
                order = (Order)new XmlSerializer(typeof(Order)).Deserialize(textReader);
            return order;
        }

        /// <summary>
        /// Deleting file from ftp
        /// </summary>
        /// <param name="con">Connection class exemplar</param>
        /// <param name="fullFileName">Full file name (path + name) on FTP.
        /// Example: "ftp://ftpex.e-vo.ru/outbox/Test.xml"</param>
        /// <returns>Exception text.
        /// If there is no ex, will return an empty string.</returns>
        public bool DeleteFileFromFtp(Ftp_Connection con, string fullFileName, ref string exceptionText)
        {
            exceptionText = "";
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(fullFileName);
            request.Credentials = new NetworkCredential(con.UserName, con.Password);
            request.Method = WebRequestMethods.Ftp.DeleteFile;
            try { request.Method = WebRequestMethods.Ftp.DeleteFile; }
            catch (Exception ex) { exceptionText = "Ошибка!\n" + ex.Message + "\nНе удалось произвести удаление файла " + fullFileName; return false; }
            return true;
        }

        /// <summary>
        /// Uploading file to FTP
        /// </summary>
        /// <param name="con">Connection class exemplar</param>
        /// <param name="ftpPath">FTP path
        /// Example: "ftp://ftpex.e-vo.ru/outbox/"</param>
        /// <param name="fileName">Name of the uploading file
        /// Examole: Test.xml</param>
        /// <returns>Exception text
        /// If there is no ex, will return an empty string</returns>
        public bool UploadToFTP(Ftp_Connection con, string fileName, ref string exceptionText)
        {
            exceptionText = "";
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Credentials = new NetworkCredential(con.UserName, con.Password);
                    client.UploadFile(con.FtpOut + fileName, con.DwnldFlsPth + fileName);
                }
                catch (Exception ex) { exceptionText = ex.Message; return false; }
            }
            return true;
        }

        /// <summary>
        /// Changes FILE Tag Attributes values: 
        /// (1)ON_SCHFDOPPR_(2)2LD8A1A5B50-28FB-49CD-A074-6C1CB631A279_(3)2LD3A1FDFC4-272A-41D6-B550-23521D65EB71_(4)20171120_(5)151a78bf-9ada-5ef9-a6f0-21d3d491f5d7
        /// (6) - PROG_VERS Attribute
        /// </summary>
        /// <param name="file">full file path</param>
        /// <param name="docType">(1)</param>
        /// <param name="chainGuid">(2)</param>
        /// <param name="selfGuid">(3)</param>
        /// <param name="shipmentDate">(4)</param>
        /// <param name="transportGuid">(5)</param>
        /// <param name="progVersion">(6)</param>
        /// <returns></returns>
        public bool ReplFileAttrTxt(string file, string docType, string chainGuid, string selfGuid, string shipmentDate, string transportGuid, string progVersion, string edoId)
        {
            if (!File.Exists(file)) return false;
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            doc.SelectSingleNode("/" + EDO_Tags.FILE + "/@" + EDO_Attributes.EL_DOC_PARTICIPANT).Value = docType + "_" + chainGuid + "_" + selfGuid + "_" + shipmentDate + "_" + transportGuid;
            doc.SelectSingleNode("/" + EDO_Tags.FILE + "/@" + EDO_Attributes.PROG_VERS).Value = progVersion;
            doc.SelectSingleNode("/" + EDO_Tags.FILE + "/" + EDO_Tags.PARTICIPANTS_INFO + "/@" + EDO_Attributes.SENDER_ID).Value = selfGuid;
            doc.SelectSingleNode("/" + EDO_Tags.FILE + "/" + EDO_Tags.PARTICIPANTS_INFO + "/@" + EDO_Attributes.BUYER_ID).Value = chainGuid;
            doc.SelectSingleNode("/" + EDO_Tags.FILE + "/" + EDO_Tags.PARTICIPANTS_INFO + "/" + EDO_Tags.ELDOC_OPERATOR_INFO + "/@" + EDO_Attributes.OPERATOR_EDO_ID).Value = edoId;
            doc.Save(file);
            return true;
        }

        /// <summary>
        /// Save Order as XML File
        /// </summary>
        /// <param name="filename">Full file Path</param>
        /// <param name="order">Order class exemplar</param>
        /// <param name="exText">Exception description</param>
        /// <returns>true/false</returns>
        public bool SaveOrderXml(string filename, Order order, ref string exText)
        {
            exText = "";
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
                    new XmlSerializer(typeof(Order)).Serialize(fs, order);
                return true;
            }
            catch (Exception ex) { exText = ex.Message; return false; }
        }
    }
}