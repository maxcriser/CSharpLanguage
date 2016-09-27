using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLanguage
{
    class Program
    {
        static void task_2()
        {
            Console.Write("a=");
            int first = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}={1}+{0}", first, second);
        }
        static void task_3()
        {
            Console.Write("a=");
            int first = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int second = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}+{2}={3}", first, second, third, first + second + third);
        }
        static void task_4_5(bool flag)
        {
            Console.Write("a=");
            double first = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double second = double.Parse(Console.ReadLine());
            if (flag)
            {
                Console.WriteLine("{0:0.0}*{1:0.0}={2:0.0}", first, second, first*second);
            }
            else
            {
                if (second == 0)    Console.WriteLine("ERROR: Div by zerro.");
                else Console.WriteLine("{0:0.000}*{1:0.000}={2:0.000}", first, second, first/second);
            }
        }
        static void task_6()
        {
            Console.Write("a=");
            double first = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double second = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double third = double.Parse(Console.ReadLine());
            Console.WriteLine("({0:0.00}+{1:0.00})+{2:0.00}={0:0.00}+({1:0.00}+{2:0.00})", first, second, third);
        }
        static void task_7()
        {
            Console.WriteLine("C format: {0:C}", 99989.987); // currency $ . 99 989,99p.
            Console.WriteLine("D9 format: {0:D9}", 99999); // 9 digits . 000099999
            Console.WriteLine("E format: {0:E}", .31415926538 * 10); // Scientific . 3,141593E+000
            Console.WriteLine("F format: {0:F3}", 55555.6666); // number of zeros after the decimal point 55555,667
            Console.WriteLine("N format: {0:N}", 99999); // div by thousands 99 999,00
            Console.WriteLine("X format: {0:X}", 99999); // hex 1869F
            Console.WriteLine("x format: {0:x}", 99999); // hex
            Console.Write("\n\n");
        }
        static void task_8()
        {
            Console.WriteLine("{0,10}->{0:x}\n{1,10}->{1:x}\n{2,10}->{2:x}\n{3,10}->{3:x}\n", 12, 256, 1001, 123456789);
        }
        static void task_9()
        {
            Console.WriteLine("{0}\n{1}\n{2}\n{3,28}","Однажды в студеную зимнюю пору","Я из лесу вышел...","Был сильный мороз...","А.С.Пушкин");
        }
        static void Main(string[] args)
        {
            string separation = "\n#_#_#_#_#_#_#_#_#_#_#_#_#_#\n";
            task_2(); // a+b=b+a
            Console.WriteLine(separation);
            task_3(); // a+b+c=result
            Console.WriteLine(separation);
            task_4_5(true); // a*b=result .0
            Console.WriteLine(separation);
            task_4_5(false); // a/b=result .000
            Console.WriteLine(separation);
            task_6(); //
            Console.WriteLine(separation);
            task_7(); // x:x
            Console.WriteLine(separation);
            task_8(); // hex
            Console.WriteLine(separation);
            task_9(); // poem
        }
    }
}
