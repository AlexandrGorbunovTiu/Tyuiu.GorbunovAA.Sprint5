using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.GorbunovAA.Sprint5.Task3.V5.Lib;

namespace Tyuiu.GorbunovAA.Sprint5.Task3.V5
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Вынолнил: Горбунов Александр Александрович │ ИИПб-23-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Подсчитать функцию                                                      *");
            Console.WriteLine("* и создать файл с ним                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine(" y = 2 * x * x * x + 0.5 * x * x - 3.5 * x + 2 ");
            Console.WriteLine(" x = 2");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            string res = ds.SaveToFileTextData(2);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
    }
}
