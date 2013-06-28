using System;
using Microsoft.AspNet.SignalR;

namespace Chat
{
    public class ChatHub : Hub
    {
        public void Send(string message)
        {
            Console.WriteLine("{0}", message);
            Clients.All.broadcastMessage(message);
        }
    }
}