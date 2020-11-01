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
            float a, b, x = 0;

            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());

            if (a == 0) ;
            
                if (b == 0) ;
            
            {
                Console.WriteLine("Exista o infinitate de solutii");
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutii");
            }
            {
                x = -b / a;
            }
            Console.WriteLine("Solutia ecuatiei", x);
        }
                static void Main(string[] args)
        { 
                {
                    ecuatieGrad1();
                }
            
        }
    }
}
