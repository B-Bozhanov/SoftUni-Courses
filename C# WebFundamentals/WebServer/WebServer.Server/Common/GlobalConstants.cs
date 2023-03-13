namespace WebServer.Server.Common
{
    public class GlobalConstants
    {
        public class ConnectionSettings
        {
            public const string DefaultIpAddress = "127.0.0.1";
            public const int DefaultPort = 8080;
        }

        public class ExceptionsMesseges
        {
            public const string NotSupportedMethod = "The method {0} is not supported !";
            public const string InvalidHeader = "Header {0} header is not valid !";
            public const string IsNullObject = "{0} can not be empty !";
        }

        public class ResponseInfo
        {
            public const string ServerHeaderName = "Server";
            public const string ServerName = "My Web Server";
            public const string DateHeaderName = "Date";
            public static string Date = DateTime.Now.ToString("R");
            public const string HttpHeaderName = "HTTP/";
            public const string HttpVersion = "1.1";
        }

        public class ServerMessages
        {
            public const string ServerStarted = "Server started on port {0}...";
            public const string RequestListen = "Listening for request...";
        }

        public class Separators
        {
            public const string NewLine = "\r\n";
            public const char Whitespace = ' ';
            public const char Colom = ':';
            public const char QuestionMark = '?';
        }
    }
}
