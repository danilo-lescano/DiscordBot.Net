using System;
using System.Reflection;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Discord.Commands;

class Program{
    private DiscordSocketClient client;

    public static void Main(string[] args){
        new Program().MainAsync().GetAwaiter().GetResult();
    }

    public async Task MainAsync(){
        client = new DiscordSocketClient();

        client.Log += Log;

        var token = "NjAzOTY1NjA4MzE2MzcwOTQ2.XTrnyQ.zkIAWtjvX4y3aNQ_T1uThSWQn4U";

        await client.LoginAsync(TokenType.Bot, token);
        await client.StartAsync();

        CommandManager.Start(client);

        Console.ReadKey(true);
    }

    private Task Log(LogMessage msg){
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;
    }

    private async Task HandleCommandAsync(SocketMessage msg){
        if (msg == null) return;
        if (msg.Author.Id == client.CurrentUser.Id || msg.Author.IsBot) return;
        if(!msg.Content.Equals("ping")) return;

        await msg.Channel.SendMessageAsync("pong");
        //do magic here
    }
}