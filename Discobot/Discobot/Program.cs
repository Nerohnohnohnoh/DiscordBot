using DiscoBot;
using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace Discobot
{
    public class Program
    {
        private DiscordSocketClient _client;
        private CommandHandler _handler;

        static void Main(string[] args)
            => new Program().StartAsync().GetAwaiter().GetResult();

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();
            await _client.LoginAsync(TokenType.Bot, "MzY1NjE1NTcxMzg0OTI2MjE5.DLkkig.dRLVM5wx99k3y8duxr1I5xL2UNk");
            await _client.StartAsync();
            _handler = new CommandHandler(_client);
            await Task.Delay(-1);


        }
    }
}
