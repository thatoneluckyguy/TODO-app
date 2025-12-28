using System;
using System.IO;

namespace TODO_app
{
    public class Todo
    {
        static string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public static string FullPath = Path.Combine(baseDirectory, "Todo.txt");
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to DailyTODO! choose a operation");
                Console.WriteLine("1--Add to list \n 2--show list \n 3--change \n 4--delete");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string STRChoise = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                int Choise;
                if (!int.TryParse(STRChoise, out Choise) && Choise > 4)
                {
                    Console.WriteLine("Incorrect input!");
                    continue;
                }

                switch (Choise)
                {
                    case 1:
                        Todo.Create();
                        break;
                    case 2:
                        Todo.Read();
                        break;
                }
            }
        }

        public static void Create()
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string WTodo = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            File.AppendAllText(FullPath, WTodo + Environment.NewLine);
        }

        public static void Read()
        {
            string[] read = File.ReadAllLines(FullPath);
            foreach (var item in read)
            {
                Console.WriteLine(item);
            }
        }

        public static void Update()
        {

        }

        public static void Delete()
        {

        }
    }
}
