
namespace eLib
{
	public class ChipDefinition : PartDefinition
	{
		public ChipDefinition(string name, string symbol, List<string> pinNames) : base(name, symbol)
		{
			if (pinNames != null)
			{
				int pinNum = 1;
				foreach (var pin in pinNames)
				{
					this.Pins.Add(new PinDefinition(pinNum++, pin));
				}
			}
		}

		public void PrintChip()
		{
			Console.WriteLine("Chip: " + this.Name);
			// Console.WriteLine("# Pins" + this.Pins.Count);
			int half_pins = this.Pins.Count / 2;
			// Console.WriteLine("# Pins" + half_pins);

			Console.WriteLine("----");
			for (int i = 0; i < half_pins; i++)
				Console.WriteLine(this.Pins[i].ToString() + "   " + this.Pins[this.Pins.Count - i - 1].ToString());
		}
	}
}

