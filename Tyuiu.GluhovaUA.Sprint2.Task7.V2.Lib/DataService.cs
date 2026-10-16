using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GluhovaUA.Sprint2.Task7.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            
            bool d = x >= 0;
            bool t = y <= x / 2.0;
            bool g = (x * x + y * y) <= 1;

            return d && t && g;
        }
    }
}

         
        