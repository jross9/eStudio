namespace eLib.TTL
{
	public class TTL_74273_Definition : ChipDefinition
	{
		public TTL_74273_Definition()
			: base("74273", "U", null)
		{
			this.Pins.Add(new PinDefinition(1, "CLRn", PinType.INPUT));
			this.Pins.Add(new PinDefinition(2, "1Q", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(3, "1D", PinType.INPUT));
			this.Pins.Add(new PinDefinition(4, "2D", PinType.INPUT));
			this.Pins.Add(new PinDefinition(5, "2Q", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(6, "3Q", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(7, "3D", PinType.INPUT));
			this.Pins.Add(new PinDefinition(8, "4D", PinType.INPUT));
			this.Pins.Add(new PinDefinition(9, "4Q", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(10, "GND", PinType.GROUND));
			this.Pins.Add(new PinDefinition(11, "CLK", PinType.INPUT));
			this.Pins.Add(new PinDefinition(12, "5Q", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(13, "5D", PinType.INPUT));
			this.Pins.Add(new PinDefinition(14, "6D", PinType.INPUT));
			this.Pins.Add(new PinDefinition(15, "6Q", PinType.INPUT));
			this.Pins.Add(new PinDefinition(16, "7Q", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(17, "7D", PinType.INPUT));
			this.Pins.Add(new PinDefinition(18, "8D", PinType.INPUT));
			this.Pins.Add(new PinDefinition(19, "8Q", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(20, "VCC", PinType.POWER));
		}
	}
}
