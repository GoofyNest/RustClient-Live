public class AStarNode // TypeDefIndex: 12142
{	// Fields
	public AStarNode Parent; // 0x10
	public float G; // 0x18
	public float H; // 0x1C
	public BasePathNode Node; // 0x20

	// Properties
	public float F { get; }

	// Methods

	// RVA: 0x4B7550 Offset: 0x4B6950 VA: 0x1804B7550
	public float get_F() { }

	// RVA: 0x4B74E0 Offset: 0x4B68E0 VA: 0x1804B74E0
	public void .ctor(float g, float h, AStarNode parent, BasePathNode node) { }

	// RVA: 0x4B74A0 Offset: 0x4B68A0 VA: 0x1804B74A0
	public void Update(float g, float h, AStarNode parent, BasePathNode node) { }

	// RVA: 0x4B7430 Offset: 0x4B6830 VA: 0x1804B7430
	public bool Satisfies(BasePathNode node) { }

	// RVA: 0x4B75A0 Offset: 0x4B69A0 VA: 0x1804B75A0
	public static bool op_LessThan(AStarNode lhs, AStarNode rhs) { }

	// RVA: 0x4B7560 Offset: 0x4B6960 VA: 0x1804B7560
	public static bool op_GreaterThan(AStarNode lhs, AStarNode rhs) { }

}

