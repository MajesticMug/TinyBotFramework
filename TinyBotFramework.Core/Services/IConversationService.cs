using System.Threading.Tasks;
using TinyBotFramework.Connector.Model.Routing;
using TinyBotFramework.Core.Model.Dialogs;

namespace TinyBotFramework.Core.Services
{
    public interface IConversationService
    {
        Task SendMessageToConversationAsync(Message message, IDialog<object> rootDialog);
    }
}