using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion
{
    class Auto: Automovil 
    {
        public Auto ( string color)
        {
            this.Color = color;
            Chasis ch1 = new Chasis();
        }

        

       

    }
}
