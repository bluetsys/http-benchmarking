using System;
using System.Net;
using System.IO;

int Port = 18012;
HttpListener _listener = new HttpListener();
_listener.Prefixes.Add("http://*:" + Port.ToString() + "/");
_listener.Start();

Receive();

    void Receive()
    {
        _listener.BeginGetContext(new AsyncCallback(ListenerCallback), _listener);
    }

    void ListenerCallback(IAsyncResult result)
    {
        if (_listener.IsListening)
        {
            var context = _listener.EndGetContext(result);
            var request = context.Request;

            // do something with the request
            Console.WriteLine($"{request.Url}");

            Receive();
        }
}