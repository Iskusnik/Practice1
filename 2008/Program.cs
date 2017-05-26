using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _2008
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Int64 N;

            FileStream input = new FileStream("INPUT.TXT", FileMode.Open, FileAccess.Read);
            StreamReader eye = new StreamReader(input);
            FileStream output = new FileStream("OUTPUT.TXT", FileMode.Create, FileAccess.Write);

            N = Int64.Parse(eye.ReadLine());
            Int64[] a = new Int64[N];
            Int64 min = -1;
            Int64 sum = 0;
            for (int i = 0; i < N; i++)
                a[i] = int.Parse(eye.ReadLine());

            Array.Sort(a);

            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] - sum > 1) && (min == -1)) 
                    min = sum + 1;                  
                                                    
                                                    
                                                     
                                                     
                                                     
                sum += a[i];
            }
            if (min == -1)
                min = sum + 1;

            Console.WriteLine(min);
        }
    }
}
