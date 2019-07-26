using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

public class SumCommand : CommandBehavior{
    public SumCommand() : base(){
        comando = "!sum";
    }
    protected override async Task HandleCommandAsync(SocketMessage msg){
        if(msg == null) return;
        if(msg.Author.Id == client.CurrentUser.Id || msg.Author.IsBot) return;

        if(msg.Content.Length <= comando.Length) return;
        if(!msg.Content.Substring(0, comando.Length).Equals(comando)) return;
        if(msg.Content.Length > comando.Length && !msg.Content.Substring(0, comando.Length+1).Equals(comando+" ")) return;

        double total = 0;
        string[] str = msg.Content.Split(' ');
        string resp = "";

        if(str.Length < 3) return;

        for(int i = 1; i < str.Length; i++){
            resp += str[i] + " ";
            if(i < str.Length - 1) resp += "+ ";
            total += double.Parse(str[i]);
        }
        resp += "= " + total;

        await msg.Channel.SendMessageAsync(resp);

    }
}