using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Conditionals
    {
        public static void IfConditional() 
        {
            int temperature = 15;
            string wether = "summer";

            if(temperature < 10 && wether == "summer")
            {
                Console.WriteLine("Take the coat, a heavy one, it's weird it's this cold on a summer day");
            }

            if(temperature == 10 && wether == "summer")
            {
                Console.WriteLine("It's 10 degrees C°, wear a jersey and some shorts if you like");
            }

            if (temperature > 10 && wether != "summer") 
            {
                Console.WriteLine("Cozy & warm! Nice wether for a cold month");
            }
            if (temperature > 10 && wether == "summer")
            {
                Console.WriteLine("Cozy & warm! Nice wether for a cold month. The temperature is {0}°C", temperature);
            }
        }
      
    }
}
