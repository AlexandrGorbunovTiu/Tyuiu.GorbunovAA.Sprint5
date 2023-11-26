using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GorbunovAA.Sprint5.Task5.V11.Lib
{
    public class DataService : ISprint5Task5V11
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var i = Convert.ToDouble(line);
                    if (i % 2 != 0)
                    {
                        res = res * i;
                    }

                }
            }
            return res;
        }
    }
}
