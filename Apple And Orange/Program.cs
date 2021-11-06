//In 30 min

using System;

namespace Apple_And_Orange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apple = Array.ConvertAll(Console.ReadLine().Split(' '), appleTemp => Convert.ToInt32(appleTemp))
            ;

            int[] orange = Array.ConvertAll(Console.ReadLine().Split(' '), orangeTemp => Convert.ToInt32(orangeTemp))
            ;
            countApplesAndOranges(s, t, a, b, apple, orange);
        }

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int app = 0;
            int org = 0;
            for(int i = 0; i<apples.Length;i++)
            {
                int temp = apples[i] - a;
                if (temp >= s && temp <= t)
                    app++;
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                int temp = b - oranges[i];
                if (temp >= s && temp <= t)
                    org++;
            }

            Console.WriteLine(app + " " + org);
        }
    }
}
