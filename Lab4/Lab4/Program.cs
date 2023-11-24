using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Operation
    {
        static void check(double a, double b,double c, out bool d)
        {
            d = true;
            if ((a >= (b + c)) || (b >= (a + c)) || (c >= (b + a)))
            {
                d = false;
            }
            




        }
        public void triangle_oper()
        {
            Console.WriteLine("Ваш треугольник равносторонний? Y/N");
            String triangle = Console.ReadLine();
            if (triangle.Equals("Y"))
            {
                Console.WriteLine("Введите сторону треугольника");
                double a = double.Parse(Console.ReadLine());
                double p = (a * 3) / 2;
                double S = Math.Sqrt(p*(p - a) * (p - a) * (p - a));
                Console.WriteLine("Площадь треугольника = {0}", S);
                Console.ReadLine();
            }
            else
            {
                if (triangle.Equals("N"))
                {
                    Console.WriteLine("Введите первую сторону");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите вторую сторону");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите третью сторону");
                    double c = double.Parse(Console.ReadLine());

                    check(a, b, c, out bool d);
                    if (d == true)
                    {
                        
                        double p =(a+b+c) / 2;
                        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine("Площадь треугольника = {0}", S);
                        Console.ReadLine();
                    }
                    else Console.WriteLine("Такого треугольника не существует");
                    Console.ReadLine();
                }
            }
                
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper = new Operation();
            oper.triangle_oper();
        }
    }
}
