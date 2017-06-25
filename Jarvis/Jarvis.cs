using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarvis
{
	partial class Program
	{
		class Jarvis
		{
			public long Energy { get; set; }
			public Head Head { get; set; }
			public Torso Torso { get; set; }
			public List<Arm> Arms { get; set; }
			public List<Leg> Legs { get; set; }
			public void AddHead(Head headInput)
			{
				if (Head == null)
				{
					Head = headInput;
				}
				if (headInput.EnergyCons < Head.EnergyCons)
				{
					Head = headInput;
				}
			}
			public void AddTorso(Torso torsoInput)
			{
				if (Torso == null)
				{
					Torso = torsoInput;
				}
				if (torsoInput.EnergyCons < Torso.EnergyCons)
				{
					Torso = torsoInput;
				}
			}
			public void AddArm(Arm armInput)
			{
				if (Arms == null)
				{
					Arms = new List<Arm>();
				}
				if (Arms.Count < 2)
				{
					Arms.Add(armInput);
				}
				else
				{
					for (int i = 0; i < Arms.Count; i++)
					{
						if (armInput.EnergyCons < Arms[i].EnergyCons)
						{
							Arms.RemoveAt(i);
							Arms.Add(armInput);
						}
					}
				}
			}
			public void AddLeg(Leg legInput)
			{
				if (Legs == null)
				{
					Legs = new List<Leg>();
				}
				if (Legs.Count < 2)
				{
					Legs.Add(legInput);
				}
				else
				{
					for (int i = 0; i < Legs.Count; i++)
					{
						if (legInput.EnergyCons < Legs[i].EnergyCons)
						{
							Legs.RemoveAt(i);
							Legs.Add(legInput);
						}
					}
				}
			}
			public override string ToString()
			{
				if (Head == null || Torso == null || Arms.Count < 2 || Legs.Count < 2)
				{
					return "We need more parts!";
				}
				long totalEnergy = 0;
				totalEnergy += Head.EnergyCons;
				totalEnergy += Torso.EnergyCons;
				totalEnergy += Arms.Select(x => long.Parse(x.EnergyCons.ToString())).Sum();
				totalEnergy += Legs.Select(x => long.Parse(x.EnergyCons.ToString())).Sum();

				if (totalEnergy > Energy)
				{
					return "We need more power!";
				}

				StringBuilder sb = new StringBuilder();
				sb.Append("Jarvis:\r\n");
				sb.Append(Head.ToString());
				sb.Append(Torso.ToString());
				foreach (var arm in Arms.OrderBy(x => x.EnergyCons))
				{
					sb.Append(arm.ToString());
				}
				foreach (var leg in Legs.OrderBy(x => x.EnergyCons))
				{
					sb.Append(leg.ToString());
				}
				

				return sb.ToString();
			}

		}
	}
}
