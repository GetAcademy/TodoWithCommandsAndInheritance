﻿using System.Text;

namespace TodoWithCommands.Model
{
    internal class TodoManager
    {
        private readonly List<TodoItem> _todoItems;

        public TodoManager()
        {
            _todoItems = new List<TodoItem>();
        }

        public void Add(TodoItem todoItem)
        {
            _todoItems.Add(todoItem);
        }

        public void Delete(int index)
        {
            _todoItems.RemoveAt(index);
        }

        public void MarkAsDone(int index)
        {
            _todoItems[index].MarkAsDone();
        }

        public string ListAsText()
        {
            var txt = new StringBuilder();
            txt.AppendLine("   Frist      Gjort       Tekst");
            for (var index = 0; index < _todoItems.Count; index++)
            {
                var todoItem = _todoItems[index];
                txt.AppendLine($"{index+1}: {todoItem.AsText()}");
            }

            return txt.ToString();
        }
    }
}
