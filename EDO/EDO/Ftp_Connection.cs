using System.Runtime.InteropServices;

namespace EDO
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("Pronin P.S.")]
    public class Ftp_Connection
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DwnldFlsPth { get; set; }
        public string FtpIn { get; set; }
        public string FtpOut { get; set; }

        /// <summary>
        ///  Regular constructor with standard parameters
        /// </summary>
        public Ftp_Connection()
        {
            UserName = Param.EXITE_USER_NAME;
            Password = Param.EXITE_PASSWORD;
            DwnldFlsPth = Param.NEW_EXITE_FILES;
            FtpIn = Param.EXITE_FTP_INBOX;
            FtpOut = Param.EXITE_FTP_OUTBOX;
        }
        /// <summary>
        /// Constructor with username and password parameters only
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public Ftp_Connection(string username, string password)
        {
            UserName = username;
            Password = password;
            DwnldFlsPth = Param.NEW_EXITE_FILES;
            FtpIn = Param.EXITE_FTP_INBOX;
            FtpOut = Param.EXITE_FTP_OUTBOX;
        }
        /// <summary>
        /// Constructor with new files distanation path
        /// </summary>
        /// <param name="dwnldFlsPth"></param>
        public Ftp_Connection(string dwnldFlsPth)
        {
            UserName = Param.EXITE_USER_NAME;
            Password = Param.EXITE_PASSWORD;
            DwnldFlsPth = dwnldFlsPth;
            FtpIn = Param.EXITE_FTP_INBOX;
            FtpOut = Param.EXITE_FTP_OUTBOX;
        }
        /// <summary>
        /// Constructor without ftpOutboxPath
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param
        /// <param name="distanationPath"></param>
        /// <param name="ftpInboxPath"></param>
        /// <param name="ftpOutboxPath"></param>
        public Ftp_Connection(string userName, string password, string dwnldFlsPth, string ftpInbox)
        {
            UserName = userName;
            Password = password;
            DwnldFlsPth = dwnldFlsPth;
            FtpIn = (ftpInbox[ftpInbox.Length - 1] == '/') ? ftpInbox : ftpInbox + "/";
            FtpOut = Param.EXITE_FTP_OUTBOX;
        }
        /// <summary>
        /// Constructor without ftpInbox and ftpOutboxPath
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param
        /// <param name="distanationPath"></param>
        /// <param name="ftpInboxPath"></param>
        /// <param name="ftpOutboxPath"></param>
        public Ftp_Connection(string userName, string password, string dwnldFlsPth)
        {
            UserName = userName;
            Password = password;
            DwnldFlsPth = dwnldFlsPth;
            FtpIn = Param.EXITE_FTP_INBOX;
            FtpOut = Param.EXITE_FTP_OUTBOX;
        }

        /// <summary>
        /// Full constructor with all parameters
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param
        /// <param name="dwnldFlsPth"></param>
        /// <param name="ftpInboxPath"></param>
        /// <param name="ftpOutboxPath"></param>
        public Ftp_Connection(string userName, string password, string dwnldFlsPth, string ftpInbox, string ftpOutboxPath)
        {
            UserName = userName;
            Password = password;
            DwnldFlsPth = dwnldFlsPth;
            FtpIn = (ftpInbox[ftpInbox.Length - 1] == '/') ? ftpInbox : ftpInbox + "/";
            FtpOut = (ftpOutboxPath[ftpOutboxPath.Length - 1] == '/') ? ftpOutboxPath : ftpOutboxPath + "/";
        }
    }
}
