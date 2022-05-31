namespace TodoWithCommands.Commands
{
    internal class Command
    {
        public int No { get; }
        public string Text { get; }
        public string Description => $"{No} - {Text}";

        public Command(int no, string text)
        {
            No = no;
            Text = text;
        }

        public virtual void Run()
        {
            Console.WriteLine("Du valgte:  " + Text);
        }

        protected static string? AskForString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        protected static int AskForInt(string question)
        {
            var answer = AskForString(question);
            return Convert.ToInt32(answer);
        }
    }
}
