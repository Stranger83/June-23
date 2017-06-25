namespace Jarvis
{
	partial class Program
	{
		class Torso
		{
			public int EnergyCons { get; set; }
			public double ProcessorSize { get; set; }
			public string Material { get; set; }
			public override string ToString()
			{
				string result = "";
				result += "#Torso:\r\n";
				result += "###Energy consumption: " + EnergyCons + "\r\n";
				result += $"###Processor size: {ProcessorSize:f1}\r\n";
				result += "###Corpus material: " + Material + "\r\n";
				return result;
			}
		}
	}
}
