using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml;

namespace eLib
{
	public class Project : XmlNode
	{
		public List<Circuit> Circuits { get; } = new List<Circuit>();

		public Project(XmlNode parent = null) 
			: base(parent)
		{

		}

		public void AddCircuit(Circuit circuit) 
		{
			this.Circuits.Add(circuit);
		}

		public void ReadXmlFile(string xmlPath = null) 
		{
			FileStream fs = new FileStream(xmlPath, FileMode.Open, FileAccess.Read);
			
			XmlTextReader reader = new XmlTextReader(fs);

			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Whitespace) continue;

				// check for EOF
				if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName == this.XmlTag)
					break;

				if (reader.NodeType == XmlNodeType.Element && reader.LocalName == this.XmlTag)
				{
					// _name = reader.GetAttribute("ID"); // JAR_NOTE: name is passed on creation .... 
					this.ReadXml(reader);
				}
			}

			reader.Close();
			fs.Close();
		}

		public void WriteXmlFile(string xmlPath) 
		{
			string xmlFolder = Path.GetDirectoryName(xmlPath);

			if (!Directory.Exists(xmlFolder))
				Directory.CreateDirectory(xmlFolder);

			FileStream fs = new FileStream(xmlPath, FileMode.Create, FileAccess.Write);
			XmlTextWriter writer = new XmlTextWriter(fs, Encoding.UTF8);
			writer.Formatting = Formatting.Indented;
			this.WriteXml(writer);
			writer.Close();
			fs.Close();
		}
	}
}
