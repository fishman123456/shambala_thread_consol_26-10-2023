using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace shambala_thread_consol_26_10_2023
{
    internal class morning
    {
        //Принять душ
        static void TakeShower()
        {
            Console.WriteLine("Принять душ: start");
            Thread.Sleep(5000);
            Console.WriteLine("Принять душ: end");
        }

        // Согреть чайник
        static void WarmKettle()
        {
            Console.WriteLine("Согреть чайник: start");
            Thread.Sleep(10000);
            Console.WriteLine("Согреть чайник: stop");
        }

        // Сделать бутерброд
        static void TakeSandwich()
        {
            Console.WriteLine("Сделать бутерброд: start");
            Thread.Sleep(3000);
            Console.WriteLine("Сделать бутерброд: end");
        }

        static void SyncMorning()
        {
            TakeShower();
            WarmKettle();
            TakeSandwich();
        }
        static void AsincMorning()
        {
            Thread thread1 = new Thread(WarmKettle);
            //Thread thread = new Thread(TakeShower);
            //thread.Start();
            thread1.Start();
            //thread.Join();
            TakeShower();
            TakeSandwich();
            thread1.Join();
        }
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew(); // замер времени работы программы

            //SyncMorning();
            AsincMorning();
            Console.WriteLine($"Время работы: {sw.ElapsedMilliseconds}");
            Console.ReadLine();
        }
    }
}
