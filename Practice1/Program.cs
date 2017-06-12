using System;
using System.IO;

public class Program
{

    static void MyShellSort(ref Int64[] arr)
    {
        int i = 0;
        int j = 0;
        Int64 swap = 0;

        for (int distance = arr.Length / 2; distance > 0; distance /= 2)    //Задаём шаг
            for (i = distance; i < arr.Length; i++)                         //Задаём группу для сортировки вставками:
            {
                swap = arr[i];                                              //Сортировка встаавками
                for (j = i; j >= distance; j -= distance)                   
                {
                    if (swap < arr[j - distance])                           
                        arr[j] = arr[j - distance]; 
                    else
                        break;
                }
                arr[j] = swap;
            }
    }

    static void Main(string[] args)
    {

        Int64 N;
        /*
                StreamReader input = new StreamReader("input.txt");
                StreamWriter output = new StreamWriter("output.txt");

                N = Int64.Parse(input.ReadLine());
                Int64[] a = new Int64[N];
                Int64 min = -1;
                Int64 sum = 0;
                for (int i = 0; i < N; i++)
                    a[i] = Int64.Parse(input.ReadLine());

                MyShellSort(ref a);

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
                output.Close();*/
        N = Int64.Parse(Console.ReadLine());
        Int64[] arr = new Int64[N];
        for (int i = 0; i < arr.Length; i++) 
            arr[i] = Int64.Parse(Console.ReadLine());
        MyShellSort(ref arr);
        Console.WriteLine();
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.Read();
    }
}

