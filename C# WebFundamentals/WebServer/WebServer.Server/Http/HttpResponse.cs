namespace WebServer.Server.Http
{
    using System.Text;

    using WebServer.Server.Http.Enums;

    using static WebServer.Server.Common.GlobalConstants.ResponseInfo;

    public abstract class HttpResponse
    {
        public HttpResponse(HttpStatusCode statusCode)
        {
            this.HttpInfo = new Tuple<string, string>(HttpHeaderName, HttpVersion);
            this.Headers = new HttpHeaderCollection();

            this.HttpStatusCode = statusCode;

            this.Headers.Add(this.HttpInfo.Item1, this.HttpInfo.Item2);
            this.Headers.Add(ServerHeaderName, ServerName);
            this.Headers.Add(DateHeaderName, Date);
        }

        public Tuple<string, string> HttpInfo { get; set; } 

        public HttpStatusCode HttpStatusCode { get; init; }

        public HttpHeaderCollection Headers { get; private set; } 

        public string Content { get; init; }


        public override string ToString()
        {
            var responseMessage = new StringBuilder();

            responseMessage.AppendLine($"{this.HttpInfo.Item1}{this.HttpInfo.Item2} {(int)this.HttpStatusCode} {this.HttpStatusCode}");

            foreach (var header in this.Headers)
            {
                responseMessage.AppendLine($"{header.ToString()}");
            }

            responseMessage.AppendLine();

            if (!string.IsNullOrWhiteSpace(this.Content))
            {
                responseMessage.Append(this.Content);
            }

            return responseMessage.ToString();
        }
    }
}
