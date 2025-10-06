
namespace eStudioLib
{
	public class ChipDefinition : PartDefinition
	{
		public ChipDefinition(string name, string symbol, List<string> pinNames) : base(name, symbol)
		{
			int pinNum = 1;
			foreach (var pin in pinNames)
			{
				this.Pins.Add(new PinDefinition(pinNum++, pin));
			}
		}

		public void PrintChip()
		{
			Console.WriteLine("# Pins" + this.Pins.Count);

			int half_pins = this.Pins.Count / 2;
			Console.WriteLine("# Pins" + half_pins);

			for (int i = 0; i < half_pins; i++)
				Console.WriteLine(this.Pins[i].ToString());

			Console.WriteLine("----");

			for (int i = half_pins; i > 0; i--)
				Console.WriteLine(this.Pins[i+19].ToString());

			Console.WriteLine("----");
			for (int i = 0; i < half_pins; i++)
				Console.WriteLine(this.Pins[i].ToString() + "   " + this.Pins[39-i].ToString());
		}
	}
}

