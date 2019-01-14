using System;
using System.Threading.Tasks;
using JaviBot.Model.Dialogs;
using TinyBotFramework.Connector.Model.Routing;
using TinyBotFramework.Core.Model.Conversations;
using TinyBotFramework.Core.Services;

namespace ConsoleChat
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            var conversation = new Conversation(new ConsoleBotToUser());

            string input;

            while ( (input = Console.ReadLine()) != "exit" )
            {
                await conversation.SendAsync(new Message{Text = input}, 
                    () => new GreetingDialog());
            }
        }
    }


    public class ConsoleBotToUser : IBotToUser
    {
        public Task PostAsync(string text)
        {
            Console.WriteLine(text);

            return Task.CompletedTask;
        }
    }
}
