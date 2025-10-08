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

			part = new ChipDefinition("555", "U", new List<string> { "VCC", "GND", "RESET", "OUT" });
			this.Parts.Add(part);
			this.PartDict.Add("555", part);

			part = new Chip7400Definition();
			this.Parts.Add(part);
			this.PartDict.Add("7400", part);

			part = new Chip6809Definition();
			this.Parts.Add(part);
			this.PartDict.Add("6809", part);

			part = new Chip6883Definition();
			this.Parts.Add(part);
			this.PartDict.Add("6883", part);
		}
	}
}
