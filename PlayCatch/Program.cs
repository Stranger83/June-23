using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayCatch
{
	class Program
	{
		static void Main(string[] args)
		{
			List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
			byte exceptionCounter = 0;
			while (true)
			{
				if (exceptionCounter == 3)
				{
					break;
				}
				string[] input = Console.ReadLine().Split(' ');
				string command = input[0];
				switch (command)
				{
					case "Replace":
						try
						{
							nums.RemoveAt(int.Parse(input[1]));
							nums.Insert(int.Parse(input[1]), int.Parse(input[2]));
						} catch (ArgumentOutOfRangeException)
						{
							Console.WriteLine("The index does not exist!");
							exceptionCounter++;
						}
						catch (FormatException)
						{
							Console.WriteLine("The variable is not in the correct format!");
							exceptionCounter++;
						}
						break;
					case "Print":
						try
						{
							int start = int.Parse(input[1]);
							int end = int.Parse(input[2]);
							if (start < 0 || start >= nums.Count || end < 0 || end >= nums.Count)
							{
								throw new ArgumentOutOfRangeException();
							}
							else
							{
								for (int i = start; i <= end; i++)
								{
									Console.Write(nums[i] + ((i == end) ? "\r\n" : ", "));
								}
							}
						}										
						catch (ArgumentOutOfRangeException)
						{
							Console.WriteLine("The index does not exist!");
							exceptionCounter++;
						}
						catch (FormatException)
						{
							Console.WriteLine("The variable is not in the correct format!");
							exceptionCounter++;
						}
						
						break;
					case "Show":
						try
						{
							Console.WriteLine(nums[int.Parse(input[1])]);
						}
						catch (ArgumentOutOfRangeException)
						{
							Console.WriteLine("The index does not exist!");
							exceptionCounter++;
						}
						catch (FormatException)
						{
							Console.WriteLine("The variable is not in the correct format!");
							exceptionCounter++;
						}
						break;
				}
			}
			Console.WriteLine(string.Join(", ", nums));
		}
	}
}
