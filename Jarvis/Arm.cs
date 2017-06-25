namespace Jarvis
{
	partial class Program
	{
		class Arm
		{
			public int EnergyCons { get; set; }
			public int Reach { get; set; }
			public int FingerCount { get; set; }

			public override string ToString()
			{
				string result = "";
				result += "#Arm:\r\n";
				result += "###Energy consumption: " + EnergyCons + "\r\n";
				result += "###Reach: " + Reach + "\r\n";
				result += "###Fingers: " + FingerCount + "\r\n";
				return result;
			}
		}
	}
}
