public struct Vector3i : IEquatable<Vector3i> // TypeDefIndex: 4823
{	public static readonly Vector3i zero; // 0x0
	public static readonly Vector3i one; // 0xC
	public static readonly Vector3i forward; // 0x18
	public static readonly Vector3i back; // 0x24
	public static readonly Vector3i up; // 0x30
	public static readonly Vector3i down; // 0x3C
	public static readonly Vector3i right; // 0x48
	public static readonly Vector3i left; // 0x54
	public int x; // 0x0
	public int y; // 0x4
	public int z; // 0x8


	public void .ctor(int x, int y, int z) { }

	public static Vector3i op_RightShift(Vector3i v, int shift) { }

	public static Vector3i op_LeftShift(Vector3i v, int shift) { }

	public static Vector3i op_UnaryPlus(Vector3i v) { }

	public static Vector3i op_UnaryNegation(Vector3i v) { }

	public static Vector3i op_Addition(Vector3i a, Vector3i b) { }

	public static Vector3i op_Subtraction(Vector3i a, Vector3i b) { }

	public static Vector3i op_Multiply(Vector3i v, int multiplier) { }

	public static Vector3i op_Division(Vector3i v, int divisor) { }

	public static Vector3 op_Multiply(Vector3i v, float multiplier) { }

	public static Vector3 op_Division(Vector3i v, float divisor) { }

	public static Vector3i op_Modulus(Vector3i v, int mod) { }

	public static Vector3 op_Implicit(Vector3i other) { }

	public static Vector3i op_Explicit(Vector3 other) { }

	public static bool op_Equality(Vector3i a, Vector3i b) { }

	public static bool op_Inequality(Vector3i a, Vector3i b) { }

	public bool Equals(Vector3i o) { }

	public override int GetHashCode() { }

	public override bool Equals(object o) { }

	public override string ToString() { }

	private static void .cctor() { }

}

