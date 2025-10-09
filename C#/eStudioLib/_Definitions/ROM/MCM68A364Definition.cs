using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLib.ROM
{
	public class MCM68A364Definition : ChipDefinition
	{
		public MCM68A364Definition()
			: base("MCM68A364", "U", new List<string> 
				{ "A7", "A6", "A5", "A4", "A3", "A2", "A1", "A0", "Q0", "Q1", "Q2", "VSS",
				  "Q3", "Q4", "Q5", "Q6", "Q7", "A11", "A10", "En", "A12", "A9", "A8", "VCC" })
		{
		}
	}
}
