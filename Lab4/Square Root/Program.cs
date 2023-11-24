using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Root
{
    class func1
    {
        public void calc_roots(int a, int b, int c, ref int d)
        {
            
            int D = a * a - 4 * a * c;
            if (D < 0)
            {
                d = -1;
            }
            else
                if (D == 0)
            {
                d = 0;
            }
            else if (D > 0)
            {
                d = 1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            func1 oper = new func1();
            Console.WriteLine("Enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c");
            int c = int.Parse(Console.ReadLine());
            
            int d = 0;
            oper.calc_roots(a, b, c, ref d);
            switch (d)
            {
                case -1:
                    Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1},  c = {2} = результат нет.", a,b,c);
                    break;
                case 0:
                    Console.WriteLine("Корень уравнения с коэффициентами  a = {0}, b = {1},  c = {2} один: x1 = x2 = {3}", a, b, c, (-b+Math.Sqrt(a * a - 4 * a * c)/2*a));
                    break;
                case 1:
                    Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1},  c = {2} равны: x1 = {3},  x2 = {4}.", a, b, c, (-b + Math.Sqrt(a * a - 4 * a * c) / 2 * a), (-b - Math.Sqrt(a * a - 4 * a * c) / 2 * a));
                    break;
            }
            Console.ReadLine();
        }
    }
}
