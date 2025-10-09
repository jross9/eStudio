namespace eLib.TTL 
{
	public class TTL_7402_Definition : ChipDefinition
	{
		public TTL_7402_Definition()
			: base("7402", "U", null)
		{
			this.Pins.Add(new PinDefinition(1, "1Y", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(2, "1A", PinType.INPUT));
			this.Pins.Add(new PinDefinition(3, "1B", PinType.INPUT));
			this.Pins.Add(new PinDefinition(4, "2Y", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(5, "2A", PinType.INPUT));
			this.Pins.Add(new PinDefinition(6, "2B", PinType.INPUT));
			this.Pins.Add(new PinDefinition(7, "GND", PinType.GROUND));
			this.Pins.Add(new PinDefinition(8, "3A", PinType.INPUT));
			this.Pins.Add(new PinDefinition(9, "3B", PinType.INPUT));
			this.Pins.Add(new PinDefinition(10, "3Y", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(11, "4A", PinType.INPUT));
			this.Pins.Add(new PinDefinition(12, "4B", PinType.INPUT));
			this.Pins.Add(new PinDefinition(13, "4Y", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(14, "VCC", PinType.POWER));
		}
	}
}
