using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

public class CommandBehavior{

    protected string comando { get; set; }
    protected string resposta { get; set; }
    protected DiscordSocketClient client { get; set; }

    public CommandBehavior(){
        this.client = CommandManager.client;
        client.MessageReceived += HandleCommandAsync;
    }

    protected virtual async Task HandleCommandAsync(SocketMessage msg){
        if(msg == null) return;
        if(msg.Author.Id == client.CurrentUser.Id || msg.Author.IsBot) return;
        if(!msg.Content.Equals(comando)) return;
        
        await msg.Channel.SendMessageAsync(resposta);
    }
}