using System;

namespace Kattis.Problems
{
    public static class ASecondOpinion
    {
        public static void Main()
        {
            string? input = Console.ReadLine();
            int timeInput;

            if (input != null)
            {
                timeInput = int.Parse(input);
            }
            else
            {
                timeInput = 0;
            }
            int seconds = timeInput % 60;
            int minutes = timeInput / 60 % 60;
            int hours = timeInput / 60 / 60;

            Console.WriteLine($"{hours} : {minutes} : {seconds}");

        }
    }
}