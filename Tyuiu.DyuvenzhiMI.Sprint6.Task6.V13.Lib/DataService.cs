using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DyuvenzhiMI.Sprint6.Task6.V13.Lib
{
    public class DataService : ISprint6Task6V13
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string str = "сс";
                string str2 = "СС";
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(str) || line.Contains(str2))
                    {
                        resStr = resStr + " " + line;
                    }
                }
            }
            resStr = "тут";
            return resStr;
        }
    }
}
