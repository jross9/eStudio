using System.Xml;

namespace eLib
{
	public class PinConnection : XmlNode
	{
		public PinDefinition Pin { get; }
		public string Node { get; set; }

		public override string XmlTag => "Pin";

		public PinConnection(PinDefinition pin, string node, PartInstance parent = null)
			: base(parent)
		{
			this.Pin = pin;
			this.Node = node;
		}

		public override string ToString() => $"{Pin.Name}->{Node}";

		public override void XmlWriteAttributes(XmlTextWriter writer)
		{
			// base.XmlWriteAttributes(writer);

			writer.WriteAttributeString("Number", this.Pin.Number.ToString());
			writer.WriteAttributeString("Name", this.Pin.Name);
			writer.WriteAttributeString("NET", this.Node);
		}
	}
}