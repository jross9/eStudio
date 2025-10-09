using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLib
{
	public class MC6847Definition : ChipDefinition
	{
		public MC6847Definition()
			: base("6847", "U", new List<string> {
				"VSS", "DD6", "DD0", "DD1", "DD2", "DD3", "DD4", "DD5", "CHB", "oB", "oA", "MSn", "DA5", "DA6", "DA7", "DA8", "VCC", "DA9", "DA10", "DA11",
				"DA12", "DA0", "DA1", "DA2", "DA3", "DA4", "GM2", "Y", "GM1", "GM0", "INTn/EXT", "INV", "CLK", "AnS", "AnG", "RPn", "FSn", "HSn", "CSS", "DD7" })
		{
		}
	}
}
