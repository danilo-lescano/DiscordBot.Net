using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

public static class CommandManager{
    public static DiscordSocketClient client { get; set; }
    public static CommandBehavior[] commandList;

    public static void Start(DiscordSocketClient client){
        CommandManager.client = client;
        commandList = new CommandBehavior[]{
            new HelloCommand(),
            new PingCommand(),
            new HelpCommand(),
            new SumCommand()
        };
    }
}