using System.Threading.Tasks;
using TinyBotFramework.Connector.Model.Routing;

namespace TinyBotFramework.Core.Services
{
    public class MemoryQueueUserToBot : IUserToBot
    {
        public Task PostAsync(Message message)
        {
            throw new System.NotImplementedException();
        }
    }
}