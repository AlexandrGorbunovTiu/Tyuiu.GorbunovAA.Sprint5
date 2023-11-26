using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.GorbunovAA.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            string strY = strX.Replace("сс", "9");
            int count = strY.Count(i => i == '9');
            return count;
        }
        
    }
}
