namespace eLib.TTL
{
	public class TTL74138Definition : ChipDefinition
	{
		public TTL74138Definition()
			: base("74138", "U", null)
		{
			this.Pins.Add(new PinDefinition(1, "A", PinType.INPUT));
			this.Pins.Add(new PinDefinition(2, "B", PinType.INPUT));
			this.Pins.Add(new PinDefinition(3, "C", PinType.INPUT));
			this.Pins.Add(new PinDefinition(4, "G2An", PinType.INPUT));
			this.Pins.Add(new PinDefinition(5, "G2Bn", PinType.INPUT));
			this.Pins.Add(new PinDefinition(6, "G1", PinType.INPUT));
			this.Pins.Add(new PinDefinition(7, "GND", PinType.GROUND));
			this.Pins.Add(new PinDefinition(8, "Y7", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(9, "Y6", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(10, "Y5", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(11, "Y4", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(12, "Y3", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(13, "Y2", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(14, "Y1", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(15, "Y0", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(16, "VCC", PinType.POWER));
		}
	}
}
