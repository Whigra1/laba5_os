using System;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            Old();
            New();
            New2();
        }

        static void Old()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[] a = new int[2];
            int res = 0;

            for (int j = 0; j < 10000000; j++)
            {
                a[0]++;
                a[0]++;
            }

            a[1] = a[0];

            Console.WriteLine($"Res Old func: {a[0]}");
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Old func exec in {elapsedMs} ms.");
        }

        static void New() {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[] a = new int[2];
            int res = 0;

            for (int j = 0; j < 10000000; j++)
            {
                a[0]+=2;
            }

            a[1] = a[0];
            watch.Stop();
            Console.WriteLine($"Res New func: {a[0]}");
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"New func exec in {elapsedMs} ms.");
        }

        static void New2()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[] a = new int[2];
            int res = 0;

            for (int j = 0; j < 10000000; j++)
            {
                res += 2;
            }
            a[0] = a[1] = res;
            watch.Stop();
            Console.WriteLine($"Res New2 func: {a[0]}");
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"New2 func exec in {elapsedMs} ms.");
        }
    }
}
