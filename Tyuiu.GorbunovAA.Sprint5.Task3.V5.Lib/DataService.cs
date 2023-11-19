using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;



namespace Tyuiu.GorbunovAA.Sprint5.Task3.V5.Lib
{
    public class DataService : ISprint5Task3V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            double y = 2 * x * x * x + 0.5 * x * x - 3.5 * x + 2;
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));

            }

            return path;
        }
    }
}
