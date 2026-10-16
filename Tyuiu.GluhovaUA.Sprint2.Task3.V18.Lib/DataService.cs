using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GluhovaUA.Sprint2.Task3.V18.Lib
{
    public class DataService : ISprint2Task3V18
    {
        public double Calculate(double x)
        {
            double res=0;
            if (x>1)
            {
                res = Math.Round(Math.Pow(x, 2) * Math.Pow((x + 1) / (x - 1), x),3);
            }
            else  
            {
                if (x == 0)
                {
                    res = Math.Round((Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12),3);
                }
                else 
                {
                    if (-22 < x  && x< 2)
                    {
                        res = Math.Round(Math.Pow((1+1/Math.Pow(x,2)),x),3);
                    }
                    else
                    {
                        if (x < -22)
                        {
                            res = Math.Round(x + (10 * x)-(1.0/x),3);
                        }
                    }
                }
                
            }
            return res;
        }
    }
}
