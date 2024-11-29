using System;
using System.IO;
using Tyuiu.EvseevEI.Sprint5.Task7.V22.Lib;
namespace Tyuiu.EvseevEI.Sprint5.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.EvseevEI.EvseevEgor\Tyuiu.EvseevEI.Sprint5.Task7.V22\bin\Debug\InPutDataFileTask7V22.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}