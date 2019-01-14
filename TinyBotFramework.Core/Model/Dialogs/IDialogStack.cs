using System.Collections.Generic;

namespace TinyBotFramework.Core.Model.Dialogs
{
    public interface IDialogStack
    {
        IDialog<object> Pop();
        IDialog<object> Peek();
        void Push(IDialog<object> dialog);
        bool Any();
    }
}