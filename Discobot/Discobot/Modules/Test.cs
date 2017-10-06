using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("Test")]
        public async Task tescik(String repeat)
        {
            await Context.Channel.SendMessageAsync(repeat);
        }
    }
}
