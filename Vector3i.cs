public struct Vector3i : IEquatable<Vector3i> // TypeDefIndex: 4823
{	// Fields
	public static readonly Vector3i zero; // 0x0
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

	// Methods

	// RVA: 0x20BCF0 Offset: 0x20B0F0 VA: 0x18020BCF0
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x226CD70 Offset: 0x226C170 VA: 0x18226CD70
	public static Vector3i op_RightShift(Vector3i v, int shift) { }

	// RVA: 0x226CC50 Offset: 0x226C050 VA: 0x18226CC50
	public static Vector3i op_LeftShift(Vector3i v, int shift) { }

	// RVA: 0x226CE40 Offset: 0x226C240 VA: 0x18226CE40
	public static Vector3i op_UnaryPlus(Vector3i v) { }

	// RVA: 0x226CE00 Offset: 0x226C200 VA: 0x18226CE00
	public static Vector3i op_UnaryNegation(Vector3i v) { }

	// RVA: 0x226CA30 Offset: 0x226BE30 VA: 0x18226CA30
	public static Vector3i op_Addition(Vector3i a, Vector3i b) { }

	// RVA: 0x226CDB0 Offset: 0x226C1B0 VA: 0x18226CDB0
	public static Vector3i op_Subtraction(Vector3i a, Vector3i b) { }

	// RVA: 0x226CD30 Offset: 0x226C130 VA: 0x18226CD30
	public static Vector3i op_Multiply(Vector3i v, int multiplier) { }

	// RVA: 0x226CAF0 Offset: 0x226BEF0 VA: 0x18226CAF0
	public static Vector3i op_Division(Vector3i v, int divisor) { }

	// RVA: 0x226CCD0 Offset: 0x226C0D0 VA: 0x18226CCD0
	public static Vector3 op_Multiply(Vector3i v, float multiplier) { }

	// RVA: 0x226CA90 Offset: 0x226BE90 VA: 0x18226CA90
	public static Vector3 op_Division(Vector3i v, float divisor) { }

	// RVA: 0x226CC90 Offset: 0x226C090 VA: 0x18226CC90
	public static Vector3i op_Modulus(Vector3i v, int mod) { }

	// RVA: 0x226CBB0 Offset: 0x226BFB0 VA: 0x18226CBB0
	public static Vector3 op_Implicit(Vector3i other) { }

	// RVA: 0x226CB70 Offset: 0x226BF70 VA: 0x18226CB70
	public static Vector3i op_Explicit(Vector3 other) { }

	// RVA: 0x226CB30 Offset: 0x226BF30 VA: 0x18226CB30
	public static bool op_Equality(Vector3i a, Vector3i b) { }

	// RVA: 0x226CC10 Offset: 0x226C010 VA: 0x18226CC10
	public static bool op_Inequality(Vector3i a, Vector3i b) { }

	// RVA: 0x238950 Offset: 0x237D50 VA: 0x180238950 Slot: 4
	public bool Equals(Vector3i o) { }

	// RVA: 0x238990 Offset: 0x237D90 VA: 0x180238990 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2388A0 Offset: 0x237CA0 VA: 0x1802388A0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2389E0 Offset: 0x237DE0 VA: 0x1802389E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x226C8E0 Offset: 0x226BCE0 VA: 0x18226C8E0
	private static void .cctor() { }

}

