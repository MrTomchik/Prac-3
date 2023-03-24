namespace Zadanie3
{
    class SQLCommand
    {
        private string commandText;
        public SQLCommand(string commantText)
        {
            this.commandText = commantText;
            SQLToUpper();
        }

        public void SQLToUpper()
        {
            string[] SQLCommand = commandText.Split(' ');
            for (int i = 0; i < SQLCommand.Length; i++)
            {
                if (SQLCommand[i] == "insert" || SQLCommand[i] == "into" || SQLCommand[i] == "values")
                {
                    SQLCommand[i] = SQLCommand[i].ToUpper();
                }
            }
            string output = string.Join(" ", SQLCommand);
            Console.WriteLine(output);

        }

        internal class Program
        {
            static void Main(string[] args)
            {
                SQLCommand newSQLCommand = new SQLCommand("insert into orders (id, ProductName, Manufacturer, ProductCount, Price) values (1, '11', '111', 1111, 11111)");
            }
        }
    }
}