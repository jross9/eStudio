namespace eLib
{
	public class PinDefinition
	{
		public int Number { get; }
		public string Name { get; }
		public PinType Type { get; }

		public PinDefinition(int number, string name, PinType type = PinType.UNDEF)
		{
			this.Number = number;
			this.Name = name;
			this.Type = type;
		}

		public override string ToString() => $"{Number}:{Name}";
	}
}
