using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program1
    {

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
            int[] students;
            inp = Console.ReadLine();

            students = inp.Split(' ').Select(x => int.Parse(x)).ToArray();

            Console.WriteLine(Happiness(students));
            var sadnessArray = students.Select((x, i) => SadnessCaused(students, i));
            int maxSad = sadnessArray.ToList().IndexOf(sadnessArray.Max());
            if (sadnessArray.Max() != sadnessArray.Min())
            {

                int t = students[maxSad];
                var x = students.ToList();
                x.RemoveAt(maxSad);
                x.Add(t);
                students = x.ToArray();
                //students[maxSad] = students.Last();
                //students[students.Count() - 1] = t;
            }

            Console.WriteLine(Happiness(students));

        }

        static int Happiness(int[] students)
        {
            int sum = 0, max = students[0];
            for (int i = 1; i < students.Count(); i++)
            {
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

        static int SadnessCaused(int[] students, int studentIndex)
        {
            int sum = 0;
            for (int i = studentIndex + 1; i < students.Count(); i++)
            {
                if (students[i] <= students[studentIndex])
                {
                    sum += 1;
                }
            }
            return sum;
        }
    }
}
