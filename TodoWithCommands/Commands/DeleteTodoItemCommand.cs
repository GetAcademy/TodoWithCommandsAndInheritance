﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoWithCommands.Model;

namespace TodoWithCommands.Commands
{
    internal class DeleteTodoItemCommand : ICommand
    {
        private readonly TodoManager _todo;
        public int No { get; } = 2;
        public string Description => $"{No} - slett";
        public DeleteTodoItemCommand(TodoManager todo)
        {
            _todo = todo;
        }

        public void Run()
        {
            Console.Write("Hvilket nr vil du slette? ");
            var noStr = Console.ReadLine();
            var no = Convert.ToInt32(noStr);
            var index = no - 1;
            _todo.Delete(index);
        }
    }
}
