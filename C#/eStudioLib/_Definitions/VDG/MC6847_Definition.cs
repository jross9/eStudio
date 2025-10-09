namespace eLib.VDG
{
	public class MC6847_Definition : ChipDefinition
	{
		public MC6847_Definition()
			: base("6847", "U", null)
		{
			this.Pins.Add(new PinDefinition(1, "VSS", PinType.GROUND));
			this.Pins.Add(new PinDefinition(2, "DD6", PinType.INPUT));
			this.Pins.Add(new PinDefinition(3, "DD0", PinType.INPUT));
			this.Pins.Add(new PinDefinition(4, "DD1", PinType.INPUT));
			this.Pins.Add(new PinDefinition(5, "DD2", PinType.INPUT));
			this.Pins.Add(new PinDefinition(6, "DD3", PinType.INPUT));
			this.Pins.Add(new PinDefinition(7, "DD4", PinType.INPUT));
			this.Pins.Add(new PinDefinition(8, "DD5", PinType.INPUT));
			this.Pins.Add(new PinDefinition(9, "CHB", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(10, "oB", PinType.AOUT));
			this.Pins.Add(new PinDefinition(11, "oA", PinType.AOUT));
			this.Pins.Add(new PinDefinition(12, "MSn", PinType.INPUT));
			this.Pins.Add(new PinDefinition(13, "DA5", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(14, "DA6", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(15, "DA7", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(16, "DA8", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(17, "VCC", PinType.POWER));
			this.Pins.Add(new PinDefinition(18, "DA9", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(19, "DA10", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(20, "DA11", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(21, "DA12", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(22, "DA0", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(23, "DA1", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(24, "DA2", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(25, "DA3", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(26, "DA4", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(27, "GM2", PinType.INPUT));
			this.Pins.Add(new PinDefinition(28, "Y", PinType.AOUT));
			this.Pins.Add(new PinDefinition(29, "GM1", PinType.INPUT));
			this.Pins.Add(new PinDefinition(30, "GM0", PinType.INPUT));
			this.Pins.Add(new PinDefinition(31, "INTn/EXT", PinType.INPUT));
			this.Pins.Add(new PinDefinition(32, "INV", PinType.INPUT));
			this.Pins.Add(new PinDefinition(33, "CLK", PinType.INPUT));
			this.Pins.Add(new PinDefinition(34, "AnS", PinType.INPUT));
			this.Pins.Add(new PinDefinition(35, "AnG", PinType.INPUT));
			this.Pins.Add(new PinDefinition(36, "RPn", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(37, "FSn", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(38, "HSn", PinType.OUTPUT));
			this.Pins.Add(new PinDefinition(39, "CSS", PinType.INPUT));
			this.Pins.Add(new PinDefinition(40, "DD7", PinType.INPUT));
		}
	}
}
