using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GluhovaUA.Sprint2.Task2.V30.Lib
{
    public class DataService : ISprint2Task2V30
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if((x >= 2 && x <= 13) && (y >= 3 && y <= 12))
            {
                if (x == 2 && y == 3)
                {
                    return false;
                }
                if ((x >= 6 && x <= 8) && (y >= 3 && y <= 4))
                {
                    return false;
                }
                if (x == 13 && (y >= 3 && y <= 5))
                {
                    return false;
                }
                if (x == 2 && y == 7)
                {
                    return false;
                }
                if ((x >= 2 && x <= 5) && (y >= 8 && y <= 10))
                {
                    return false;
                }
                if ((x >= 7 && x <= 13) && (y >= 8 && y <= 10))
                {
                    return false;
                }
                if ((x >= 2 && x <= 2) && (y >= 11 && y <= 12))
                {
                    return false;
                }
                if ((x >= 3 && x <= 6) && (y == 12))
                {
                    return false;
                }
                if ((x >= 11 && x <= 13) && (y == 12))
                {
                    return false;
                }
                if ((x == 13) && (y == 11))
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}