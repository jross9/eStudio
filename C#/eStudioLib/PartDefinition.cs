// Abstract base for all part definitions
public abstract class PartDefinition
{
    public string Name { get; }
    public string Symbol { get; }   // e.g., "R", "C", "L", "Q"

    protected PartDefinition(string name, string symbol)
    {
        Name = name;
        Symbol = symbol;
    }
}

// Examples of master part types
public class ResistorDefinition : PartDefinition
{
    public ResistorDefinition() : base("Resistor", "R") { }
}

public class CapacitorDefinition : PartDefinition
{
    public CapacitorDefinition() : base("Capacitor", "C") { }
}

public class InductorDefinition : PartDefinition
{
    public InductorDefinition() : base("Inductor", "L") { }
}

public class TransistorDefinition : PartDefinition
{
    public TransistorDefinition() : base("Transistor", "Q") { }
}

