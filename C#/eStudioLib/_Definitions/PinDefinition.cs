namespace eLib
{
	public class PinDefinition
	{
		public int Number { get; }
		public string Name { get; }

		public PinDefinition(int number, string name)
		{
			this.Number = number;
			this.Name = name;
		}

		public override string ToString() => $"{Number}:{Name}";
	}
}
