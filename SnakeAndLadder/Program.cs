using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int POSITION = 0;
            
            Random random = new Random();
            while (POSITION < 100)
                { 
            int DiceValue = random.Next(1, 6);
            int Choice = random.Next(0, 2);

                if (Choice == 0)
                    Console.WriteLine("No Play");
                else if (Choice == 1)
                {
                    POSITION += DiceValue;
                    Console.WriteLine("Ladder" + POSITION);

                }
                else
                {
                    POSITION -= DiceValue;
                    Console.WriteLine("Snake" + POSITION);
                }   
                }   

        }
    }
}
