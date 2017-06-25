using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteToFile
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = File.ReadAllText("sample_text.txt");

			string output = string.Join("", text.Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "").Replace(":", ""));
			File.WriteAllText("output.txt", output);
		}
	}
}
