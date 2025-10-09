namespace eLib
{

	public class PartLibrary
	{
		public List<PartDefinition> Parts { get; } = new List<PartDefinition>();
		public Dictionary<string, PartDefinition> PartDict { get; } = new Dictionary<string, PartDefinition>();

		public PartLibrary()
		{
			// Build master list

			PartDefinition part = null;

			part = new ResistorDefinition();
			this.Parts.Add(part);
			this.PartDict.Add("Resistor", part);

			part = new CapacitorDefinition();
			this.Parts.Add(part);
			this.PartDict.Add("Capacitor", part);

			part = new InductorDefinition();
			this.Parts.Add(part);
			this.PartDict.Add("Inductor", part);

			part = new TransistorDefinition();
			this.Parts.Add(part);
			this.PartDict.Add("Transistor", part);

			//part = new ChipDefinition("555", "U", new List<string> { "VCC", "GND", "RESET", "OUT" });
			//this.Parts.Add(part);
			//this.PartDict.Add("555", part);

			part = new TTL.TTL_7400_Definition();
			this.Parts.Add(part);
			this.PartDict.Add("7400", part);

			part = new TTL.TTL_7402_Definition();
			this.Parts.Add(part);
			this.PartDict.Add("7402", part);

			part = new TTL.TTL_74138_Definition();
			this.Parts.Add(part);
			this.PartDict.Add("74138", part);

			part = new TTL.TTL_74244_Definition();
			this.Parts.Add(part);
			this.PartDict.Add("74244", part);

			part = new TTL.TTL_74273_Definition();
			this.Parts.Add(part);
			this.PartDict.Add("74273", part);

			part = new CPU.MC6809_Definition();
			this.Parts.Add(part);
			this.PartDict.Add("6809", part);

			part = new CPU.MC6883_Definition();
			this.Parts.Add(part);
			this.PartDict.Add("6883", part);

			part = new VDG.MC6847_Definition();
			this.Parts.Add(part);
			this.PartDict.Add("6847", part);

			part = new ROM.MCM68A364Definition();
			this.Parts.Add(part);
			this.PartDict.Add("MCM68A364", part);
		}
	}
}
