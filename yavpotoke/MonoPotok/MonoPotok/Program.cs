using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonoPotok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread printing = new Thread(Skoll);
            //printing.Start();
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine($"{i}> Прыг~");
            //    Thread.Sleep(230);
            //}
            //void Skoll()
            //{
            //    for (int i = 0; i < 6; i++)
            //    {
            //        Console.WriteLine($"{i}> Скок!");
            //        Thread.Sleep(230);
            //    }
            //}
            //Console.ReadKey();

            Bankir.Balance_my = 0;
            Bankir.Balance_sm = 0;
            Bankir.FIO_my = "Владислав Фуфлыжников";
            Bankir.Schet_my = 323232332;
            Bankir bank = new Bankir();
            bank.Add(10000);
            bank.Wassup();
            bank.ShowMe();

            Console.WriteLine("=========================");
            Console.WriteLine("=========Банкомат========");
            Console.WriteLine("=========================");
            Console.WriteLine("\n1 - Узнать всю инфу\n2 - Узнать счёт\n3 - Внести денег\n4 - Снять денег\n5 - Перевести денег");
            switch (Console.ReadLine())
            {
                case 
            }


            Console.ReadKey();
        }
    }
}
