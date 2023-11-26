using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.GorbunovAA.Sprint5.Task7.V13.Lib
{
    public class DataService : ISprint5Task7V13
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if(fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strX = File.ReadAllText(path);
            string resultString = "";
            foreach (char c in strX)
            {
                if (!Char.IsLower(c) || !Char.IsLetter(c))
                {
                    resultString += c;
                }
            }

            File.AppendAllText(pathSaveFile, resultString);

            return pathSaveFile;




        }
    }
}
