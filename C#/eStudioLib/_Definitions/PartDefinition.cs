namespace eStudioLib
{
	public abstract class PartDefinition
	{
		public string Name { get; }
		public string Symbol { get; }   // e.g., "R", "C", "L", "Q"

		public List<PinDefinition> Pins { get; } = new List<PinDefinition>();

		protected PartDefinition(string name, string symbol)
		{
			this.Name = name;
			this.Symbol = symbol;
		}
	}
}
