namespace eStudioLib
{
	public class Chip6883Definition : ChipDefinition
	{
		public Chip6883Definition()
			: base("6883", "U", new List<string> {
				"A11", "A10", "A9", "A8", "OscIn", "OscOut", "VClk", "DA0", "HSn", "WEn", "CASn", "RAS0n", "Q", "E", "RWn", "A0", "A1", "A2", "A3", "GND",
				"A4", "A5", "A6", "A7", "S2", "S1", "S0", "Z0", "Z1", "Z2", "Z3", "Z4", "Z5", "Z6", "Z7/RAS1n", "A15", "A14", "A13", "A12", "VCC"
			})
		{
		}
	}
}
