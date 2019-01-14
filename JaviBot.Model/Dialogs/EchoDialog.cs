using System.Threading.Tasks;
using TinyBotFramework.Connector.Model.Routing;
using TinyBotFramework.Core.Model.Conversations;
using TinyBotFramework.Core.Model.Dialogs;

namespace JaviBot.Model.Dialogs
{
    public class EchoDialog : IDialog<object>
    {
        public async Task<bool> MessageReceivedAsync(Message message, Conversation conversation)
        {
            if (message.Text == "end")
            {
                await conversation.ReplyAsync("Ok bye!");
                return true;
            }

            await conversation.ReplyAsync($"You said: {message.Text}");

            return false;
        }
    }
}