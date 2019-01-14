using System.Threading.Tasks;
using TinyBotFramework.Connector.Model.Routing;

namespace TinyBotFramework.Core.Services
{
    /// <summary>
    /// Service that sends messages from the bot to the user
    /// </summary>
    public interface IUserToBot
    {
        Task PostAsync(Message message);
    }
}