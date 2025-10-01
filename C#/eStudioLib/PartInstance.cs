public class PartInstance
{
    public string InstanceName { get; set; }   // e.g., "R1", "C2"
    public PartDefinition Definition { get; } // Points to the master definition

	// Example instance-specific properties
	public double Value { get; set; }          // e.g., resistance in ohms, capacitance in farads

	public List<PinConnection> Connections { get; } = new List<PinConnection>();

	public PartInstance(string instanceName, PartDefinition definition)
	{
		this.InstanceName = instanceName;
		this.Definition = definition;

		// Initialize connections (nodes assigned later)
		foreach (var pin in definition.Pins)
		{
			Connections.Add(new PinConnection(pin, "UNCONNECTED"));
		}
	}

	public void ConnectPin(int pinNumber, string nodeName) 
	{
		var conn = Connections.First(c => c.Pin.Number == pinNumber);
		conn.Node = nodeName;
	}

	public override string ToString() 
	{
		string conns = string.Join(", ", Connections.Select(c => c.ToString()));
		return $"{InstanceName}: {Definition.Name} ({Definition.Symbol}) [Value={Value}] | {conns}";
	}
}

