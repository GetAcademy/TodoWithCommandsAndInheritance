namespace TodoWithCommands.Commands
{
    internal interface ICommand
    {
        void Run();
        int No { get; }
        string Description { get; }
    }
}
