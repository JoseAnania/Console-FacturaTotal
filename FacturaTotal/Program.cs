using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, p3, t1, t2, t3, tf;
            int c1, c2, c3;
            Console.WriteLine("Precio articulo 1: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cantidad articulo 1: ");
            c1 = Convert.ToInt32(Console.ReadLine());
            t1 = (p1 * c1);
            Console.WriteLine("Total articulo 1: $" + t1);
            Console.WriteLine();
            Console.WriteLine("Precio articulo 2: ");
            p2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cantidad articulo 2: ");
            c2 = Convert.ToInt32(Console.ReadLine());
            t2 = (p2 * c2);
            Console.WriteLine("Total articulo 2: $" + t2);
            Console.WriteLine();
            Console.WriteLine("Precio articulo 3: ");
            p3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cantidad articulo 3: ");
            c3 = Convert.ToInt32(Console.ReadLine());
            t3 = (p3 * c3);
            Console.WriteLine("Total articulo 3: $" + t1);
            Console.WriteLine();
            tf = (t1 + t2 + t3);
            Console.WriteLine("El total facturado es: $"+tf);

            Console.Read();

        }
    }
}
