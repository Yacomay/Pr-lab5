using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Lab5_6_PR
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message, string connId)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.Client(connId).appendNewMessage(name, message);
        }
    }
}