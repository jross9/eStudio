public class PartLibrary
{
    public List<PartDefinition> Parts { get; } = new List<PartDefinition>();

    public PartLibrary()
    {
        // Build master list
        Parts.Add(new ResistorDefinition());
        Parts.Add(new CapacitorDefinition());
        Parts.Add(new InductorDefinition());
        Parts.Add(new TransistorDefinition());
    }
}

