namespace Jarvis
{
	partial class Program
	{
		class Leg
		{
			public int EnergyCons { get; set; }
			public int Strength { get; set; }
			public int Speed { get; set; }

			public override string ToString()
			{
				string result = "";
				result += "#Leg:\r\n";
				result += "###Energy consumption: " + EnergyCons + "\r\n";
				result += "###Strength: " + Strength + "\r\n";
				result += "###Speed: " + Speed + "\r\n";
				return result;
			}
		}
	}
}
