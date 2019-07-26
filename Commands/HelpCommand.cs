using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

public class HelpCommand : CommandBehavior{
    public HelpCommand() : base(){
        comando = "!help";
        resposta = "Tem 3 comandos: !help, ping, !Hello";
    }
}