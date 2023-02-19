using System;

namespace Exam_inadv_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysGone = int.Parse(Console.ReadLine());
            int kilosFoodLeft = int.Parse(Console.ReadLine());
            double deerOnefoodInkilos = double.Parse(Console.ReadLine());
            double deerTwofoodInkilos = double.Parse(Console.ReadLine());
            double deerThreefoodInkilos = double.Parse(Console.ReadLine());

            double foodDeerOne = deerOnefoodInkilos * daysGone;
            double foodDeerTwo = deerTwofoodInkilos * daysGone;
            double foodDeerThree = deerThreefoodInkilos * daysGone;

            double sumFood = foodDeerOne+foodDeerTwo+foodDeerThree;
            double diff = Math.Abs(kilosFoodLeft - sumFood);

            if (kilosFoodLeft >= sumFood)
            {
                Console.WriteLine($"{Math.Floor(diff)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(diff)} more kilos of food are needed.");
            }



        }

    }
}
