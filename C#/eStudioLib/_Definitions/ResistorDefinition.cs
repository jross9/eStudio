namespace eLib
{
	public class ResistorDefinition : PartDefinition
	{
		public ResistorDefinition() : base("Resistor", "R")
		{
			this.Pins.Add(new PinDefinition(1, "A"));
			this.Pins.Add(new PinDefinition(2, "B"));
		}
	}
}
