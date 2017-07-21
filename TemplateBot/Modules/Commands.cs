using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TemplateBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("Ping")]
        public async Task Ping()
        {
            await Context.Channel.SendMessageAsync("Pong!");
        }

    }
}
