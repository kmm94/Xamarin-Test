using System;
using WebSocket4Net;


namespace HWCP
{
    class WSConnection
    {

        WebSocket ws;

        public void connect()
        {
            Console.WriteLine("before connect");
            ws = new WebSocket("ws://kikuku.tk:8000/");
            ws.Opened += new EventHandler(websocket_Opened);
        }

  

        private void websocket_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Connectted");
            ws.Send("hello");
        }
    }
}
