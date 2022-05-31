using TodoWithCommands.Model;

namespace TodoWithCommands.Commands
{
    internal class AddTodoItemCommand : Command
    {
        private readonly TodoManager _todo;

        public AddTodoItemCommand(TodoManager todo)
            : base(1, "legg til")
        {
            _todo = todo;
        }

        public override void Run()
        {
            base.Run();
            var deadlineDays = AskForInt("Hvor mange dager til fristen? ");
            var text = AskForString("Hva skal gjøres? ");
            var todoItem = new TodoItem(text, DateTime.Now.AddDays(deadlineDays));
            _todo.Add(todoItem);
        }
    }
}
