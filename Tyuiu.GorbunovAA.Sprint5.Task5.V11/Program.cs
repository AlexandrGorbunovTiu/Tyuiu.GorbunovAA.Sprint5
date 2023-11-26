using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GorbunovAA.Sprint5.Task5.V11.Lib;

namespace Tyuiu.GorbunovAA.Sprint5.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 │ Выполнил: Горбунов А.А. │ ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Вынолнил: Горбунов Александр Александрович │ ИИПб-23-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти произведение всех нечетных целых                                  *");
            Console.WriteLine("* чисел в файле                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            string path = @"C:\DataSprint5\InPutDataFileTask5V11.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            var res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
