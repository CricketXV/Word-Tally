using System;
using System.IO;
using System.Collections.Generic;


namespace Word_Tally
{
	 class Program
	 {
	   static void Main(string[] args)
	   {
			StreamReader sr = new StreamReader ("passage.txt");
			StreamWriter sw = new StreamWriter("tallies.txt");

			while (!sr.EndOfStream)
			{
				string currentLine = sr.ReadLine ();
				currentLine = currentLine.ToLower ();
				string stripped = "";

			
				foreach (char c in currentLine) 
				{
					if (c >= 97 && c <= 122 || c == 32) 
					{
						stripped += c;
					}
				}
//				Console.WriteLine (stripped);
				String[] words = stripped.Split (' ');
				SortedDictionary <string, int> dictionary = new SortedDictionary <string, int> ();
//			

				for (int k = 0; k < words.Length; k++) 
				{
					if (words [k] == null) 
					{
						Array.remove (words, k);
					}
					Console.WriteLine (words[k]);
				}

			}  
	   }
	}
}