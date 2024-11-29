using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.EvseevEI.Sprint5.Task6.V2.Lib;
public class DataService : ISprint5Task6V2
{
    public int LoadFromDataFile(string path)
    {
        int count = 0;
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                line = line.ToUpper();
                for (int i = 0; i < line.Length; i++)
                {
                    char c = line[i];
                    if ((c >= 'А') && (c <= 'Я'))
                        count++;
                }
            }
        }
        return count;
    }
}

