public struct Vector2i : IEquatable<Vector2i> // TypeDefIndex: 4821
{	// Fields
	public static readonly Vector2i zero; // 0x0
	public static readonly Vector2i one; // 0x8
	public static readonly Vector2i left; // 0x10
	public static readonly Vector2i right; // 0x18
	public static readonly Vector2i forward; // 0x20
	public static readonly Vector2i back; // 0x28
	public int x; // 0x0
	public int y; // 0x4

	// Methods

	// RVA: 0xF8460 Offset: 0xF7860 VA: 0x1800F8460
	public void .ctor(int x, int y) { }

	// RVA: 0x226C7B0 Offset: 0x226BBB0 VA: 0x18226C7B0
	public static Vector2i op_RightShift(Vector2i v, int shift) { }

	// RVA: 0x226C680 Offset: 0x226BA80 VA: 0x18226C680
	public static Vector2i op_LeftShift(Vector2i v, int shift) { }

	// RVA: 0x226C7F0 Offset: 0x226BBF0 VA: 0x18226C7F0
	public static Vector2i op_UnaryPlus(Vector2i v) { }

	// RVA: 0x226C7D0 Offset: 0x226BBD0 VA: 0x18226C7D0
	public static Vector2i op_UnaryNegation(Vector2i v) { }

	// RVA: 0x9519B0 Offset: 0x950DB0 VA: 0x1809519B0
	public static Vector2i op_Addition(Vector2i a, Vector2i b) { }

	// RVA: 0x951A50 Offset: 0x950E50 VA: 0x180951A50
	public static Vector2i op_Subtraction(Vector2i a, Vector2i b) { }

	// RVA: 0x226C720 Offset: 0x226BB20 VA: 0x18226C720
	public static Vector2i op_Multiply(Vector2i v, int multiplier) { }

	// RVA: 0x226C540 Offset: 0x226B940 VA: 0x18226C540
	public static Vector2i op_Division(Vector2i v, int divisor) { }

	// RVA: 0x226C6D0 Offset: 0x226BAD0 VA: 0x18226C6D0
	public static Vector2 op_Multiply(Vector2i v, float multiplier) { }

	// RVA: 0x226C5D0 Offset: 0x226B9D0 VA: 0x18226C5D0
	public static Vector2 op_Division(Vector2i v, float divisor) { }

	// RVA: 0x226C6A0 Offset: 0x226BAA0 VA: 0x18226C6A0
	public static Vector2i op_Modulus(Vector2i v, int mod) { }

	// RVA: 0x226C640 Offset: 0x226BA40 VA: 0x18226C640
	public static Vector2 op_Implicit(Vector2i other) { }

	// RVA: 0x226C620 Offset: 0x226BA20 VA: 0x18226C620
	public static Vector2i op_Explicit(Vector2 other) { }

	// RVA: 0x9519F0 Offset: 0x950DF0 VA: 0x1809519F0
	public static bool op_Equality(Vector2i a, Vector2i b) { }

	// RVA: 0x951A10 Offset: 0x950E10 VA: 0x180951A10
	public static bool op_Inequality(Vector2i a, Vector2i b) { }

	// RVA: 0xFA450 Offset: 0xF9850 VA: 0x1800FA450 Slot: 4
	public bool Equals(Vector2i o) { }

	// RVA: 0xFA470 Offset: 0xF9870 VA: 0x1800FA470 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x238580 Offset: 0x237980 VA: 0x180238580 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x238610 Offset: 0x237A10 VA: 0x180238610 Slot: 3
	public override string ToString() { }

	// RVA: 0x226C450 Offset: 0x226B850 VA: 0x18226C450
	private static void .cctor() { }

}

