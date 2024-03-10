using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double Z = double.Parse(Console.ReadLine());
            Random rand = new Random();
            double[] s = new double[15];
            double[] n = new double[15];
            double p = 1;
            double S = 0;
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = rand.Next(-10, 11);
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > Z)
                {
                    p *= s[i];
                    k++;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("s[" + (i + 1) + "] =" + s[i]);
            }
            Console.WriteLine($"произведение чисел которые больше Z={p}  количество чисел= {k}");
            Console.WriteLine("");
            Console.WriteLine("Задание 2");
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = s[i] / 3 - 6;
            }
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("n[" + (i + 1) + "] =" + n[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Задание 3");
            for (int i = 1; i < n.Length; i += 2)
            {
                S += n[i];
            }
            Console.WriteLine($"сумма чисел расположенных на четных позициях равно ={S}");
        }
    }
}
