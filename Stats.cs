public class Stats // TypeDefIndex: 6704
{	// Fields
	public bool Enabled; // 0x10
	public Stats.Node Building; // 0x18
	public Stats.Node Previous; // 0x20

	// Methods

	// RVA: 0x220F390 Offset: 0x220E790 VA: 0x18220F390
	public void .ctor() { }

	// RVA: 0x220F2B0 Offset: 0x220E6B0 VA: 0x18220F2B0
	public void Add(string Category, string Object, long Bytes) { }

	// RVA: 0x220F260 Offset: 0x220E660 VA: 0x18220F260
	public void Add(string Category, long Bytes) { }

	// RVA: 0x220F320 Offset: 0x220E720 VA: 0x18220F320
	public void Flip() { }

}

public class Stats.Node : Pool.IPooled // TypeDefIndex: 6705
{	// Fields
	public Dictionary<string, Stats.Node> Children; // 0x10
	public long Bytes; // 0x18
	public long Count; // 0x20

	// Methods

	// RVA: 0x220E430 Offset: 0x220D830 VA: 0x18220E430
	internal Stats.Node Add(string category, long bytes) { }

	// RVA: 0x220E4E0 Offset: 0x220D8E0 VA: 0x18220E4E0
	internal void Clear() { }

	// RVA: 0x220E650 Offset: 0x220DA50 VA: 0x18220E650 Slot: 4
	public void EnterPool() { }

	// RVA: 0x220E650 Offset: 0x220DA50 VA: 0x18220E650 Slot: 5
	public void LeavePool() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

