using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NitishAndPillars
{
    class Class1
    {
        static void Main(string[] arg)
        {
            int bufSize = 1024000;
            Stream inStream = Console.OpenStandardInput(bufSize);
            Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize));

            int n = int.Parse(Console.ReadLine());
            long[] arr = new long[n];
            arr = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long q;
            if (arr.Count() > n) { q = arr[n]; }
            else { q = long.Parse(Console.ReadLine()); }

            for (long c = 0; c < q; c++)
            {
                string[] inp = Console.ReadLine().Split(' ');
                Console.WriteLine(GetVisibleCount(arr, long.Parse(inp[0]), long.Parse(inp[1])));
            }
        }

        static long GetVisibleCount(long[] arr, long i, long j)
        {
            long max = 0, count = 0;
            for (long x = i; x <= j; x++)
            {
                if (arr[x] > max)
                {
                    count++;
                    max = arr[x];
                }
            }
            return count;
        }
    }
}
