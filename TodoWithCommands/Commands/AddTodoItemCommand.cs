﻿using TodoWithCommands.Model;

namespace TodoWithCommands.Commands
{
    internal class AddTodoItemCommand : ICommand
    {
        private readonly TodoManager _todo;
        public int No { get; } = 1;
        public string Description => $"{No} - legg til";

        public AddTodoItemCommand(TodoManager todo)
        {
            _todo = todo;
        }

        public void Run()
        {
            Console.WriteLine("Legg til");
            Console.Write("Hvor mange dager til fristen? ");
            var deadlineDaysStr = Console.ReadLine();
            var deadlineDays = Convert.ToInt32(deadlineDaysStr);
            Console.Write("Hva skal gjøres? ");
            var text = Console.ReadLine();
            var todoItem = new TodoItem(text, DateTime.Now.AddDays(deadlineDays));
            _todo.Add(todoItem);
        }
    }
}
