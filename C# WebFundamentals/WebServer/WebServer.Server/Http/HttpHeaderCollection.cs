namespace WebServer.Server.Http
{
    using System.Collections;

    public class HttpHeaderCollection : IEnumerable<HttpHeader>
    {
        private readonly Dictionary<string, HttpHeader> headers;

        public HttpHeaderCollection()
        {
            this.headers = new();
        }

        public int Count => this.headers.Count;

        public void Add(string name, string value)
        {
            Validator.IsNull(name);
            Validator.IsNull(value);

            var header = new HttpHeader { Name = name, Value = value };

            this.headers.Add(name, header);
        }

        public IEnumerator<HttpHeader> GetEnumerator()
            => this.headers.Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}