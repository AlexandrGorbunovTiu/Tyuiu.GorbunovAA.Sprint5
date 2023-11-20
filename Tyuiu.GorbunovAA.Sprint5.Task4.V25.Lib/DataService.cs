using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.GorbunovAA.Sprint5.Task4.V25.Lib
{
    public class DataService : ISprint5Task4V25
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            var x = Convert.ToDouble(strX);
            double res = Math.Round((Math.Pow(x,4) + Math.Cos(x)) * Math.Sin(x), 3);
            return res;
        }
    }
}
