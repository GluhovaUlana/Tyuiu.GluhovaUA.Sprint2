using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GluhovaUA.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
           
            if (m < 1 || m > 12 || n < 1 || n > 31)
            {
                throw new ArgumentException("Некорректная дата");
            }
            int d;
            switch (m)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    d = 30;
                    break;
                case 2:
                    d = 29; 
                    break;
                default:
                    d = 31;
                    break;
            }
            if (n == d)
            {
                if (m == 12)
                {
                    return $"{g + 1}.01.01";
                }
                else
                {
                    return $"{g}.{(m + 1):D2}.01";
                }
            }
            else
            {
                return $"{(n + 1):D2}.{m:D2}.{g}";
            }
        }
    }
    
}
