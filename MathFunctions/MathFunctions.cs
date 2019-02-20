using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    public class MathFunctionsClass
    {
        public static double GetCirArea(double cirRad)
        {
            return cirRad * cirRad * Math.PI;
        }

        public static double GetCirCirc(double cirRad)
        {
            return cirRad * 2 * Math.PI;
        }

        public static double GetHemiVol(double hemiRad)
        {
            return 2.0 / 3 * Math.PI * Math.Pow(hemiRad, 3);
        }

    }
}
