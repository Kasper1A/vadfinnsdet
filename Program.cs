using Dapper;
using MySqlConnector;

internal class Program
{
    private static void Main(string[] args)
    {
        bool running = true;
        string? menuChoice = Console.ReadLine();
        var ingredientsList = new List<string>();
        while (running)
        {   
                    Console.Write("Username:\n" + Console.ReadLine());
                    Console.Write("password:" + Console.ReadLine());

            switch (menuChoice)
            {
            
                case "1":
                Console.Write("");
                    break;

                case "2":
                    Console.WriteLine("1. Ange ingredienser:");
                    break;

                case "3":
                    Console.WriteLine("1. Ange ingredienser:");
                    break;

                case "4":
                    Console.WriteLine("1. Ange ingredienser:");
                    break;

            }
        }
    }
}