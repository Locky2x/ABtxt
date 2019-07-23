using System;
using System.IO;
using System.Text;

namespace ABtxt
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\Users\user\source\repos\ABtxt\1.txt", Encoding.Default);
            char[] str = reader.ReadLine().ToCharArray();
            string a = Convert.ToString(str[0]);
            string b = "";
            for (int i = 1; i < str.Length; i++)
            {
                if (Convert.ToString(str[i]) == " ") {
                    for (int j = 1; j < i; j++)
                    {
                        a = a + Convert.ToString(str[j]);
                    }
                    for (int j = i+1; j < str.Length; j++)
                    {
                        b = b + Convert.ToString(str[j]);
                    }
                }
            }
            int f = 0;
            f = Convert.ToInt32(Math.Pow(10, 9));
            if (Convert.ToInt32(a) > f)
            {
                Console.WriteLine("a > 10^9");
                a = "Null";
            }
            if (Convert.ToInt32(b) > f)
            {
                Console.WriteLine("b > 10^9");
                b = "Null";
            }
            int c = 0, d = 0, e = 0;
            if (a!="Null")
            {
                if (b != "Null") {
                    c = Convert.ToInt32(a);
                    d = Convert.ToInt32(b);
                    e = c + d;
                }
            }
            StreamWriter writer = new StreamWriter(@"C:\Users\user\source\repos\ABtxt\2.txt", false);
            writer.WriteLine("REZULT = "+e);
            writer.Close();
            reader.Close();
        }
    }
}
