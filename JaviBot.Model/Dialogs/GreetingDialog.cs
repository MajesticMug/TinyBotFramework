using System.Threading.Tasks;
using TinyBotFramework.Connector.Model.Routing;
using TinyBotFramework.Core.Model.Conversations;
using TinyBotFramework.Core.Model.Dialogs;

namespace JaviBot.Model.Dialogs
{
    public class GreetingDialog : IDialog<object>
    {
        public Task StartAsync(Message message, IDialogContext context, IConversationSession session)
        {
            return Task.CompletedTask;
        }

        public async Task<bool> MessageReceivedAsync(Message message, Conversation conversation)
        {
            if (message.Text == "gotoecho")
            {
                await conversation.Forward(message, new EchoDialog());
                return false;
            }

            await conversation.ReplyAsync("Hello? this is bot!");

            return true;
        }

        public Task EndAsync(Message message, IDialogContext context, IConversationSession session)
        {
            return Task.CompletedTask;
        }
    }
}