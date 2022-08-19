public struct Vector2 : IEquatable<Vector2> // TypeDefIndex: 3470
{	// Fields
	public float x; // 0x0
	public float y; // 0x4
	private static readonly Vector2 zeroVector; // 0x0
	private static readonly Vector2 oneVector; // 0x8
	private static readonly Vector2 upVector; // 0x10
	private static readonly Vector2 downVector; // 0x18
	private static readonly Vector2 leftVector; // 0x20
	private static readonly Vector2 rightVector; // 0x28
	private static readonly Vector2 positiveInfinityVector; // 0x30
	private static readonly Vector2 negativeInfinityVector; // 0x38
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;

	// Properties
	public float Item { get; set; }
	public Vector2 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector2 zero { get; }
	public static Vector2 one { get; }
	public static Vector2 up { get; }
	public static Vector2 right { get; }

	// Methods

	// RVA: 0x235B80 Offset: 0x234F80 VA: 0x180235B80
	public float get_Item(int index) { }

	// RVA: 0x235C70 Offset: 0x235070 VA: 0x180235C70
	public void set_Item(int index, float value) { }

	// RVA: 0xF2260 Offset: 0xF1660 VA: 0x1800F2260
	public void .ctor(float x, float y) { }

	// RVA: 0x217C950 Offset: 0x217BD50 VA: 0x18217C950
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x217CB10 Offset: 0x217BF10 VA: 0x18217CB10
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x235A10 Offset: 0x234E10 VA: 0x180235A10
	public void Normalize() { }

	// RVA: 0x235C20 Offset: 0x235020 VA: 0x180235C20
	public Vector2 get_normalized() { }

	// RVA: 0x235A20 Offset: 0x234E20 VA: 0x180235A20 Slot: 3
	public override string ToString() { }

	// RVA: 0x2359D0 Offset: 0x234DD0 VA: 0x1802359D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x235900 Offset: 0x234D00 VA: 0x180235900 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2359A0 Offset: 0x234DA0 VA: 0x1802359A0 Slot: 4
	public bool Equals(Vector2 other) { }

	// RVA: 0x217C810 Offset: 0x217BC10 VA: 0x18217C810
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x235C10 Offset: 0x235010 VA: 0x180235C10
	public float get_magnitude() { }

	// RVA: 0x235C50 Offset: 0x235050 VA: 0x180235C50
	public float get_sqrMagnitude() { }

	// RVA: 0x217C5F0 Offset: 0x217B9F0 VA: 0x18217C5F0
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x217C780 Offset: 0x217BB80 VA: 0x18217C780
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x217D0C0 Offset: 0x217C4C0 VA: 0x18217D0C0
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x217D300 Offset: 0x217C700 VA: 0x18217D300
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x217CB10 Offset: 0x217BF10 VA: 0x18217CB10
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x217D130 Offset: 0x217C530 VA: 0x18217D130
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x217D340 Offset: 0x217C740 VA: 0x18217D340
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x217D2D0 Offset: 0x217C6D0 VA: 0x18217D2D0
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x217D2A0 Offset: 0x217C6A0 VA: 0x18217D2A0
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x217D100 Offset: 0x217C500 VA: 0x18217D100
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x217D170 Offset: 0x217C570 VA: 0x18217D170
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x217D220 Offset: 0x217C620 VA: 0x18217D220
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x217D200 Offset: 0x217C600 VA: 0x18217D200
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x217D1C0 Offset: 0x217C5C0 VA: 0x18217D1C0
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x217D050 Offset: 0x217C450 VA: 0x18217D050
	public static Vector2 get_zero() { }

	// RVA: 0x217CEE0 Offset: 0x217C2E0 VA: 0x18217CEE0
	public static Vector2 get_one() { }

	// RVA: 0x217CFE0 Offset: 0x217C3E0 VA: 0x18217CFE0
	public static Vector2 get_up() { }

	// RVA: 0x217CF50 Offset: 0x217C350 VA: 0x18217CF50
	public static Vector2 get_right() { }

	// RVA: 0x217CCB0 Offset: 0x217C0B0 VA: 0x18217CCB0
	private static void .cctor() { }

}

