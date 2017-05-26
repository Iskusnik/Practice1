using System;
using System.IO;

    public class Program
    {
        static void Main(string[] args)
        {
            
            int N;

            StreamReader input = new StreamReader("input.txt");
            StreamWriter output = new StreamWriter("output.txt");

            N = int.Parse(input.ReadLine());
            int[] a = new int[N];
            int min = -1;
            int sum = 0;
            for (int i = 0; i < N; i++)
                a[i] = int.Parse(input.ReadLine());

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

