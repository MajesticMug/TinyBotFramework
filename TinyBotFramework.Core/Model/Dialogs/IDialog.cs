using System.Threading.Tasks;
using TinyBotFramework.Connector.Model.Routing;
using TinyBotFramework.Core.Model.Conversations;

namespace TinyBotFramework.Core.Model.Dialogs
{
    public interface IDialog<T>
    {
        /// returns a boolean indicating if the dialog has ended
        Task<bool> MessageReceivedAsync(Message message, Conversation conversation);
    }
}