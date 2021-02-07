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
            int PlayerTurn = random.Next(0, 1);
            while (POSITION_PLAYER_1 != FINAL_POSITION && POSITION_PLAYER_2 != FINAL_POSITION)
            {
                if (PlayerTurn == 0)
                {

                    int DiceValuePlayer1 = random.Next(1, 6);
                    int Choice = random.Next(0, 3);

                    switch (Choice)
                    {
                        case 0:
                            Console.WriteLine("No Play");
                            break;

                        case 1:
                            POSITION_PLAYER_1 += DiceValuePlayer1;
                            Console.WriteLine("Ladder" + POSITION_PLAYER_1);
                            if (POSITION_PLAYER_1 > 100)
                            {
                                POSITION_PLAYER_1 -= DiceValuePlayer1;
                            }
                            break;

                        default:
                            POSITION_PLAYER_1 -= DiceValuePlayer1;
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

                else
                {
                    int DiceValuePlayer2 = random.Next(1, 6);
                    int Choice = random.Next(0, 2);
                    switch (Choice)
                    {
                        case 0:
                            Console.WriteLine("No Play");
                            break;

                        case 1:
                            POSITION_PLAYER_1 += DiceValuePlayer2;
                            Console.WriteLine("Ladder" + POSITION_PLAYER_1);
                            if (POSITION_PLAYER_1 > 100)
                            {
                                POSITION_PLAYER_1 -= DiceValuePlayer2;
                            }
                            break;

                        default:
                            POSITION_PLAYER_1 -= DiceValuePlayer2;
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
            if (POSITION_PLAYER_1 == FINAL_POSITION)
                Console.WriteLine("Player 1 wins");
            else
                Console.WriteLine("Player 2 wins");
        }
    }
}
