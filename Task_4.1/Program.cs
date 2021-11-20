using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N > 0: ");
            uint N = Convert.ToUInt32(Console.ReadLine());
            uint Sum=0;
            
            for (uint i = 1; i <= N; i++)
            {
                Sum += 2 * i - 1;
                Console.WriteLine("Квадрат числа {0} равен {1}", i, Sum);
            }
            Console.ReadLine();
        }
    }
}
