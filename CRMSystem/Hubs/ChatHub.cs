using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using CRMSystem.Domain;
using CRMSystem.Controllers;
namespace CRMSystem.Hubs
{
    public class ChatHub : Hub
    {
        public DataManager _dataManager { get; set; }
        public ChatHub(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        public async Task Send(string message, string userName, string requestId, string userId)
        {
            
            await Clients.All.SendAsync("Send", message, userName, requestId, userId);
            //разобраться с userId и name 
            _dataManager.Requests.SaveMessage(userName, message, requestId);
        }
    }
}