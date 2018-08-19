using SteveBotCore.Discord.Entities;
using SteveBotCore.Discord;
using System;

namespace SteveBotCore
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");

            var discordBotConfig = new SteveBotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
        }
    }

}
