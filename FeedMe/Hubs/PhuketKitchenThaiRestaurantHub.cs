using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using FeedMe.Hubs;

namespace FeedMe
{



    public class PhuketKitchenThaiRestaurantHub : Hub
    {
        private readonly static ConnectionMapping<string> _connections = new ConnectionMapping<string>();

        List<string> Customers = new List<string>();

        public void Send(string name, string message)
        {
    
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);

            Customers.Add(Context.ConnectionId);

            Clients.Client(Context.ConnectionId).broadcastMessage(name, "Thanks Man");

            var e = Context.ConnectionId;
        }

        public override Task OnConnected()
        {
            string name = Context.User.Identity.Name;

            _connections.Add(name, Context.ConnectionId);

            return base.OnConnected();
        }

        public override Task OnDisconnected()
        {
            string name = Context.User.Identity.Name;

            _connections.Remove(name, Context.ConnectionId);

            return base.OnDisconnected();
        }

        public override Task OnReconnected()
        {
            string name = Context.User.Identity.Name;

            if (!_connections.GetConnections(name).Contains(Context.ConnectionId))
            {
                _connections.Add(name, Context.ConnectionId);
            }

            return base.OnReconnected();
        }
    }
}