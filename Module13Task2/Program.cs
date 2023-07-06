
namespace Module13Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader Readtxt = new StreamReader("C:\\Users\\Zver\\Desktop\\SkilF\\Text1.txt");
                string TxtAll = Readtxt.ReadToEnd();
                TxtAll = TxtAll.Replace("\n", " ");
                TxtAll = TxtAll.Replace("  ", " ");
                TxtAll = TxtAll.Trim();
                TxtAll = new string(TxtAll.Where(c => !char.IsPunctuation(c)).ToArray());
                
                string[] ArString = TxtAll.Split(new char[] {' '});
                Dictionary<string, int> dr = new Dictionary<string, int>();
                //Размещаем слова в словаре и подсчитываем частотность
                foreach (string s in ArString)
                {
                    if (s.Length > 0)
                        if (dr.Keys.Contains(s))
                        {
                            dr[s]++;
                        }
                        else
                        {
                            dr.Add(s, 1);
                        }                          
                }

                string S = ""; int k = 0;
                foreach (KeyValuePair<string, int> kk in dr.OrderByDescending(x => x.Value))
                {
                    S += "Слово << " + kk.Key + " >> встречается " + kk.Value.ToString() + " раз\n";
                    k++;
                    if (k == 10) break;
                }
                Console.WriteLine(S);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}