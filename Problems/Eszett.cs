#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis.Problems
{
    public static class Eszett
    {
        public static void Main()
        {
            string? input = Console.ReadLine() ?? "";
            string inputLower = input.ToLower();

            string firstOutput = inputLower;

            string secondOutput = inputLower.Replace("ss", "B");

            string reversedInputLower = ReverseString(inputLower);
            string reversedThirdOutput = reversedInputLower.Replace("ss", "B");
            string thirdOutput = ReverseString(reversedThirdOutput);

            Console.WriteLine(firstOutput);

            if (firstOutput != secondOutput)
            {
                Console.WriteLine(secondOutput);
            }
            ;
            if (secondOutput != thirdOutput)
            {
                Console.WriteLine(thirdOutput);
            }
            ;

        }
        private static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
