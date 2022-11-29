public class Stats // TypeDefIndex: 6878
{
	public bool Enabled; 
	public Stats.Node Building; 
	public Stats.Node Previous; 


	public void .ctor() { }

	public void Add(string Category, string Object, long Bytes) { }

	public void Add(string Category, long Bytes) { }

	public void Flip() { }

}

public class Stats.Node : Pool.IPooled // TypeDefIndex: 6879
{
	public Dictionary<string, Stats.Node> Children; 
	public long Bytes; 
	public long Count; 


	internal Stats.Node Add(string category, long bytes) { }

	internal void Clear() { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void .ctor() { }

}

