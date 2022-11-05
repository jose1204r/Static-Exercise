using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempConverter
    {
     public static  double FahrenheitToCelsius(double fh)
        {
         var result =  (fh - 32) / 1.8;
            return result;
        }

      public static double CelsiusToFahrenheit(double cc) 
        
        
        {

            return (cc * 9) / 5 + 32;
        
        }
    }
}
