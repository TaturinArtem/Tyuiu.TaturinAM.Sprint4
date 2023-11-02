using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TaturinAM.Sprint4.Task2.V30.Lib;
namespace Tyuiu.TaturinAM.Sprint4.Task2.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнилf: Татурин А. М. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Татурин Артем Максимович | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов, заполненный        *");
            Console.WriteLine("* случайными числами в диапозоне от 2 до 8.                               *");
            Console.WriteLine("* Необходимо подсчитать произведение нечётных элементов массива.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество элементов в массиве:");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                array[i] = rnd.Next(2, 8);
            }
            string text = $"{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}, {array[8]}, {array[9]}";
            Console.WriteLine($"Получившийся массив: {text}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение нечётных элементов массива: {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}
