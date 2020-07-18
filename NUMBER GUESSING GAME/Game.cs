using System;
namespace NUMBER_GUESSING_GAME // Created by: Joshua C. Magoliman
{
    static class Game
    {
        public static void StartNewGame()
        {
            Random random = new Random();
            int numberToGuess = random.Next(0, 100);
            bool isPlayerWin = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Guess a number between 0 and 100: ");
                string stringUserGuess = Console.ReadLine();
                int integerUserGuess = int.Parse(stringUserGuess);
                if (integerUserGuess > numberToGuess)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("To high! Guess Lower!");
                }
                else if (integerUserGuess < numberToGuess)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("To low! Guess Higher!");
                }
                else if (integerUserGuess == numberToGuess)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You Win!");
                    isPlayerWin = true;
                }
            } while (isPlayerWin == false);
           
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thank you for playing this game!");
            Console.WriteLine("Press ENTER to restart the game or press ESC to exit the game.");
            var userPressed = Console.ReadKey();
            switch (userPressed.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear();
                    Game.StartNewGame();
                    break;
            }
        }

    }
}