
using eStudioLib;


namespace eStudioCL
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var library = new PartLibrary();
			
			var circuit = new Circuit();

			var resistorDef = library.Parts.OfType<ResistorDefinition>().First();
			var r1 = new PartInstance("R1", resistorDef) { Value = 1000 };
			r1.ConnectPin(1, "N001");
			r1.ConnectPin(2, "N002");
			circuit.AddPart(r1);

			var chipDef = library.Parts.OfType<ChipDefinition>().First();
			var u1 = new PartInstance("U1", chipDef);
			u1.ConnectPin(1, "VCC");
			u1.ConnectPin(2, "GND");
			u1.ConnectPin(3, "RESET_LINE");
			u1.ConnectPin(4, "N002");
			circuit.AddPart(u1);

			var chip7400Def = library.PartDict["7400"];
			var u2 = new PartInstance("U2", chip7400Def);
			u2.ConnectPin(14, "VCC");
			u2.ConnectPin(7, "GND");
			circuit.AddPart(u2);

			Chip6809Definition chip6809Def = (Chip6809Definition)library.PartDict["6809"];
			Console.WriteLine("----------------------------------------");
			chip6809Def.PrintChip();
			Console.WriteLine("----------------------------------------");
			var u3 = new PartInstance("U3", chip6809Def);
			circuit.AddPart(u3);

			Chip6883Definition chip6883Def = (Chip6883Definition)library.PartDict["6883"];
			Console.WriteLine("----------------------------------------");
			chip6883Def.PrintChip();
			Console.WriteLine("----------------------------------------");
			var u4 = new PartInstance("U4", chip6883Def);
			circuit.AddPart(u4);

			// Display
			foreach (var instance in circuit.Instances)
			{
				Console.WriteLine(instance);
			}
		}
	}
}
