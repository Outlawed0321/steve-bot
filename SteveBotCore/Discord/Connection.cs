using Discord.WebSocket;
using SteveBotCore.Discord.Entities;
using System.Threading.Tasks;

namespace SteveBotCore.Discord
{
    public class Connection
    {
        private DiscordSocketClient _client;
        private DiscordLogger _logger;

        public Connection(DiscordLogger logger)
        {
            _logger = logger;
        }

        internal async Task ConnectAsync(SteveBotConfig config)
        {
            _client = new DiscordSocketClient(config.SocketConfig);

            

            _client.Log += _logger.Log;

        }
    }
}
