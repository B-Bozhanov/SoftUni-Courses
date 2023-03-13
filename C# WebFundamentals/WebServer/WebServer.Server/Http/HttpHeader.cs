namespace WebServer.Server.Http
{
    public class HttpHeader
    {
        public string? Name { get; init; }

        public string? Value { get; set; }

        public override string ToString()
            => $"{this.Name}: {this.Value}";
    }
}