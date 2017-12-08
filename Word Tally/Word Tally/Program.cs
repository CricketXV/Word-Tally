using System;
using System.IO;
using System.Collections.Generic;


namespace Word_Tally
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("tallies.txt");
            string input = File.ReadAllText("passage.txt");
            input = input.ToLower();
            string passage = "";

            foreach (char c in input) {
                if (c >= 97 && c<= 122 || c == 32)
                {
                    passage += c;
                     
                }
            }
            string[] words = passage.Split(' ');
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            foreach ()
            {
                dictionary.Add("cool", 1);
                sw.WriteLine("{0}", pair.Key);
            }
            
            sw.Close();
        }
    }
}
