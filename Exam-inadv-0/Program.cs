using System;

namespace Exam_inadv_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double quantity = 0;
            double degrees = 0;
            double sumQuantity = 0;
            double productDegrees = 0;
            double sumProductDegrees = 0;
            double averageDegrees = 0;
            for (int i = 1; i <= n; i++)
            {
                quantity = double.Parse(Console.ReadLine());
                degrees = double.Parse(Console.ReadLine());
                productDegrees = quantity * degrees;
                sumQuantity += quantity;
                sumProductDegrees += productDegrees;
            }
            averageDegrees = sumProductDegrees / sumQuantity;

            Console.WriteLine($"Liter: {sumQuantity:f2}");
            Console.WriteLine($"Degrees: {averageDegrees:f2}");

            if (averageDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (averageDegrees >= 38 && averageDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (averageDegrees > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
