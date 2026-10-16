
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint2.Task5.V5.Lib;
namespace Tyuiu.GluhovaUA.Sprint2.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #2 | Выполнила: Глухова У. А.| ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор Switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("*Выполнила: Глухова У. А.| ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Игральным картам условно присвоены следующие порядковые номера в        *");
            Console.WriteLine("* зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю» — 13*");
            Console.WriteLine("* «тузу» — 14. Порядковые номера остальных карт соответствуют их названиям*");
            Console.WriteLine("* По заданному номеру карты k (6 <=k <= 14) определить достоинство        *");
            Console.WriteLine("* соответствующей карты.                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер карты: ");

            int value = Convert.ToInt32(Console.ReadLine());
            string res; 
            if ((value < 6) || (value > 14))
            {
                res = "Введено неверное значение!";
            }

            else 
            {
                res = "Это карта " + ds.FindCardValue(value);
            }


                Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine( res);
            Console.ReadKey();
        }
    }

}
