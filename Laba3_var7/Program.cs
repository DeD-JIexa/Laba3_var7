using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba3_var7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { -5, 4, -13, 0, 0, 0, -9, 7.6, 8, 1 };

            double max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > Math.Abs(max))
                    max = array[i];
            }

            Console.WriteLine("максимальный по модулю: {0}", max);

            int pos1 = 0, pos2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    pos1 = i;
                    for (int j = pos1 + 1; j < array.Length; j++)
                    {
                        if (array[j] > 0)
                        {
                            pos2 = j;
                            break;
                        }
                    }
                    break;
                }
            }
            //Console.WriteLine("pos1= {0}\r\npos2= {1}", pos1, pos2);

            double sum = 0;
            for (int i = pos1 + 1; i < pos2; i++)
            {
                sum += array[i];
            }

            Console.WriteLine("Сумма между 1м и 2м элементами: {0}", sum);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 2; j > 0; j--)
                {
                    if (array[j] == 0)
                    {
                        double temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Все элементы массива:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }


            Console.ReadKey();
        }
    }
}
