using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace shambala_thread_consol_26_10_2023
{
    // ЗАДАНИЕ:
    // Написать 2 функци, которые
    // 1) выводит все четные числа от 1 до 100 (50 мс.)
    // 2) выводит все числа, кратные 2, 3 и 7 в диапазоне от 1 до 1000 (10 мс.)

    // Запустить 2 функции в отдельных потоках
    // дождаться завершения этих потоков в главном потоке

    internal class Program
    {
        public static void chet()
        {
            for (int i = 0; i <1000; i++)
            {
                Console.Write($"{i} ");
                Thread.Sleep(50);
            }
        }
        public static void crat()
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 0 && i%3 == 0 && i%7 ==0)
                {
                    Console.Write($"{i} ");
                    Thread.Sleep(50);
                }

            }
        }
        public static void run()
        {
            Thread thread = new Thread( chet );
            Thread thread2 = new Thread(crat);
            thread.Start();
            thread2.Start();
            thread.Join();
            thread2.Join();
            Console.Write("");
        }
        static void Main(string[] args)
        {
            run();
            Console.Write("");
        }
    }
}
