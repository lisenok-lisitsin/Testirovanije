using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoPotok
{
    public class Bankir
    {
        public static string FIO_my { get; set; }
        public static int Schet_my { get; set; }
        public static int Balance_my { get; set; }
        public static int Balance_sm { get; set; }

        public void Add(int bal)
        {
            Balance_my = Balance_my + bal;
        }
        public void Rem(int bal)
        {
            Balance_my = Balance_my - bal;
        }
        public void Wassup()
        {
            Console.WriteLine(Balance_my);
        }
        public void Give(int mon)
        {
            if (mon > Balance_my)
            {
                Balance_my = Balance_my - mon;
                Balance_sm = Balance_sm + mon;
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }
        public void ShowMe()
        {
            Console.WriteLine($"\nФИО: {FIO_my}\nНомер счёта: {Schet_my}\nБаланс: {Balance_my}");
        }
    }
}
