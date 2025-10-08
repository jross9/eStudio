using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Xml;

namespace eLib
{
	public class XmlNode
	{
		public XmlNode Parent { get { return _parent; } }
		public virtual string XmlTag { get { throw new NoXmlTagException("No XML Tag! -> " + this.GetType()); } }

		public XmlNode(XmlNode parent = null)
		{
			if (parent != null)
			{
				_parent = parent;
			}
		}

		public virtual void ReadXml(string xml)
		{
			using (StringReader sr = new StringReader(xml))
			{
				using (XmlReader reader = XmlReader.Create(sr))
				{
					reader.Read();
					while (reader.NodeType == XmlNodeType.Whitespace)
						reader.Read();

					if (reader.NodeType != XmlNodeType.Element || reader.LocalName != this.XmlTag)
						throw new MalFormedXmlTagException("Bad formed XML string, must be node [" + this.XmlTag + "]");

					this.ReadXml(reader);
				}
			}
		}
		public virtual void ReadXml(XmlReader reader)
		{
			this.XmlReadAttributes(reader);

			if (reader.IsEmptyElement)
				return;

			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element)
					this.XmlReadNodes(reader);

				else if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName == this.XmlTag)
					break;
			}
		}
		public virtual void WriteXml(XmlTextWriter writer)
		{
			writer.WriteStartElement(this.XmlTag);
			this.XmlWriteAttributes(writer);
			this.XmlWriteNodes(writer);
			writer.WriteEndElement();
		}

		public virtual void XmlReadAttributes(XmlReader reader)
		{
		}
		public virtual void XmlReadNodes(XmlReader reader)
		{
			throw new UnknownNodeException("Unknown NODE -> [" + reader.LocalName + "]");
		}
		public virtual void XmlWriteAttributes(XmlTextWriter writer)
		{
		}
		public virtual void XmlWriteNodes(XmlTextWriter writer)
		{
		}

		protected XmlNode _parent;
	}

	public class NoParentException : Exception { public NoParentException(string msg) : base(msg) { } }

	public class NoXmlTagException : Exception { public NoXmlTagException(string msg) : base(msg) { } }

	public class UnknownNodeException : Exception { public UnknownNodeException(string msg) : base(msg) { } }

	public class MalFormedXmlTagException : Exception { public MalFormedXmlTagException(string msg) : base(msg) { } }
}
