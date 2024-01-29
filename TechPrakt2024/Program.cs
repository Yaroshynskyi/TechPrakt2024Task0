using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                         System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            double x, y, result;
            bool p;
            Console.Write("Введіть значеня для чилса x = ");
            if (!(double.TryParse(Console.ReadLine(), out x)))
            {
                do
                {
                    Console.WriteLine("Число введено некоректно, повторіть спробу.");
                    Console.Write("Введіть значеня для чилса x = ");
                    p = (double.TryParse(Console.ReadLine(), out x));
                } while (!p);
            }


            Console.Write("Введіть значеня для чилса y = ");
            if (!(double.TryParse(Console.ReadLine(), out y)))
            {
                do
                {
                    Console.WriteLine("Число введено некоректно, повторіть спробу.");
                    Console.Write("Введіть значеня для чилса y = ");
                    p = (double.TryParse(Console.ReadLine(), out y));
                } while (!p);
            }

            result = x+y;
            Console.WriteLine($"Результат обчислення: {Math.Round(result, 3)}");
        }
    }
}