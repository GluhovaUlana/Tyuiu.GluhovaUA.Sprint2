using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint2.Task4.V18.Lib;
namespace Tyuiu.GluhovaUA.Sprint2.Task4.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #2 | Выполнила: Глухова У. А.| ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:  Тернарный оператор                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("*Выполнила: Глухова У. А.| ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                *");
            Console.WriteLine("* с использованием тернарного оператора                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение переменной Х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x,y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }

}