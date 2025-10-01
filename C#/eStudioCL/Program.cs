using eStudioLib;

namespace eStudioCL
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var library = new PartLibrary();
			var circuit = new Circuit();

			// Grab the resistor definition from the library
			var resistorDef = library.Parts.OfType<ResistorDefinition>().First();

			// Create resistor instances
			circuit.AddPart(new PartInstance("R1", resistorDef, 1000, "N001", "N002"));
			circuit.AddPart(new PartInstance("R2", resistorDef, 2200, "N002", "N003"));

			// Display
			foreach (var instance in circuit.Instances)
			{
				Console.WriteLine(instance);
			}
		}
	}
}
