public class Circuit
{
	public List<PartInstance> Instances { get; } = new List<PartInstance>();

	public void AddPart(PartInstance instance)
	{
		Instances.Add(instance);
	}
}
