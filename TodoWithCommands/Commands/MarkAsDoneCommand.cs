using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoWithCommands.Model;

namespace TodoWithCommands.Commands
{
    internal class MarkAsDoneCommand : Command
    {
        private readonly TodoManager _todo;
 
        public MarkAsDoneCommand(TodoManager todo)
            : base(3, "marker som utført")
        {
            _todo = todo;
        }

        public override void Run()
        {
            base.Run();
            var no = AskForInt("Hvilket nr vil du sette som utført? ");
            var index = no - 1;
            _todo.MarkAsDone(index);
        }
    }
}
