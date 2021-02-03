using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int POSITION_PLAYER_1 = 0;
            int FINAL_POSITION = 100;
            int POSITION_PLAYER_2 = 0;
            int NumberOfTimesDiceRolled = 0;
            
            Random random = new Random();
            int Turn = random.Next(0, 1);

            while (POSITION_PLAYER_1 < FINAL_POSITION)
            { 
            int DiceValue = random.Next(1, 6);
            int Choice = random.Next(0, 2);

                switch (Choice)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;

                    case 1:
                        POSITION_PLAYER_1 += DiceValue;
                        Console.WriteLine("Ladder" + POSITION_PLAYER_1);
                        if (POSITION_PLAYER_1 > 100)
                        {
                            POSITION_PLAYER_1 -= DiceValue;
                        }
                        break;

                    default:
                        POSITION_PLAYER_1 -= DiceValue;
                        Console.WriteLine("Snake" + POSITION_PLAYER_1);
                        if (POSITION_PLAYER_1 < 0)
                        {
                            POSITION_PLAYER_1 = 0;
                        }
                        break;
                }
                NumberOfTimesDiceRolled++;
                Console.WriteLine("Number of times dice rolled: " + NumberOfTimesDiceRolled);
            }   

        }
    }
}
