using TodoWithCommands.Model;

namespace TodoWithCommands.Commands
{
    internal class DeleteTodoItemCommand : Command
    {
        private readonly TodoManager _todo;

        public DeleteTodoItemCommand(TodoManager todo)
        : base(2, "slett")
        {
            _todo = todo;
        }

        public override void Run()
        {
            base.Run();
            var no= AskForInt("Hvilket nr vil du slette? ");
            var index = no - 1;
            _todo.Delete(index);
        }
    }
}
