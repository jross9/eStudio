public class PartInstance
{
    public string InstanceName { get; set; }   // e.g., "R1", "C2"
    public PartDefinition Definition { get; } // Points to the master definition

    // Example instance-specific properties
    public double Value { get; set; }          // e.g., resistance in ohms, capacitance in farads
    public string Node1 { get; set; }
    public string Node2 { get; set; }

    public PartInstance(string instanceName, PartDefinition definition, double value,
                        string node1, string node2)
    {
        InstanceName = instanceName;
        Definition = definition;
        Value = value;
        Node1 = node1;
        Node2 = node2;
    }

    public override string ToString()
    {
        return $"{InstanceName}: {Definition.Name} {Value} between {Node1} and {Node2}";
    }
}

