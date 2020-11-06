using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Program
    {

        static void ecuatieGrad1()
        {
            float a=0, b=0, x = 0;

            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());

          
            
                x = -b / a;
            
            Console.WriteLine("Solutia ecuatiei"+ x);
            Console.ReadKey();
        }
                static void Main(string[] args)
        { 
                {
                //ecuatieGrad1();
                //ecuatieGrad2();
                //divizoriiLuiK();
               // anBisect();
                }

            
        }

        private static void anBisect()
        {
            int y = int.Parse(Console.ReadLine());

            if (y % 4 == 0)
                Console.WriteLine("Anul este bisect");
            else
                Console.WriteLine("Anul nu este bisect");
            Console.ReadKey();
        }

        /// <summary>
        /// Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
        /// </summary>
        private static void divizoriiLuiK()
        {
            int n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            if (n/k ==0) 
            
                Console.WriteLine("n se divide cu k");
            
            else
            
                Console.WriteLine("n nu se divide cu k");
            Console.ReadKey();
        }

        /// <summary>
        /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
        /// Tratati toate cazurile posibile.
        /// </summary>
        private static void ecuatieGrad2()
            
        {
            double a=1, b=1, c=1, x, delta, x1,x2;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
          
            delta=Math.Pow(b,2)-4*a*c;

            if (delta<0)
            {
                Console.WriteLine("Ecuatia nu are solutii reale");

            }
            if (delta == 0)
            {
                Console.WriteLine("Ecuatia are solutii egale");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta) / 2 * a);
                x2 = (-b - Math.Sqrt(delta) / 2 * a);
                Console.WriteLine("Ecuatia are solutii egale");
                Console.WriteLine("x1=" + x1);
                Console.WriteLine("x2=" + x2);
                Console.ReadKey();
            }
        }
    }
}
