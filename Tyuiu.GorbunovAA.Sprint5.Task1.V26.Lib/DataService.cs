using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GorbunovAA.Sprint5.Task1.V26.Lib
{
    public class DataService : ISprint5Task1V26
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) + x == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round((2 * x + 6) / (Math.Cos(x) + x) - 3, 2);
                }
                strY = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else 
                {
                    File.AppendAllText(path , strY);
                }

            }
            return path;
        }
    }
}
