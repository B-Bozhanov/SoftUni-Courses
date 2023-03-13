namespace WebServer.Server.Http
{
    using System.Text;

    using WebServer.Server.Http.Enums;


    public class HttpTextResponse : HttpResponse
    {
        public HttpTextResponse(string text)
            : base(HttpStatusCode.OK)
        {
            this.Headers.Add("Content-Type", "text/plain; charset=UTF-8");
            this.Headers.Add("Content-Length", Encoding.UTF8.GetByteCount(text).ToString());
        }
    }
}
