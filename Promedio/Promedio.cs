using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Promedio
    {
        static void Main(string[] args)
        {
            int c = 0;
            float  prom = 0;
            do
            {
                Console.WriteLine("Numero: ");
                float num = float.Parse(Console.ReadLine());
                prom = prom + num;

                if (num == 0)
                    break;
                else
                    c++;
            } while (true);

            Console.WriteLine("El pormedio de estos es:" + (prom / c));
            Console.ReadKey();
        }
    }
}
