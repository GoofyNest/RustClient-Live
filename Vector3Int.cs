public struct Vector3Int : IEquatable<Vector3Int> // TypeDefIndex: 3472
{	private int m_X; // 0x0
	private int m_Y; // 0x4
	private int m_Z; // 0x8
	private static readonly Vector3Int s_Zero; // 0x0
	private static readonly Vector3Int s_One; // 0xC
	private static readonly Vector3Int s_Up; // 0x18
	private static readonly Vector3Int s_Down; // 0x24
	private static readonly Vector3Int s_Left; // 0x30
	private static readonly Vector3Int s_Right; // 0x3C

	public int x { get; }
	public int y { get; }
	public int z { get; }


	public int get_x() { }

	public int get_y() { }

	public int get_z() { }

	public void .ctor(int x, int y, int z) { }

	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	public override bool Equals(object other) { }

	public bool Equals(Vector3Int other) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	private static void .cctor() { }

}

