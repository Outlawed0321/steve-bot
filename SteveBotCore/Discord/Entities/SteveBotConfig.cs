using Discord.WebSocket;

namespace SteveBotCore.Discord.Entities
{
    class SteveBotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}
