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

        public static double GetTriArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static Tuple<decimal, decimal> GetQuadX(decimal a, decimal b, decimal c)
        {
            decimal root = (decimal)Math.Sqrt((double)((b * b) - (4m * a * c) ));
            decimal top1 = b * -1 + root;
            decimal top2 = b * -1 + root * -1;
            return Tuple.Create(top1 / (2 * a), top2 / (2 * a));
        }

    }
}
