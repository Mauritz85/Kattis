#nullable enable
using System;
using System.Collections.Generic;

namespace Kattis.Problems
{
    public static class AirfareGrants
    {
        public static void Main()
        {
            int numberOfFlights = int.Parse(Console.ReadLine() ?? "1");

            List<int> flightPrices = new List<int>();

            for (int i = 0; i < numberOfFlights; i++)
            {
                int flightPrice = int.Parse(Console.ReadLine() ?? "10");
                flightPrices.Add(flightPrice);
            }

            int lowestFlightprice = flightPrices[0];
            int highestFlightprice = flightPrices[0];

            foreach (int flightPrice in flightPrices)
            {
                if (flightPrice < lowestFlightprice)
                {
                    lowestFlightprice = flightPrice;
                }

                if (flightPrice > highestFlightprice)
                {
                    highestFlightprice = flightPrice;
                }
            }

            int leftOver = lowestFlightprice - highestFlightprice / 2;

            if (leftOver > 0)
            {
                Console.WriteLine(leftOver);
            }
            else { Console.WriteLine(0); }
        }
    }
}
