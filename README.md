# laba5_os

Origianal code:
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
