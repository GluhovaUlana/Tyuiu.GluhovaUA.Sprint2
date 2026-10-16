using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GluhovaUA.Sprint2.Task4.V18.Lib
{
    public class DataService : ISprint2Task4V18
    {
        public double Calculate(double x, double y)
        {
            double z = 0;
            if (x * 3 < y - 2)
            {
                return z = Math.Round(Math.Pow((6 + ((x - 1) / Math.Pow(y, 3))),x),3);
            }
            else
            {
                return z = Math.Round( x + 10 * y - (1 / x),3);
            }
        }
    }
}
