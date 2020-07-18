using System;
namespace NUMBER_GUESSING_GAME // Created by: Joshua C. Magoliman
{
    static class Title
    {
        public static void DrawInterface()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   ===========================================================================");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                               NUMBER GUESSING                                 ");
            Console.WriteLine("                                    GAME                                       ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   ===========================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                        Press enter to start the game.");
            var userPressed = Console.ReadKey();
            switch (userPressed.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear();
                    Game.StartNewGame();
                    break;
                default:
                    Console.Clear();
                    DrawInterface();
                    break;
            }
        }
    }
}