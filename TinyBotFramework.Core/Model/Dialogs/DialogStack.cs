using System.Collections.Generic;
using System.Linq;

namespace TinyBotFramework.Core.Model.Dialogs
{
    public class DialogStack : IDialogStack
    {
        private readonly Stack<IDialog<object>> _stack = new Stack<IDialog<object>>();

        public IDialog<object> Pop()
        {
            return _stack.Pop();
        }

        public IDialog<object> Peek()
        {
            return _stack.Peek();
        }

        public void Push(IDialog<object> dialog)
        {
            _stack.Push(dialog);
        }

        public bool Any()
        {
            return _stack.Any();
        }
    }
}