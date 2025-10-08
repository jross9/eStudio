namespace eLib
{
	public class TransistorDefinition : PartDefinition
	{
		public TransistorDefinition() : base("Transistor", "Q")
		{
			this.Pins.Add(new PinDefinition(1, "Collector"));
			this.Pins.Add(new PinDefinition(2, "Base"));
			this.Pins.Add(new PinDefinition(3, "Emitter"));
		}
	}
}
