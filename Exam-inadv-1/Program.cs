using System;

namespace Exam_inadv_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int sleepoverCount = int.Parse(Console.ReadLine());
            int transportCards = int.Parse(Console.ReadLine());
            int museumTickets = int.Parse(Console.ReadLine());

            int sumSleepover = sleepoverCount * 20;
            double sumTransportCards = transportCards * 1.60;
            int sumMuseumTickets = museumTickets * 6;

            double allExpences = (sumSleepover + sumTransportCards + sumMuseumTickets)*peopleCount;
            double expencesWithAddedCost = allExpences + (allExpences * 0.25);

            Console.WriteLine($"{expencesWithAddedCost:f2}");

        }
    }
}
