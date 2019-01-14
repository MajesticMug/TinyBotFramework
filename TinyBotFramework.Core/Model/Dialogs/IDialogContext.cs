using System;
using System.Threading.Tasks;
using TinyBotFramework.Connector.Model.Routing;

namespace TinyBotFramework.Core.Model.Dialogs
{
    public interface IDialogContext
    {
        Task PostAsync(string text);
        Task Done();
        Task Wait(Func<Message, IDialogContext, IConversationSession, Task> messageReceivedAsync);
    }
}