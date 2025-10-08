using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLib
{
	public class CapacitorDefinition : PartDefinition
	{
		public CapacitorDefinition() : base("Capacitor", "C")
		{
			this.Pins.Add(new PinDefinition(1, "A"));
			this.Pins.Add(new PinDefinition(2, "B"));
		}
	}
}
