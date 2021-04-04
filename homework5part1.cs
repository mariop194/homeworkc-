using System;

namespace DateTimeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework 5");


            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);

            DateTime addedYears = currentDate.AddYears(10);
            Console.WriteLine(addedYears);

            string dateFormat1 = currentDate.ToString("MM/dd/yyyy");

            DateTime removedDays = currentDate.AddDays(-15);
            DateTime removedMonths = currentDate.AddMonths(-2);
            Console.WriteLine(removedDays);
            Console.WriteLine(removedMonths);



            Console.ReadLine();
        }
    }
}
