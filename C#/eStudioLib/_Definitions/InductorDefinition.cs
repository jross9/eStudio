using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLib
{
	public class InductorDefinition : PartDefinition
	{
		public InductorDefinition() : base("Inductor", "L")
		{
			this.Pins.Add(new PinDefinition(1, "A"));
			this.Pins.Add(new PinDefinition(2, "B"));
		}
	}
}
