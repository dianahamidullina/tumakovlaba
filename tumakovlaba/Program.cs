using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakovlaba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр.2.1");
            Console.WriteLine("Назовите своё имя");
            string name = Console.ReadLine();

            Console.WriteLine("Привет " + name);
            Console.ReadKey();

            Console.WriteLine("Упр.2.2");
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());
            int c = a / b;
            Console.WriteLine(c);
            Console.ReadKey();

            Console.WriteLine("Упр.2.3");
                Console.WriteLine("Введите букву:");
            char letter = char.Parse(Console.ReadLine());
            letter++;
                Console.WriteLine("Следующая буква в алфафите:" + letter);
            Console.ReadKey();

            Console.WriteLine("Упр.2.4");
            Console.WriteLine("Введите коэффицент a:");
            int cof1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффицент b:");
            int cof2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффицент c:");
            int cof3 = int.Parse(Console.ReadLine());
            int d4 = cof3 * cof3 - 4 * cof1 * cof2;
            if (d4 > 0) ;
            {
                double cor1 = ((-cof2) + Math.Sqrt(d4)) / 2 * cof1;
                double cor2 = ((-cof2) - Math.Sqrt(d4)) / 2 * cof1;
                Console.WriteLine("Первый корень=" + cor1 + "Второй корень=" + cor2);

            }
            if (d4 < 0) ;
            {
                Console.WriteLine("Корней нет");
            }
            if (d4 == 0) ;
            {
                double cor1 = (-cof2) + 0 / 2 * cof1;
                Console.WriteLine("Корень уравнения=" + cof1);
            }
            Console.ReadKey();




        }
    }
}
