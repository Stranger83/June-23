using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalException
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				while (true)
			{
				int n = int.Parse(Console.ReadLine());
				
					if (n < 0)
					{
						throw new PersonalException();
					}
					Console.WriteLine(n);
			}
			}
			catch (PersonalException pe)
			{
				Console.WriteLine(pe.Message);
			}
		}
	}
}
