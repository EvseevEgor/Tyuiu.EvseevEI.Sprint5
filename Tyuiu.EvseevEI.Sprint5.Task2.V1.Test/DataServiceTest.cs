using Tyuiu.EvseevEI.Sprint5.Task2.V1.Lib;
namespace Tyuiu.EvseevEI.Sprint5.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Evseevegor709icloud\source\repos\Tyuiu.EvseevEI.Sprint5\Tyuiu.EvseevEI.Sprint5.Task0.V19\bin\Debug\OutPutFileTask1.txt"; ;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}