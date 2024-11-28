﻿using System.Reflection.Metadata.Ecma335;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.EvseevEI.Sprint5.Task3.V23.Lib
{
    public class DataService : ISprint5Task3V23
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask3.bin";

            double y = (1 + Math.Pow(x, 3)) / (Math.Pow(x, 2));
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
        
    

    }
}
