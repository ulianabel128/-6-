using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_6_практика
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = 0;
            double a2 = 0;
            double a3 = 0;
            int n = 0;
            int e = 0;
            bool ok = false;
            int i = 0;

            do
            {
                Console.WriteLine("Введите a1");
                string user = Console.ReadLine();
                ok = double.TryParse(user, out a1);
                if (!ok) Console.WriteLine("Неверный ввод");
            } while (!ok);
            ok = false;

            do
            {
                Console.WriteLine("Введите a2");
                string user = Console.ReadLine();
                ok = double.TryParse(user, out a2);
                if (!ok) Console.WriteLine("Неверный ввод");
            } while (!ok);
            ok = false;

            do
            {
                Console.WriteLine("Введите a3");
                string user = Console.ReadLine();
                ok = double.TryParse(user, out a3);
                if (!ok) Console.WriteLine("Неверный ввод");
            } while (!ok);
            ok = false;

            do
            {
                Console.WriteLine("Введите n");
                string user = Console.ReadLine();
                ok = int.TryParse(user, out n);
                if (!ok) Console.WriteLine("Неверный ввод");
            } while (!ok);
            ok = false;

            do
            {
                Console.WriteLine("Введите e");
                string user = Console.ReadLine();
                ok = int.TryParse(user, out e);
                if (!ok) Console.WriteLine("Неверный ввод");
            } while (!ok);
            ok = false;

            double[] mas = new double[n];
            mas[0] = a1;
            mas[1] = a2;
            mas[2] = a3;

            for (i=3; i<mas.Length; i++)
            {
                mas[i] =(mas[i - 1]/3) + (mas[i - 2]/2) + ((2*mas[i - 3])/3);
                //mas[i] = (1 / 3) * mas[i - 1] + (1 / 2) * mas[i - 2] + (2 / 3) * mas[i - 3];
            }

            Console.WriteLine("Элементы последовательности:");

            for (i = 0; i < mas.Length; i++)
            {  
                Console.Write(mas[i] + " ");
            }

            Console.WriteLine();

            int couples=0;

            for (i = 1; i < mas.Length; i++)
            {
                if (Math.Abs(mas[i]-mas[i-1])<e)
                {
                    couples++;
                    Console.WriteLine("Пара " + couples + ": " + i + " " + (i + 1));
                } 
            }

            Console.WriteLine("Кол-во пар "+couples);

            Console.ReadKey();
        }
    }
}
