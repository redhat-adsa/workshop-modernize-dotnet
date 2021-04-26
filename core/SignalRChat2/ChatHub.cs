using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat2
{
    public class ChatHub : Hub
    {
        public async Task Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.All.SendAsync("ReceivedMessage", name, message);
        }
    }
}