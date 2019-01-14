using System.Threading.Tasks;
using TinyBotFramework.Connector.Model.Routing;
using TinyBotFramework.Core.Model.Dialogs;

namespace JaviBot.Domain.Model.Dialogs
{
    public class BaseDialog : IDialog<DialogResult>
    {
        public Task StartAsync(Message message, IDialogContext context, IDialogSession session)
        {
            throw new System.NotImplementedException();
        }

        public Task MessageReceivedAsync(Message message, IDialogContext context, IDialogSession session)
        {
            throw new System.NotImplementedException();
        }

        public Task EndAsync(Message message, IDialogContext context, IDialogSession session)
        {
            throw new System.NotImplementedException();
        }
    }
}