using System;

namespace Exam_inadv_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;


            firstNum = n % 10;
            secondNum = (n / 10) % 10;
            thirdNum = n / 100;

            for (int first = 1; first <= firstNum; first++)
            {
                for (int second = 1; second <= secondNum; second++)
                {
                    for (int third = 1; third <= thirdNum; third++)
                    {
                        Console.WriteLine($"{first} * {second} * {third} = {first * second * third};");
                    }
                }
            }
        }
    }
}