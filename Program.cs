using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Asociacion por agregacion y composición. Relación entre las clases" );

            Auto a1 = new Auto("Rojo");

            // Asociacion por agregación: agregamos un motor al auto. 

            a1.Motor = new Motor();
            

            Console.WriteLine("El color del auto es : " + a1.Color);
            Camioneta c1 = new Camioneta("Negra");
            Console.WriteLine("El color de la camioneta es : " + c1.Color);

            Console.ReadKey();
           
        }
            

    }
}
