using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KeyServer
{
    class HttpServer
    {
        private HttpListener _listener;

        public HttpServer(string[] prefixes)
        {
            _listener = new HttpListener();
            foreach (var prefix in prefixes)
            {
                _listener.Prefixes.Add(prefix);
            }
        }

        public void Start()
        {
            _listener.Start();
            Console.WriteLine("Server is listening...");
            Task.Run(() => Listen());
        }

        private async Task Listen()
        {
            while (_listener.IsListening)
            {
                var context = await _listener.GetContextAsync();
                HandleRequest(context);
            }
        }

        private void HandleRequest(HttpListenerContext context)
        {
            string responseText = "";
            var request = context.Request;
            string path = request.Url.AbsolutePath;

            Console.WriteLine($"Received {request.HttpMethod} request for {path}");

            // Routing based on the endpoint (path)
            if (path == "/api/hello" && request.HttpMethod == "GET")
            {
                responseText = "Hi! KeyServer is online!";
            }
            else
            {
                responseText = "Endpoint not found";
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }

            // Send response
            var buffer = Encoding.UTF8.GetBytes(responseText);
            context.Response.ContentLength64 = buffer.Length;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.OutputStream.Close();
        }

        public void Stop()
        {
            _listener.Stop();
            _listener.Close();
        }
    }
}
