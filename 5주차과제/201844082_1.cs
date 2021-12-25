using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 씨샵_5_1
{
    class Class1
    {
        static void Main(string[] args)
        {
            double[] scores = { 81.5, 71.0, 91 };
            int[,] test = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            foreach (double score in scores) { Console.WriteLine(score); }
            Array.Sort(scores);
            foreach (double score in scores) { Console.WriteLine(score); }

            int rank_a = scores.Rank;
            int rank_b = test.Rank;

            Console.WriteLine("{0} / {1}", rank_a, rank_b);

            int idx_a = Array.IndexOf(scores, 80);
            int idx_b = Array.IndexOf(scores, 91);
            Console.WriteLine(string.Format("{0} / {1}", idx_a, idx_b));

            Array.Clear(scores, 1, 2);
            foreach (var score in scores) { Console.WriteLine(score); }

            var row = test.GetLength(0);
            var col = test.GetLength(1);
            Console.WriteLine($"{row} / {col}");

            foreach(var t in test)
            {
                Console.Write("{0} ", t);
            }
            Console.WriteLine();

            for(int i = 0; i< test.GetLength(0); i++)
            {
                for (int j = 0; j<test.GetLength(1); j++)
                {
                    Console.Write("{0} ", test[i, j]);
                }
                Console.WriteLine();

            }
        }
    }
}
