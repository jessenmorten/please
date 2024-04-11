using System.Reflection;
using CommandLine;

var commandTypes = Assembly
    .GetExecutingAssembly()
    .GetTypes()
    .Where(t => t.IsClass && t.IsAssignableTo(typeof(ICommand)))
    .ToArray();

var display = new Display();
var result = await Parser.Default
    .ParseArguments(args, commandTypes)
    .WithParsedAsync<ICommand>(command => command.ExecuteAsync(display, CancellationToken.None));
