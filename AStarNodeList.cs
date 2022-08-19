public class AStarNodeList : List<AStarNode> // TypeDefIndex: 12143
{	// Fields
	private readonly AStarNodeList.AStarNodeComparer comparer; // 0x28

	// Methods

	// RVA: 0x4B7230 Offset: 0x4B6630 VA: 0x1804B7230
	public bool Contains(BasePathNode n) { }

	// RVA: 0x4B72E0 Offset: 0x4B66E0 VA: 0x1804B72E0
	public AStarNode GetAStarNodeOf(BasePathNode n) { }

	// RVA: 0x4B71F0 Offset: 0x4B65F0 VA: 0x1804B71F0
	public void AStarNodeSort() { }

	// RVA: 0x4B73A0 Offset: 0x4B67A0 VA: 0x1804B73A0
	public void .ctor() { }

}

private class AStarNodeList.AStarNodeComparer : IComparer<AStarNode> // TypeDefIndex: 12144
{	// Methods

	// RVA: 0x4B71A0 Offset: 0x4B65A0 VA: 0x1804B71A0 Slot: 4
	private int System.Collections.Generic.IComparer<Rust.AI.AStarNode>.Compare(AStarNode lhs, AStarNode rhs) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

