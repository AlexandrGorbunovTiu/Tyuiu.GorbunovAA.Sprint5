using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GorbunovAA.Sprint5.Task0.V13.Lib;

using System.IO;

namespace Tyuiu.GorbunovAA.Sprint5.Task0.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 │ Выполнил: Горбунов А.А. │ ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Вынолнил: Горбунов Александр Александрович │ ИИПб-23-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Подставить в выражение x = 5 и                                          *");
            Console.WriteLine("* создать файл                                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine(" y = -1.4 * x * x * x + 2.3 * x * x + 0.6 * x");
            Console.WriteLine(" x = 5");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
