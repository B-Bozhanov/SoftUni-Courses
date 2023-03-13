namespace WebServer.Server
{
    using System.Net;
    using System.Net.Sockets;
    using System.Text;

    using WebServer.Server.Http;

    using static Common.GlobalConstants.ConnectionSettings;
    using static Common.GlobalConstants.ServerMessages;

    public class Server : IServer
    {
        private readonly IPAddress ipAddress;
        private readonly int port;
        private readonly TcpListener listener;

        public Server(string ipAddress = DefaultIpAddress, int port = DefaultPort)
        {
            this.ipAddress = IPAddress.Parse(DefaultIpAddress);
            this.port = DefaultPort;
            this.listener = new TcpListener(this.ipAddress, this.port);
        }

        public async Task Start()
        {
            this.listener.Start();

            Console.WriteLine(String.Format(ServerStarted, this.port));
            Console.WriteLine(String.Format(RequestListen));


            while (true)
            {
                var connection = await this.listener.AcceptTcpClientAsync();

                var networkStream = connection.GetStream();

                var requestString = GetRequest(networkStream).Result;

                Console.WriteLine(requestString);

                var request = HttpRequest.Parse(requestString);

                await this.WriteResponse(networkStream);

                connection.Close();
            }
        }

        private async Task<string> GetRequest(NetworkStream networkStream)
        {
            var bufferLength = 1024;
            var buffer = new byte[bufferLength];

            var requestBuilder = new StringBuilder();

            while (true)
            {
                var bytesRead = await networkStream.ReadAsync(buffer.AsMemory(0, bufferLength));

                requestBuilder.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));

                if (bytesRead < buffer.Length)
                {
                    break;
                }
            }

            return requestBuilder.ToString();
        }

        private async Task WriteResponse(NetworkStream networkStream)
        {
            var content = $@"
<html>
   <body>
       <h1>Hello from my web server!</h1>
   </body>
</html>";

            var contentLength = Encoding.UTF8.GetByteCount(content);

            var response = $@"
HTTP/1.1 200 OK
Server: My Web Server
Date: {DateTime.Now.ToString("r")} 
Content-Length: {contentLength}
Content-Type: text/html
Remote Address: {this.ipAddress}:{this.port}

{content}";

            var responseBytes = Encoding.UTF8.GetBytes(response);

            await networkStream.WriteAsync(responseBytes);
        }
    }
}
