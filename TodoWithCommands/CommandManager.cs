using TodoWithCommands.Commands;

namespace TodoWithCommands
{
    internal class CommandManager
    {
        public static Command? Find(string cmdNoStr, Command?[] commands)
        {
            var cmdNo = Convert.ToInt32(cmdNoStr);
            foreach (var command in commands)
            {
                if (command.No == cmdNo)
                {
                    return command;
                }
            }
            return null;
        }
    }
}
