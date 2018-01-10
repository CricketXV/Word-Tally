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
				{
					string currentLine = sr.ReadLine ();
					currentLine.ToLower ();
					string stripped = ("");
					foreach (char c in currentLine)
					{
						if(c > 96 && c < 123 || c == 32 )
						{
							stripped = string.Join(stripped, c);

						}
						Console.Write (stripped);
					}
					string[] words = currentLine.Split (' ');

				}
			}  
        }
    }
}