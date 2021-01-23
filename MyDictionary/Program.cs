using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> dict = new MyDictionary<string, int>();

            dict.Add("a", 1);
            dict.Add("b", 2);
            dict.Add("c", 4);
            dict.Add("d", 8);

            /*
            Console.WriteLine(dict.GetValue("a"));
            Console.WriteLine(dict.GetValue("b"));
            Console.WriteLine(dict.GetValue("c"));
            Console.WriteLine(dict.GetValue("d"));
            */
        }
    }
}
