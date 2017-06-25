namespace Jarvis
{
	partial class Program
	{
		class Head
		{
			public int EnergyCons { get; set; }
			public int IQ { get; set; }
			public string Material { get; set; }
			public override string ToString()
			{
				string result = "";
				result += "#Head:\r\n";
				result += "###Energy consumption: " + EnergyCons + "\r\n";
				result += "###IQ: " + IQ + "\r\n";
				result += "###Skin material: " + Material + "\r\n";
				return result;
			}

		}
	}
}
