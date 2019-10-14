using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MatrixSum
    {
        //qwabaeraba   
        //qwabaereabawq
        //qwabaereabawq
        //adfsadfs
        //adfsadasfda
        //aaaacvbvddaaaa
        //aaaacvbvddvbvcaaaa
        //aaaaddvbvcvbvddaaaa
        //aaaaddcvbvcddaaaa
        //asdfdsaqweewq

        static void Main1(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //string[] rolls = Console.ReadLine().Split();
            //IEnumerable<int> numbers = Enumerable.Range(1, n);
            //var absent = numbers.Where(x => !rolls.Contains(x.ToString()));
            //foreach (var a in absent)
            //{ Console.Write($"{a}");
            //    if (a != absent.Last())
            //        Console.Write(" ");
            //    else
            //        Console.WriteLine("");
            //}

            string inp;
            int n, m;
            inp = Console.ReadLine();

            n = int.Parse(inp.Split(' ')[0]);
            m = int.Parse(inp.Split(' ')[1]);

            int[][] inputMatrix = new int[n][], sumMatrix = new int[n][];
            string[] inputArray = new string[m];
            for (int i = 0; i < n; i++)
            {
                inputArray = Console.ReadLine().Split(' ');
                inputMatrix[i] = new int[m];
                sumMatrix[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    inputMatrix[i][j] = int.Parse(inputArray[j]);

                    if (i == 0 && j == 0)
                    {
                        sumMatrix[0][0] = inputMatrix[0][0];
                    }

                    else if (i == 0)
                    {
                        sumMatrix[0][j] = sumMatrix[0][j - 1] + inputMatrix[0][j];
                    }
                    else if (j == 0)
                    {
                        sumMatrix[i][0] = sumMatrix[i - 1][0] + inputMatrix[i][0];
                    }
                    else
                    {
                        sumMatrix[i][j] = sumMatrix[i - 1][j] + sumMatrix[i][j - 1] - sumMatrix[i - 1][j - 1] + inputMatrix[i][j];
                    }
                }
            }
            int q = int.Parse(Console.ReadLine());
            int[][] qArray = new int[q][];
            for (int i = 0; i < q; i++)
            {
                inp = Console.ReadLine();
                qArray[i] = new int[2];
                qArray[i][0] = int.Parse(inp.Split(' ')[0]) - 1;
                qArray[i][1] = int.Parse(inp.Split(' ')[1]) - 1;

            }
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(inputMatrix[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine("Sum");

            for (int i = 0; i < q; i++)
            {

                Console.WriteLine(sumMatrix[qArray[i][0]][qArray[i][1]]);

            }
        }
    }
}
