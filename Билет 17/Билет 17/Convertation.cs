using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Билет_17
{
    internal class Convertation
    {
        public class Mass
        {
            public double pount(double x)
            {
                return x * 2.204623;
            }
            public double ounces(double x)
            {
                return x * 0.02834952;
            }
            public double grams(double x)
            {
                return x * 1000;
            }
        }

        public class Distance
        {
            public double inc(double x)
            {
                return x * 39.37;
            }

            public double sm(double x)
            {
                return x * 100;
            }

            public double pount(double x)
            {
                return x / 0.3048;
            }

            public double seaMill(double x)
            {
                return x / 1852;
            }
        }
    }
}
