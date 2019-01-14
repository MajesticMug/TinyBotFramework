using System.Threading.Tasks;

namespace TinyBotFramework.Core.Services
{
    /// <summary>
    /// Service that sends messages from the bot to the user
    /// </summary>
    public interface IBotToUser
    {
        Task PostAsync(string text);
    }
}