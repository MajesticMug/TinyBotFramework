using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyBotFramework.Connector.Model.Routing;
using TinyBotFramework.Core.Model.Dialogs;
using TinyBotFramework.Core.Services;

namespace TinyBotFramework.Core.Model.Conversations
{
    public class Conversation
    {
        private readonly IBotToUser _botToUser;

        public Conversation(IBotToUser botToUser)
        {
            _botToUser = botToUser;
        }

        public string ConversationId { get; set; }

        private readonly Stack<IDialog<object>> _dialogStack = new Stack<IDialog<object>>();
        
        public async Task SendAsync(Message message, Func<IDialog<object>> makeRootDialog)
        {
            if (!_dialogStack.Any())
            {
                _dialogStack.Push(makeRootDialog.Invoke());
            }

            await HandleMessageSendingAsync(message);
        }

        public async Task ReplyAsync(string text)
        {
            await _botToUser.PostAsync(text);
        }

        public async Task Forward(Message message, IDialog<object> destination)
        {
            _dialogStack.Push(destination);

            await HandleMessageSendingAsync(message);
        }

        private async Task HandleMessageSendingAsync(Message message)
        {
            IDialog<object> currentDialog = _dialogStack.Peek();

            bool dialogFinished = await currentDialog.MessageReceivedAsync(message, this);

            if (dialogFinished)
            {
                _dialogStack.Pop();
            }
        }
    }
}