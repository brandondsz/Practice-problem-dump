using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Ma9in(string[] args)
        {
            long t = long.Parse(Console.ReadLine());
            long[] inp = new long[t];
            for (long i = 0; i < t; i++)
            {
                inp[i] = long.Parse(Console.ReadLine());
            }
            long sum;
            for (long i = 0; i < t; i++)
            {
                sum = 0;
                for (long j = 1; j <= inp[i]; j++)
                {
                    if (!DivideOverflow(inp[i], j))
                    {
                        sum = 1 + inp[i] - j;
                        break;
                    }
                }
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }

        static bool DivideOverflow(long x, long y)
        {
            long quo = x / y;
            if ((Convert.ToString(quo, 2)).Length > Convert.ToString(y, 2).Length)
            {
                return true;
            }
            return false;
        }

        static int Happiness(IList<long> students)
        {
            int sum = 0;
            for (int i = 1; i < students.Count(); i++)
            {
                if (students[i] != -1)
                    for (int j = 0; j < i; j++)
                    {
                        if (students[j] > students[i])
                        {
                            sum++;
                        }
                    }
            }
            return sum;
        }

    }
}
