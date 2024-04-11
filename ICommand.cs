public interface ICommand
{
    Task ExecuteAsync(IDisplay display, CancellationToken cancellationToken);
}

