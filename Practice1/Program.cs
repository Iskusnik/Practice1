using System;
using System.IO;

    public class Program
    {
        static void Main(string[] args)
        {
            
            Int64 N;

            StreamReader input = new StreamReader("input.txt");
            StreamWriter output = new StreamWriter("output.txt");

            N = Int64.Parse(input.ReadLine());
            Int64[] a = new Int64[N];
            Int64 min = -1;
            Int64 sum = 0;
            for (int i = 0; i < N; i++)
                a[i] = Int64.Parse(input.ReadLine());

            Array.Sort(a);

            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] - sum > 1) && (min == -1)) 
                    min = sum + 1;                   

                sum += a[i];
            }
            if (min == -1)
                min = sum + 1;

            output.WriteLine(min);

            input.Close();
            output.Close();

        }
    }

