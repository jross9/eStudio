// Abstract base for all part definitions
public abstract class PartDefinition
{
    public string Name { get; }
    public string Symbol { get; }   // e.g., "R", "C", "L", "Q"
	
	public List<PinDefinition> Pins { get; } = new List<PinDefinition>();

	protected PartDefinition(string name, string symbol)
    {
        this.Name = name;
        this.Symbol = symbol;
    }
}

// Examples of master part types
public class ResistorDefinition : PartDefinition
{
	public ResistorDefinition() : base("Resistor", "R") 
    {
		this.Pins.Add(new PinDefinition(1, "A"));
		this.Pins.Add(new PinDefinition(2, "B"));
	}
}

public class CapacitorDefinition : PartDefinition
{
    public CapacitorDefinition() : base("Capacitor", "C") 
    {
		this.Pins.Add(new PinDefinition(1, "A"));
		this.Pins.Add(new PinDefinition(2, "B"));
	}
}

public class InductorDefinition : PartDefinition
{
    public InductorDefinition() : base("Inductor", "L") 
    {
		this.Pins.Add(new PinDefinition(1, "A"));
		this.Pins.Add(new PinDefinition(2, "B"));
	}
}

public class TransistorDefinition : PartDefinition
{
	public TransistorDefinition() : base("Transistor", "Q")
	{
		this.Pins.Add(new PinDefinition(1, "Collector"));
		this.Pins.Add(new PinDefinition(2, "Base"));
		this.Pins.Add(new PinDefinition(3, "Emitter"));
	}

	public class ChipDefinition : PartDefinition
	{
		public ChipDefinition(string name, string symbol, List<string> pinNames) : base(name, symbol)
		{
			int pinNum = 1;
			foreach (var pin in pinNames)
			{
				this.Pins.Add(new PinDefinition(pinNum++, pin));
			}
		}
	}

}

