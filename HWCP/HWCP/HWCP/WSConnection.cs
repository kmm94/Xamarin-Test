using System;
using SuperSocket.ClientEngine;
using WebSocket4Net;


namespace HWCP
{
    class WSConnection
    {

        WebSocket ws;

        public void connect()
        {
            Console.WriteLine("before WS");
            ws = new WebSocket("ws://kikuku.tk:8000/ws/chat");
            ws.Open();
            ws.Opened += new EventHandler(websocket_Opened);
            ws.Error += new EventHandler<SuperSocket.ClientEngine.ErrorEventArgs>(PrintError);
            Console.WriteLine("open");
        }

        private void PrintError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("ERROR ERROR ERROR ERROR ERROR ERROR ");
            Console.WriteLine(e);
        }

        private void websocket_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Connectted");
            ws.Send("hello");
        }
    }
}
