using System.Threading.Tasks;
using TinyBotFramework.Connector.Model.Routing;

namespace TinyBotFramework.Connector.Services
{
    public class MemoryQueueBotToUser : IBotToUser
    {
        public Task PostAsync(Message message)
        {
            throw new System.NotImplementedException();
        }
    }
}