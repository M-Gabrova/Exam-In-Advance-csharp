using System;

namespace Exam_inadv_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bestPlayer = "";
            int topScore = 0;
            string playerNames;
            while ((playerNames = Console.ReadLine()) != "END")
            {
                int currGoals = int.Parse(Console.ReadLine());
                if (currGoals > topScore)
                {
                    bestPlayer = playerNames;
                    topScore = currGoals;
                }

                if (topScore >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{bestPlayer} is the best player!");
            if (topScore >= 3)
            {
                Console.WriteLine($"He has scored {topScore} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {topScore} goals.");
            }
        }
    }
}