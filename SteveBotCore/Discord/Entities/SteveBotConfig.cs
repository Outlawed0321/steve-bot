using Discord.WebSocket;

namespace SteveBotCore.Discord.Entities
{
    public class SteveBotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}
