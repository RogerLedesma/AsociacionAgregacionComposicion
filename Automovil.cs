using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion
{
    class Automovil
    {

        // Asociacion por composición 

        public Automovil()
        {
            Chasis = new Chasis();
        }
        public string Color { get; set; }

        // Asociacion por agregación
        public Motor Motor { get; set; }

        // Asociacion por composición

        public Chasis Chasis { get; set; }





    }
}
