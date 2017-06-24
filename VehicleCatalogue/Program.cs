using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCatalogue
{
	class Vehicle
	{
		public string Type { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public double Horsepower { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			List<Vehicle> allVehicles = GetAllVehicles();
			
			var command = Console.ReadLine();
			while (command != "Close the Catalogue")
			{
				PrintMatchingVehicle(command, allVehicles);
				command = Console.ReadLine();
			}

			var cars = allVehicles.Where(x => x.Type == "car").ToArray();
			var trucks = allVehicles.Where(x => x.Type == "truck").ToArray();
			var avHPCars = cars.Sum(x => x.Horsepower) / cars.Length;
			var avHPTrucks = trucks.Sum(x => x.Horsepower) / trucks.Length;

			Console.WriteLine("Cars have average horsepower of: {0:f2}.", cars.Length == 0 ? 0.00 : avHPCars);
			Console.WriteLine("Trucks have average horsepower of: {0:f2}.", trucks.Length == 0 ? 0.00 : avHPTrucks);

		}

		private static void PrintMatchingVehicle(string command, List<Vehicle> allVehicles)
		{
			foreach (var v in allVehicles)
			{
				if (v.Model == command)
				{
					var type = v.Type.First().ToString().ToUpper() + v.Type.Substring(1);
					Console.WriteLine($"Type: {type}");
					Console.WriteLine($"Model: {v.Model}");
					Console.WriteLine($"Color: {v.Color}");
					Console.WriteLine($"Horsepower: {v.Horsepower}");
				}
			}
		}

		private static List<Vehicle> GetAllVehicles()
		{
			var allVehicles = new List<Vehicle>();
			var input = Console.ReadLine();
			while (input != "End")
			{
				var tokens = input.Split(' ').ToArray();
				var type = tokens[0].ToLower();
				var model = tokens[1];
				var color = tokens[2];
				var horsepower = double.Parse(tokens[3]);
				Vehicle v = new Vehicle
				{
					Type = type,
					Model = model,
					Color = color,
					Horsepower = horsepower
				};
				allVehicles.Add(v);

				input = Console.ReadLine();
			}
			return allVehicles;
		}
	}
}
