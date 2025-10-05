public class PinConnection
{
	public PinDefinition Pin { get; }
	public string Node { get; set; }

	public PinConnection(PinDefinition pin, string node)
	{
		this.Pin = pin;
		this.Node = node;
	}

	public override string ToString() => $"{Pin.Name}->{Node}";
}
