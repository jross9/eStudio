using System.Xml;

namespace eLib
{
	public class PartInstance : XmlNode
	{
		public string Designator { get; set; }   // e.g., "R1", "C2"
		public PartDefinition Definition { get; } // Points to the master definition

		// Example instance-specific properties
		public double Value { get; set; }          // e.g., resistance in ohms, capacitance in farads

		public List<PinConnection> Connections { get; } = new List<PinConnection>();

		public override string XmlTag => "Part";

		public PartInstance(string instanceName, PartDefinition definition, Circuit circuit = null)
			: base(circuit)
		{
			this.Designator = instanceName;
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
			return $"{Designator}: {Definition.Name} ({Definition.Symbol}) [Value={Value}] | {conns}";
		}

		public override void XmlWriteAttributes(XmlTextWriter writer)
		{
			// base.XmlWriteAttributes(writer);

			writer.WriteAttributeString("Designator", this.Designator);
			writer.WriteAttributeString("Part", this.Definition.Name);
		}

		public override void XmlWriteNodes(XmlTextWriter writer)
		{
			// base.XmlWriteNodes(writer);

			foreach (var pin in Connections) 
				pin.WriteXml(writer);
		}
	}
}