using SteveBotCore.Discord.Entities;
using SteveBotCore.Discord;
using System;
using System.Threading.Tasks;
using SteveBotCore.Storage;

namespace SteveBotCore
{
    internal class Program
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");
            var storage = Unity.Resolve<IDataStorage>();

            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new SteveBotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });
        }
    }

}
