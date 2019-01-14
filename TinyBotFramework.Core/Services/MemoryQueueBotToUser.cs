using System.Threading.Tasks;
using TinyBotFramework.Connector.Model.Routing;

namespace TinyBotFramework.Core.Services
{
    public class MemoryQueueBotToUser : IBotToUser
    {
        public Task PostAsync(string text)
        {
            throw new System.NotImplementedException();
        }
    }
}