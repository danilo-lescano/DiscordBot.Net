using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

public class PingCommand : CommandBehavior{
    public PingCommand() : base(){
        comando = "ping";
        resposta = "pong";
    }
}