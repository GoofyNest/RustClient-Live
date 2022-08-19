public struct Vector2Int : IEquatable<Vector2Int> // TypeDefIndex: 3471
{	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private static readonly Vector2Int s_Zero; // 0x0
	private static readonly Vector2Int s_One; // 0x8
	private static readonly Vector2Int s_Up; // 0x10
	private static readonly Vector2Int s_Down; // 0x18
	private static readonly Vector2Int s_Left; // 0x20
	private static readonly Vector2Int s_Right; // 0x28

	// Properties
	public int x { get; }
	public int y { get; }

	// Methods

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500
	public int get_x() { }

	// RVA: 0x13A260 Offset: 0x139660 VA: 0x18013A260
	public int get_y() { }

	// RVA: 0xF8460 Offset: 0xF7860 VA: 0x1800F8460
	public void .ctor(int x, int y) { }

	// RVA: 0x2356A0 Offset: 0x234AA0 VA: 0x1802356A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x235650 Offset: 0x234A50 VA: 0x180235650 Slot: 4
	public bool Equals(Vector2Int other) { }

	// RVA: 0x235760 Offset: 0x234B60 VA: 0x180235760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2357B0 Offset: 0x234BB0 VA: 0x1802357B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x217C500 Offset: 0x217B900 VA: 0x18217C500
	private static void .cctor() { }

}

