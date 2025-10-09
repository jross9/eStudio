namespace eLib.TTL
{
	public class TTL7400Definition : ChipDefinition
	{
		public TTL7400Definition() 
			: base("7400", "U", new List<string> 
				{ "1A", "1B", "1Y", "2A", "2B", "2Y", "GND", 
				  "3Y", "3A", "3B", "4Y", "4A", "4B", "VCC" }) 
		{ 
		}
	}
}
