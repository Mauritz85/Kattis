using System;

namespace Kattis.Problems
{
    public static class Takk
    {
        public static void Main()
        {

            int numberOfGuests = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();


            for (int i = 0; i < numberOfGuests; i++)
            {
                string? name = Console.ReadLine();
                if (name != null)
                    guests.Add(name);
            }

            foreach (string name in guests)
            {
                Console.WriteLine("Takk " + name);
            }
        }
    }
}