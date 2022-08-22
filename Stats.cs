public class Stats // TypeDefIndex: 6704
{	public bool Enabled; // 0x10
	public Stats.Node Building; // 0x18
	public Stats.Node Previous; // 0x20


	public void .ctor() { }

	public void Add(string Category, string Object, long Bytes) { }

	public void Add(string Category, long Bytes) { }

	public void Flip() { }

}

public class Stats.Node : Pool.IPooled // TypeDefIndex: 6705
{	public Dictionary<string, Stats.Node> Children; // 0x10
	public long Bytes; // 0x18
	public long Count; // 0x20


	internal Stats.Node Add(string category, long bytes) { }

	internal void Clear() { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void .ctor() { }

}

