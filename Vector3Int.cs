public struct Vector3Int : IEquatable<Vector3Int> // TypeDefIndex: 3472
{	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private int m_Z; // 0x8
	private static readonly Vector3Int s_Zero; // 0x0
	private static readonly Vector3Int s_One; // 0xC
	private static readonly Vector3Int s_Up; // 0x18
	private static readonly Vector3Int s_Down; // 0x24
	private static readonly Vector3Int s_Left; // 0x30
	private static readonly Vector3Int s_Right; // 0x3C

	// Properties
	public int x { get; }
	public int y { get; }
	public int z { get; }

	// Methods

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500
	public int get_x() { }

	// RVA: 0x13A260 Offset: 0x139660 VA: 0x18013A260
	public int get_y() { }

	// RVA: 0x13AB80 Offset: 0x139F80 VA: 0x18013AB80
	public int get_z() { }

	// RVA: 0x20BCF0 Offset: 0x20B0F0 VA: 0x18020BCF0
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x217D6E0 Offset: 0x217CAE0 VA: 0x18217D6E0
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x235D10 Offset: 0x235110 VA: 0x180235D10 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x235E30 Offset: 0x235230 VA: 0x180235E30 Slot: 4
	public bool Equals(Vector3Int other) { }

	// RVA: 0x235ED0 Offset: 0x2352D0 VA: 0x180235ED0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x235F50 Offset: 0x235350 VA: 0x180235F50 Slot: 3
	public override string ToString() { }

	// RVA: 0x217D5C0 Offset: 0x217C9C0 VA: 0x18217D5C0
	private static void .cctor() { }

}

