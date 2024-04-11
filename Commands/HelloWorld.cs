using CommandLine;

namespace Please.Commands;

[Verb("greet", HelpText = "Greet someone.")]
public class HelloWorld : ICommand
{
    [Option('n', "name", Required = false, HelpText = "Name of the person to greet.")]
    public string? Name { get; init; }

    public Task ExecuteAsync(IDisplay display, CancellationToken cancellationToken)
    {
        var name = Name ?? "World";
        display.InfoLine($"Hello, {name}!");
        return Task.CompletedTask;
    }
}
