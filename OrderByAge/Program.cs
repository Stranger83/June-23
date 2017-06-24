using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByAge
{
	class Person
	{
		public string Name { get; set; }
		public string ID { get; set; }
		public int Age { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>();
			var input = Console.ReadLine();

			while (input != "End")
			{
				var tokens = input.Split(' ').ToArray();
				var name = tokens[0];
				var id = tokens[1];
				var age = int.Parse(tokens[2]);
				Person p = new Person {
					Name = name,
					ID = id,
					Age = age
				};
				people.Add(p);

				input = Console.ReadLine();
			}

			people = people.OrderBy(x => x.Age).ToList();
			foreach (var person in people)
			{
				Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
			}

		}
	}
}
