using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ATrystWithChess
{
    class Class1
    {
        static List<Tuple<int, int>> GetPossibleMoves(int i, int j, int count)
        {
            List<Tuple<int, int>> x = new List<Tuple<int, int>>();
            int[,] arr = new int[10, 2];
            if (IsValid(i - 1, j - 2))
            {
                x.Add(Tuple.Create(i - 1, j - 2));
                count++;
            }
            if (IsValid(i - 2, j - 1))
            {
                x.Add(Tuple.Create(i - 2, j - 1));
                count++;
            }
            if (IsValid(i - 2, j + 1))
            {
                x.Add(Tuple.Create(i - 2, j + 1));
                count++;
            }
            if (IsValid(i - 1, j + 2))
            {
                x.Add(Tuple.Create(i - 1, j + 2));
                count++;
            }
            if (IsValid(i + 1, j + 2))
            {
                x.Add(Tuple.Create(i + 1, j + 2));
                count++;
            }
            if (IsValid(i + 2, j + 1))
            {
                x.Add(Tuple.Create(i + 2, j + 1));
                count++;
            }
            if (IsValid(i + 2, j - 1))
            {
                x.Add(Tuple.Create(i + 2, j - 1));
                count++;
            }
            if (IsValid(i + 1, j - 2))
            {
                x.Add(Tuple.Create(i + 1, j - 2));
                count++;
            }
            return x;
        }

        static bool IsValid(int i, int j)
        {
            if ((i < 10) && (i >= 0) && (j < 10) && (j >= 0))
                return true;
            return false;
        }
        static void Main1(string[] arg)
        {
            int[] inp = (Console.ReadLine()).Split(' ').Select(x => int.Parse(x)).ToArray();

            var t = GetTotalMoves(inp[0], inp[1], inp[2],0);
            ;
            Console.WriteLine(t.Distinct().Count());
            Console.ReadLine();
        }

        static List<Tuple<int, int>> GetTotalMoves(int i, int j, int remainingMoves, int count)
        {
            if (remainingMoves == 1)
            {
                var finalTuple = GetPossibleMoves(i, j, count);
                return finalTuple;
            }

            var tupleList = GetPossibleMoves(i, j, count);
            List<Tuple<int, int>> sum = new List<Tuple<int, int>>();
            foreach (var t in tupleList)
            {
                sum.AddRange(GetTotalMoves(t.Item1, t.Item2, remainingMoves - 1, count));
            }

            return sum;
        }
    }
}
