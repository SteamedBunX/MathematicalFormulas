using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    public class MathFunctions
    {
        public static double GetcCirArea(double cirRad)
        {
            return cirRad * cirRad * Math.PI;
        }

        public static double GetCirCirc(double cirRad)
        {
            return cirRad * 2 * Math.PI;
        }


    }
}
