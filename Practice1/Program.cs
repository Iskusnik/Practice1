using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //in N чисел
            //4 n       пример
            //1 n1
            // 2 n2
            // 4 n3
            //8 n4      ответ 16 
            //out минимальное число не представимое их суммой, каждое число не более одного раза
            int N; 
            
            FileStream input = new FileStream("INPUT.TXT", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader eye = new StreamReader(input);
            FileStream output = new FileStream("OUTPUT.TXT", FileMode.Create, FileAccess.Write);

            N = int.Parse(eye.ReadLine());
            int[] a = new int[N];
            int min = -1;
            int sum = 0;
            for (int i = 0; i < N; i++)
                a[i] = int.Parse(eye.ReadLine());

            Array.Sort(a);

            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] - sum > 1) && (min == -1)) //Берём наименьшее число
                    min = sum + 1;                   //Если разница между следующим элементом 
                                                     //и суммой предыдущих больше 1, 
                                                     //то сумма+1 - искомое число 
                                                     //(Если 1, то можно покрыть все числа до суммы(предыдущих с этим) - почему ?)
                                                     //Типа предыдущие обеспечиваются на предыдущих этапах
                                                     //на случай плохой памяти. Читать проще.
                sum += a[i];
            }
            if (min == -1)
                min = sum + 1;

            Console.WriteLine(min);
            //Надо потестировать
        }
    }
}
