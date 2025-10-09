namespace eLib.CPU
{
	public class MC6809_Definition : ChipDefinition
	{
		public MC6809_Definition()
			: base("6809", "U", new List<string> {
				"VSS", "NMIn", "IRQn", "FIRQn", "BS", "BA", "VCC", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10", "A11", "A12",
				"A13", "A14", "A15", "D7", "D6", "D5", "D4", "D3", "D2", "D1", "D0", "RWn", "Busy", "E", "Q", "AVMA", "RESETn", "LIC", "TSC", "HALTn"
			})
		{
		}
	}
}
