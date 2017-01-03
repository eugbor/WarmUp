using System;

namespace WarmUp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Стрелки часов движутся с постоянными угловыми скоростями и показывают h часов m минут.
            //Найдите число полных минут до ближайшего момента, в который стрелки совпадут.
            //
            //int h = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());

            //// угол
            ////double rm = 360 * m / 60;
            ////double rh = 360 * (h % 12) / 12;
            ////Console.WriteLine(Math.Abs(rm - rh));

            ////int diff = 11 * (60 * h + m) % 720;
            ////if (diff != 0)
            ////{
            ////    diff = 720 - diff;
            ////}
            ////diff /= 11;
            ////Console.WriteLine(diff);

            //Console.WriteLine(Math.Abs(h*5-m));


            //Разбить последовательность чисел от 1 до N^2 на N подпоследовательностей так,
            //чтобы все они состояли из N чисел и имели равные суммы.
            //Если решений несколько, то вывести любое из них.
            //
            int n = Convert.ToInt32(Console.ReadLine());
            if (!(n > 0 && n <= 200))
            {
                Console.WriteLine("Incorrect number");
            }
            //int[] sequence = new int[n * n];
            //int sum = 0;
            //int a = 1;
            //for (int i = 0; i < sequence.Length; i++)
            //{
            //    sequence[i] = sequence[i] + a;
            //    sum += sequence[i];
            //    a++;
            //}

            //int average = sum / n;
            //Console.WriteLine(average);

            for (int i = 1; i <= n; i++)
            {
                int j = i;
                while (j%n != 0)
                {
                    Console.Write("{0, 2} ", j);
                    j += n + 1;
                }
                Console.Write("{0, 2} ", j);
                if (j != n*n)
                {
                    j++;
                    while (j + n + 1 <= n*n)
                    {
                        Console.Write("{0, 2} ", j);
                        j += n + 1;
                    }
                    Console.WriteLine(j);
                    j = 0;
                }
                else
                {
                    Console.WriteLine();
                    j = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
