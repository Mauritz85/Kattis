#nullable enable
using System;
using System.Collections.Generic;

namespace Kattis.Problems
{
    public static class TakkFyrirMig
    {
        public static void Main()
        {
            int numberOfGuests = int.Parse(Console.ReadLine() ?? "1");

            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfGuests; i++)
            {
                string? guestName = Console.ReadLine() ?? "Noname";
                guests.Add(guestName ?? "");
            }

            foreach (string name in guests)
            {
                Console.WriteLine($"Takk {name}");
            }
        }
    }
}
