using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.GorbunovAA.Sprint5.Task0.V13.Lib;

namespace Tyuiu.GorbunovAA.Sprint5.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\shura\source\repos\Tyuiu.GorbunovAA.Sprint5\Tyuiu.GorbunovAA.Sprint5.Task0.V13\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
