using TodoWithCommands;
using TodoWithCommands.Commands;
using TodoWithCommands.Model;

var todo = new TodoManager();
var commands = new ICommand?[]
{
    new AddTodoItemCommand(todo),
    new DeleteTodoItemCommand(todo),
    new MarkAsDoneCommand(todo)
};

while (true)
{
    Console.Clear();
    Console.WriteLine("Todo:");
    Console.WriteLine(todo.ListAsText());
    Console.WriteLine("Kommandoer");
    foreach (var command in commands)
    {
        Console.WriteLine(command.Description);
    }

    var cmdNoStr = Console.ReadLine();
    var selectedCommand = CommandManager.Find(cmdNoStr, commands);
    if (selectedCommand != null)
    {
        selectedCommand.Run();
    }
    else
    {
        Console.WriteLine("Ukjent kommando: " + cmdNoStr);
    }
}

