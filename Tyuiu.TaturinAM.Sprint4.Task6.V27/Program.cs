using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TaturinAM.Sprint4.Task6.V27.Lib;
namespace Tyuiu.TaturinAM.Sprint4.Task5.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Татурин А. М. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание №6                                                              *");
            Console.WriteLine("* Вариант №27                                                             *");
            Console.WriteLine("* Выполнил: Татурин Артем Максимович | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Подсчитайте количество элементов, длина которых меньше 7                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Квадрат,Прямоугольник,Круг,Треугольник,Пятиугольник,Шестиугольник      *");
            DataService ds = new DataService();
            string[] array = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            int res = ds.Calculate(array);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
