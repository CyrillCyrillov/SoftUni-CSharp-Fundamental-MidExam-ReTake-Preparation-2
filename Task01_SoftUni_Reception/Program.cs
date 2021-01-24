using System;

namespace Task01_SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLimitPerHour = int.Parse(Console.ReadLine());
            int secondLimitPerHour = int.Parse(Console.ReadLine());
            int thithLimitPerHour = int.Parse(Console.ReadLine());

            int studentsPerHour = firstLimitPerHour + secondLimitPerHour + +thithLimitPerHour;

            int allStudents = int.Parse(Console.ReadLine());

            int neededHours = 0;

            while (allStudents > 0)
            {
                neededHours++;
                if(neededHours % 4 != 0)
                {
                    allStudents -= studentsPerHour;
                }
            }
            
            Console.WriteLine($"Time needed: {neededHours}h.");
        }
    }
}
