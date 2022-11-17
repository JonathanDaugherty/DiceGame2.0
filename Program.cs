using System;

namespace DiceGame2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerrandomNum;
            int enemyrandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();
            for (int  i = 0;  i < 10;  i++)
            {
               Console.WriteLine("Press any key to roll the dice:");

                Console.ReadKey();
                playerrandomNum = random.Next(1, 7);
                Console.WriteLine($"You rolled a {playerrandomNum}");

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyrandomNum = random.Next(1, 7);
                Console.WriteLine($"Enemy rolled a {enemyrandomNum}");

                if(playerrandomNum > enemyrandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round.");
                } else if(playerrandomNum < enemyrandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round.");
                } else
                {
                    Console.WriteLine("Draw.");
                }

                Console.WriteLine($"The current score is: Player = {playerPoints} to Enemy = {enemyPoints}");
            }
            Console.WriteLine("Final Score is:");
            Console.WriteLine($"Player: {playerPoints}");
            Console.WriteLine($"Enemy: {enemyPoints}");
            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("Player Wins!");
            } else if(enemyPoints > playerPoints)
            {
                Console.WriteLine("Enemy Wins");
            } else
            {
                Console.WriteLine("It was a draw!");
            }
            Console.ReadKey();
        }
    }
}
