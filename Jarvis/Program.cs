using System;
using System.Threading.Tasks;

namespace Jarvis
{
	partial class Program
	{
		static void Main(string[] args)
		{
			long jarvisEnergy = long.Parse(Console.ReadLine());

			Jarvis jarvis = new Jarvis()
			{
				Energy = jarvisEnergy
			};
			while (true)
			{
				var input = Console.ReadLine().Split(' ');
				if (input[0] == "Assemble!")
				{
					break;
				}
				switch (input[0])
				{
					case "Head":
						Head head = new Head()
						{
							EnergyCons = int.Parse(input[1]),
							IQ = int.Parse(input[2]),
							Material = input[3]
						};
						jarvis.AddHead(head);
						break;
					case "Torso":
						Torso torso = new Torso()
						{
							EnergyCons = int.Parse(input[1]),
							ProcessorSize = double.Parse(input[2]),
							Material = input[3]
						};
						jarvis.AddTorso(torso);
						break;
					case "Arm":
						Arm arm = new Arm()
						{
							EnergyCons = int.Parse(input[1]),
							Reach = int.Parse(input[2]),
							FingerCount = int.Parse(input[3])
						};
						jarvis.AddArm(arm);
						break;
					case "Leg":
						Leg leg = new Leg()
						{
							EnergyCons = int.Parse(input[1]),
							Strength = int.Parse(input[2]),
							Speed = int.Parse(input[3])
						};
						jarvis.AddLeg(leg);
						break;					
				}
			}
			Console.WriteLine(jarvis.ToString());
		}
	}
}
