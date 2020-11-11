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
           // int a = 2, b = 3;
            //System.Console.WriteLine("a = {0}  b = {1}", a, b);

            //Swap(ref a, ref b);

            //System.Console.WriteLine("a = {0}  b = {1}", a, b);
            {
                //ecuatieGrad1();
                //ecuatieGrad2();
                //divizoriiLuiK();
                // anBisect();
                //laturile1Triunghi();
                //Swap(ref a, ref b);
                //divizoriiLuiN();
                //primDaSauNu();
                ordineInversa();

               
            }

        }

        private static void ordineInversa()
        {
            int n = int.Parse(Console.ReadLine());
            int c1 = n % 10;
            int c2 = (n % 100) / 10;
            int c3 = (n % 1000) / 100;
            Console.WriteLine("{0},{1},{2}", c1, c2, c3);
            Console.ReadKey();
        }

        /// <summary>
        /// Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        private static void primDaSauNu()
        {
            int d, n, nr=0;
           n = int.Parse(Console.ReadLine());
           for (d = 2; d <= n / 2; d++);
            {
                if (n % d == 0)
                    nr++;
            }
            if (nr == 0)
                Console.WriteLine("Numarul este prim");
            else
                Console.WriteLine("Numarul nu este prim");
            Console.ReadKey();


        }
        /// <summary>
        /// Afisati toti divizorii numarului n. 
        /// </summary>
        private static void divizoriiLuiN()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n / 2; i++) 
            {
                if (n % i == 0) 
                Console.WriteLine(i);
                Console.ReadKey();
            }
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.ReadKey();
        }

        /// <summary>
        /// Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        /// </summary>
        private static void laturile1Triunghi()
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c= int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("Da");
            else
                Console.WriteLine("Nu");
            Console.ReadKey();
                    
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
