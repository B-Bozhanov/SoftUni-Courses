namespace WebServer.Server.Http
{
    using System.ComponentModel.DataAnnotations;

    using WebServer.Server.Http.Enums;

    using static Common.GlobalConstants.ExceptionsMesseges;
    using static Common.GlobalConstants.Separators;

    public class HttpRequest
    {
        public HttpMethod HttpMethod { get; init; }

        public string[] Path { get; init; }

        public Dictionary<string,string> Query { get; init; }

        public string HttpVersion { get; init; }

        public HttpHeaderCollection? Headers { get; private set; } 

        public string? Body { get; init; }


        public static HttpRequest Parse(string requestString)
        {
            var lines = requestString.Split(NewLine);

            var firstLine = lines[0].Split(Whitespace);

            if (!Enum.TryParse(firstLine[0], true, out HttpMethod method))
            {
                throw new InvalidOperationException(String.Format(NotSupportedMethod, method));
            }

            var url = firstLine[1];

            var httpVersion = firstLine[2];


            var urlParts = url.Split(QuestionMark);

            var path = urlParts[0].Split('/', StringSplitOptions.RemoveEmptyEntries);
            var queryParts = urlParts[1];

            var query = urlParts.Length > 1
                ? QueryParse(queryParts)
                : new Dictionary<string, string>();

            var headersText = lines.Skip(1).ToArray();

            var headerCollection = HeaderCollectionParse(headersText);

            var body = string.Join(string.Empty, lines.Skip(headerCollection.Count + 2));


            return new HttpRequest
            {
                HttpMethod = method,
                Path = path,
                Query = query,
                Headers = headerCollection,
                HttpVersion = httpVersion,
                Body = body
            };
        }

        private static Dictionary<string, string> QueryParse(string queryParts)
            =>  queryParts
                  .Split('&')
                  .Select(part => part.Split('='))
                  .Where(part => part.Length == 2)
                  .ToDictionary(key => key[0], value => value[1]);

        private static HttpHeaderCollection HeaderCollectionParse(string[] headersText)
        {
            var headerCollection = new HttpHeaderCollection();

            foreach (var headerText in headersText)
            {
                if (headerText == string.Empty)
                {
                    break;
                }

                var headerLine = headerText.Split(Colom, 2);

                if (headerLine.Length < 2)
                {
                    throw new InvalidOperationException(string.Format(InvalidHeader, headerLine[0]));
                }

                var headerName = headerLine[0].Trim();
                var headerValue = headerLine[1].Trim(); 

                headerCollection.Add(headerName, headerValue);
            }
            
            return headerCollection;
        }
    }
}
