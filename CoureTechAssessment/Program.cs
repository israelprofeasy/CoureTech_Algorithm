using System;
using System.Linq;

namespace CoureTechAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var input1 = new int[5] { 1, 2, 3, 4, 5 };//Output: 11
            var input2 = new int[3] { 15, 25, 35 }; //Output: 9
            var input3 = new int[2] { 8, 8 };//Output: 12
            Console.WriteLine("First input total score: {0}", NumberScore(input1));
            Console.WriteLine("Second input total score: {0}", NumberScore(input2));
            Console.WriteLine("Third input total score: {0}", NumberScore(input3));

        }
        public static int NumberScore(int[] input)
        {
            if (input==null) return 0;
            int score = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    score += 1;
                }
                if(input[i]%2 != 0)
                {
                    score += 3;
                }
                if(input[i] == 8)
                {
                    score += 5;
                }

            }
            return score;
        }
    }
}
