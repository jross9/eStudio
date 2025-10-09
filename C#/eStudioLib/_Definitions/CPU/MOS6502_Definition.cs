namespace eLib.CPU 
{
	public class MOS6502_Definition : ChipDefinition 
	{
		public MOS6502_Definition() 
			: base("MOS6502", "U", null) 
		{
				Pins.Add(new PinDefinition(1, "VSS", PinType.GROUND));
				Pins.Add(new PinDefinition(2, "RDY", PinType.INPUT));
				Pins.Add(new PinDefinition(3, "o1OUT", PinType.OUTPUT));
				Pins.Add(new PinDefinition(4, "IRQn", PinType.INPUT));
				Pins.Add(new PinDefinition(5, "NC", PinType.UNDEF));
				Pins.Add(new PinDefinition(6, "NMIn", PinType.INPUT));
				Pins.Add(new PinDefinition(7, "SYNC", PinType.OUTPUT));
				Pins.Add(new PinDefinition(8, "VCC", PinType.POWER));
				Pins.Add(new PinDefinition(9, "A0", PinType.OUTPUT));
				Pins.Add(new PinDefinition(10, "A1", PinType.OUTPUT));
				Pins.Add(new PinDefinition(11, "A2", PinType.OUTPUT));
				Pins.Add(new PinDefinition(12, "A3", PinType.OUTPUT));
				Pins.Add(new PinDefinition(13, "A4", PinType.OUTPUT));
				Pins.Add(new PinDefinition(14, "A5", PinType.OUTPUT));
				Pins.Add(new PinDefinition(15, "A6", PinType.OUTPUT));
				Pins.Add(new PinDefinition(16, "A7", PinType.OUTPUT));
				Pins.Add(new PinDefinition(17, "A8", PinType.OUTPUT));
				Pins.Add(new PinDefinition(18, "A9", PinType.OUTPUT));
				Pins.Add(new PinDefinition(19, "A10", PinType.OUTPUT));
				Pins.Add(new PinDefinition(20, "A11", PinType.OUTPUT));
				Pins.Add(new PinDefinition(21, "VSS", PinType.OUTPUT));
				Pins.Add(new PinDefinition(22, "A12", PinType.OUTPUT));
				Pins.Add(new PinDefinition(23, "A13", PinType.OUTPUT));
				Pins.Add(new PinDefinition(24, "A14", PinType.OUTPUT));
				Pins.Add(new PinDefinition(25, "A15", PinType.OUTPUT));
				Pins.Add(new PinDefinition(26, "D7", PinType.INOUT));
				Pins.Add(new PinDefinition(27, "D6", PinType.INOUT));
				Pins.Add(new PinDefinition(28, "D5", PinType.INOUT));
				Pins.Add(new PinDefinition(29, "D4", PinType.INOUT));
				Pins.Add(new PinDefinition(30, "D3", PinType.INOUT));
				Pins.Add(new PinDefinition(31, "D2", PinType.INOUT));
				Pins.Add(new PinDefinition(32, "D1", PinType.INOUT));
				Pins.Add(new PinDefinition(33, "D0", PinType.INOUT));
				Pins.Add(new PinDefinition(34, "RWn", PinType.OUTPUT));
				Pins.Add(new PinDefinition(35, "NC", PinType.UNDEF));
				Pins.Add(new PinDefinition(36, "NC", PinType.UNDEF));
				Pins.Add(new PinDefinition(37, "o0IN", PinType.INPUT));
				Pins.Add(new PinDefinition(38, "SO", PinType.INPUT));
				Pins.Add(new PinDefinition(39, "o2OUT", PinType.OUTPUT));
				Pins.Add(new PinDefinition(40, "RESn", PinType.UNDEF));
		}
	}
}
