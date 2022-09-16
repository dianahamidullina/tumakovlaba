using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.Вывести на экран число е");
           object n = "e=2,7";
                Console.WriteLine(n);
            Console.ReadKey();

            Console.WriteLine("Задача 2.Вывести на экран числа 50 и 10 друг под другом");
            int a = 50;
            int y = 10;
            Console.WriteLine(a);
            Console.WriteLine(y);
            Console.ReadKey();

            Console.WriteLine("Задание 3. Составить программу вывода на экран 4 любых чисел");
            Random rnd = new Random();
            int q = rnd.Next();
            int e = rnd.Next();
            int o = rnd.Next();
            int k = rnd.Next();
                Console.WriteLine(q);
            Console.WriteLine(e);
            Console.WriteLine(o);
            Console.WriteLine(k);
            Console.ReadKey();


            Console.WriteLine("Задание 4. Пользователь водит число.Выведи на экран число ,большее выведенного на 10");
            Console.WriteLine("Введите число");
                int v = int.Parse(Console.ReadLine());
            int w = v + 10;
            Console.WriteLine(w);
            Console.ReadKey();

            Console.WriteLine("Задание 5. Дана сторона квадрата, найдите его периметр ");
            Console.WriteLine("Введите длину стороны квадрата:");
            int a1 = int.Parse(Console.ReadLine());
            int c = a1 * 4;
            Console.WriteLine($"периметр квадрата = {c}");
            Console.ReadKey();
           
            

           

            Console.WriteLine("Задание 6.Дан радиус окружности.Найдите длину и площадь круга.");
            Console.WriteLine("Введите радиус окружности");
            int m = int.Parse(Console.ReadLine());
            double r1 = 2 * m * Math.PI;
            double l2 = Math.PI * m * m;
            Console.WriteLine($"длина круга = {Math.Round(r1, 2)}, площадь круга ={Math.Round(l2,2)}");
            Console.ReadKey();

            Console.WriteLine("Задание 7.Найти значение у=cos(x)");
                Console.WriteLine("Значение x :");
            int x = int.Parse(Console.ReadLine());
            double x2 = Math.Cos(x);
            Console.WriteLine($"значение y=cos(x)= {Math.Round(x2, 2)}");
            Console.ReadKey();


            Console.WriteLine("Задание 8.Даны высота и основания равнобед.трапеции .найдите ее периметр ");
            Console.WriteLine("Введите высоту трапеции");
            int h1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите верхнее основание трапеции");
            
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите нижнее основание трапеции");
            int f2 = int.Parse(Console.ReadLine());
            double p3 = Math.Sqrt(((f2 - f / 2) * (f2 - f / 2) + h1 + h1));
            double p4 = 2 * p3 + f + f2;
            Console.WriteLine($"Периметр трапеции = {p4}");
            Console.ReadKey(); 

            Console.WriteLine("Задание 9");
            Console.WriteLine("Сколько кг конфет купили:");
            int x3=int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько кг печенья купили:");
            int y3=int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько кг яблок купили:");
            int z3=int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько стоит 1 кг конфет?");
            int x4=int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько стоит 1 кг печенья?");
            int y4=int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько стоит 1 кг яблок?");
            int z4=int.Parse(Console.ReadLine());
            double r1=x3*x4+y3*y4+z3*z4;
            Console.WriteLine("Итоговая цена = " +r1);

            
            Console.WriteLine("Задание 10");
            string name = "Мир Труд Май";
            Console.WriteLine(name);
            string s = "Мир";
            string s2 = "Труд";
            string s3 = "Май";
            Console.WriteLine(s);
            Console.WriteLine(" " + " " +" "+ s2);
            Console.WriteLine(" " + " "+" "+" "+" "+" "+" " +" "+s3);
            Console.ReadKey();
            
            Console.WriteLine("Задание 11");
            Console.WriteLine("Введите 1е число");
            int chislo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2е число");
            int chislo2 = int.Parse(Console.ReadLine());
            Console.Write(chislo2);
            Console.Write(" "+chislo1);
            
            Console.WriteLine("Задание 13");
            Console.WriteLine("Введите число:");
           int num = int.Parse(Console.ReadLine());
            string scr = "Вы ввели число";
            Console.WriteLine(scr);
            Console.ReadKey();

            Console.WriteLine("Задание 14");
            int t2 = 2;
            int t3 = 13;
            int t4 = 17;
            string len = "кг";
            Console.WriteLine(t2+" "+" "+len);
            Console.WriteLine(t3 + " " + t4);
            Console.ReadLine();

            Console.WriteLine("Задание 15");
            Random rnd2 = new Random();
            int q1 = rnd2.Next();
            int e1 = rnd2.Next();
            int o1 = rnd2.Next();
            int k1 = rnd2.Next();
            Console.WriteLine(q1);
            Console.WriteLine(e1);
            Console.WriteLine(o1);
            Console.WriteLine(k1);
            Console.ReadKey();
            Console.WriteLine("Задание 16");
            //D=b^2-4ac
            Console.WriteLine("Введите а:");
            double a4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b:");
            double b4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c:");
            double c4 = Convert.ToDouble(Console.ReadLine());
            double d4 = b4 * b4 - 4 * a4 * c4;
            if (d4 < 0) 
            {
                Console.WriteLine("Дискриминант меньше 0.Корней нет");
            }
            if (d4 > 0) 
            {
              
                double x4f = ((-b4 - Math.Sqrt(d4)) / (2 * a4));
                double x4t = ((-b4 + Math.Sqrt(d4)) / (2 * a4));
                Console.WriteLine("Дискриминант больше 0. Первый корень раавен" + x4f);
                Console.WriteLine("Второй корень равен" + x4t);
            }
            if (d4 == 0) 
            {
                double x4 = (-b4 / (2 * a4));
                Console.WriteLine("Дискриминант равен 0.Корень равен" + x4);
            }
            Console.ReadKey();

            Console.WriteLine("Задание 17");
        
            Console.WriteLine("Ввкдите первое целое число:");
            int a6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число:");
            int b6 = int.Parse(Console.ReadLine());
            int result = (a6 + b6) / 2;
            Console.WriteLine("Среднее арифмитическое =" + result);
            double result1 = Math.Sqrt(a6*b6);
            Console.WriteLine("Среднее геометрическое =" + result1);



            Console.ReadKey(); 

            Console.WriteLine("Задание 18");
            Console.WriteLine("Ввести х1");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввести у1");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввести х2");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввести у2");
            int y2 = int.Parse(Console.ReadLine());
            double itog = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            Console.WriteLine("Расстояние между точками = "+itog);

            Console.WriteLine("Задание 19");
            Console.WriteLine("пункт а)");
            Console.WriteLine("Введите число a:");
            int a8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c7 = int.Parse(Console.ReadLine());
            int result7 = a8 = b7;
            b7 = c7;
            c7 = a8;
            Console.WriteLine("Число а после обмена" +" "+a8);
            Console.WriteLine("Чссло b после обмена" +" "+b7);
            Console.WriteLine("Число c после обмена" +" "+c7);
            Console.WriteLine("пункт б)");
            Console.WriteLine("Введите число а");
            int a9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c8 = int.Parse(Console.ReadLine());
            int result8 = b8 = a9;
            c8 = b7;
            a9 = c8;
            Console.WriteLine("Число а после обмена" +" "+a9);
            Console.WriteLine("Чссло b после обмена" +" "+b8);
            Console.WriteLine("Число c после обмена" +" "+c8);
            Console.ReadLine();

            Console.WriteLine("Задание 20");
            Console.WriteLine("Введите колличество секунд  :");
            int sec= int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько полных часов прошло с начала суток?");
            int hour = sec / 3600;
            Console.WriteLine(hour);
            Console.WriteLine("Сколько полных минут прошло с начала очередного часа?");
            int min = (sec % 3600) / 60;
            Console.WriteLine(min);
            Console.WriteLine("Сколько полных секунд прошло с начала очередной минуты?");
            int sec2= sec % 60;
            Console.WriteLine(sec2);
            Console.ReadKey();

            Console.WriteLine("Задание 21");
            Console.WriteLine("Дан прямоугольник со сторонами 543*130");
            int plp = 534 * 130;
            int plp2 = 130 * 130;
            int otv = plp / plp2;
            Console.WriteLine("Кол-во квадратов =" + otv);
            Console.ReadKey();

            Console.WriteLine("Задание 22");
            Console.WriteLine("Введите четырехзначное число 1000>chislo>99");
            int chislo = int.Parse(Console.ReadLine());
            int chislo1 = chislo / 100;
            int chislo2 = (chislo - chislo1 * 100) / 10;
            int chislo3 = chislo - chislo1 * 100 + chislo2 * 10;
            int chislo4 = chislo3 * 100 + chislo1 * 10 + chislo2;
            Console.WriteLine("Измененное число:"+chislo4);
            Console.ReadKey();
            
            
            
            
            
            Console.WriteLine("Задание 23");
            Console.WriteLine("Введите трехзначное число n >999:");
            int trzn = int.Parse(Console.ReadLine());
            int sot = trzn / 100;
            Console.WriteLine("Число сотен в числе n:"+" "+ sot);
            int fouz = trzn / 1000;
            Console.WriteLine("Число тысяч в числе n:"+" " + fouz);
            Console.ReadKey();

            Console.WriteLine("Задание 24");
            Console.WriteLine("Введите четырехзначное число;");
            int four = int.Parse(Console.ReadLine());
            // не поняла как делать

            Console.WriteLine("Задание 25");
            Console.WriteLine("Введите трехзначное число 100>n>99:");
            int free = int.Parse(Console.ReadLine());
            int free1 = free / 100;
            int free2 = free - free1 * 100;
            int free3 = free2 * 10 + free1;
            
            Console.WriteLine("Х=" + free3);
            Console.ReadKey();


            Console.WriteLine("Задание 26");







        }
    }
}
