using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NQueens
    {
        static bool IsAttacked(int[][] arr, int x, int y, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != x || j != y)
                    {
                        if (i == x && arr[x][j] == 1)
                            return true;

                        if (j == y && arr[i][y] == 1)
                            return true;

                        if ((i + j == x + y) && (arr[i][j] == 1))
                            return true;

                        if ((i - j == x - y) && (arr[i][j] == 1))
                            return true;
                    }
                }

            }
            return false;
        }
        static bool PlaceQueen(int[][] arr, int q, int n)
        {
            if (q == 0)
                return true;
            for (int i = n-q; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (!IsAttacked(arr, i, j, n))
                    {
                        arr[i][j] = 1;

                        if (PlaceQueen(arr, q - 1, n))
                            return true;
                        arr[i][j] = 0;
                    }
                }
                return false;
            }
            return false;

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    arr[i][j] = 0;
                }
            }
            if (PlaceQueen(arr, n, n))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }

}

