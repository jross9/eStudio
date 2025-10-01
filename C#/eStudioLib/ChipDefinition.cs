public class ChipDefinition : PartDefinition
{
	public ChipDefinition(string name, string symbol, List<string> pinNames) : base(name, symbol)
	{
		int pinNum = 1;
		foreach (var pin in pinNames)
		{
			Pins.Add(new PinDefinition(pinNum++, pin));
		}
	}
}

public class Chip7400Definition : ChipDefinition
{
	public Chip7400Definition() : base("7400", "U", new List<string> { "1A", "1B", "1Y", "2A", "2B", "2Y", "GND", "3Y", "3A", "3B", "4Y", "4A", "4B", "VCC" }) { }
}
