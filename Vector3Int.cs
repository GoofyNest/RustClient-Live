public struct Vector3Int : IEquatable<Vector3Int> // TypeDefIndex: 3473
{
	private int m_X; 
	private int m_Y; 
	private int m_Z; 
	private static readonly Vector3Int s_Zero; 
	private static readonly Vector3Int s_One; 
	private static readonly Vector3Int s_Up; 
	private static readonly Vector3Int s_Down; 
	private static readonly Vector3Int s_Left; 
	private static readonly Vector3Int s_Right; 

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

