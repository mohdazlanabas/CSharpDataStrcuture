using System;
using System.Collections;

namespace HashDictFile
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Hashy();
            Dicty();

        }
        public static void Dicty()
        {
            Console.WriteLine("\nDictionary Key can only be int\n");
            Dictionary<int, string> My_dict1 = new Dictionary<int, string>();
            My_dict1.Add(0, "l");
            My_dict1.Add(1, "m");
            My_dict1.Add(2, "n");
            My_dict1.Add(3, "o");
            My_dict1.Add(4, "p");
            My_dict1.Add(5, "q");
            My_dict1.Add(6, "r");
            My_dict1.Add(7, "s");
            My_dict1.Add(8, "t");
            My_dict1.Add(9, "u");
            My_dict1.Add(10, "v");
            foreach (KeyValuePair<int, string> y in My_dict1)
            {
                Console.WriteLine("keys={0} values={1}", y.Key, y.Value);
            }
        }

            public static void Hashy()
        {
            Console.WriteLine("Hash Table, key can be string\n" );
            Hashtable HT = new Hashtable();
            HT.Add(0, "a");
            HT.Add(1, "b");
            HT.Add(2, "c");
            HT.Add(3, "d");
            HT.Add(4, "e");
            HT.Add(5, "f");
            HT.Add(6, "g");
            HT.Add(7, "h");
            HT.Add(8, "i");
            HT.Add(9, "j");
            HT.Add(10, "k");
            foreach (DictionaryEntry x in HT)
            {
                Console.WriteLine("keys={0} values={1}", x.Key, x.Value);
            }
        }


    }
}