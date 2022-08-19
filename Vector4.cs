public struct Vector4 : IEquatable<Vector4> // TypeDefIndex: 3473
{	// Fields
	public const float kEpsilon = 1E-05;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Vector4 zeroVector; // 0x0
	private static readonly Vector4 oneVector; // 0x10
	private static readonly Vector4 positiveInfinityVector; // 0x20
	private static readonly Vector4 negativeInfinityVector; // 0x30

	// Properties
	public float Item { get; set; }
	public Vector4 normalized { get; }
	public float sqrMagnitude { get; }
	public static Vector4 zero { get; }
	public static Vector4 one { get; }

	// Methods

	// RVA: 0x236700 Offset: 0x235B00 VA: 0x180236700
	public float get_Item(int index) { }

	// RVA: 0x2368E0 Offset: 0x235CE0 VA: 0x1802368E0
	public void set_Item(int index, float value) { }

	// RVA: 0xF2CA0 Offset: 0xF20A0 VA: 0x1800F2CA0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x2366E0 Offset: 0x235AE0 VA: 0x1802366E0
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x2180260 Offset: 0x217F660 VA: 0x182180260
	public static Vector4 Lerp(Vector4 a, Vector4 b, float t) { }

	// RVA: 0x2177E0 Offset: 0x216BE0 VA: 0x1802177E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2365C0 Offset: 0x2359C0 VA: 0x1802365C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x236680 Offset: 0x235A80 VA: 0x180236680 Slot: 4
	public bool Equals(Vector4 other) { }

	// RVA: 0x2180450 Offset: 0x217F850 VA: 0x182180450
	public static Vector4 Normalize(Vector4 a) { }

	// RVA: 0x2367B0 Offset: 0x235BB0 VA: 0x1802367B0
	public Vector4 get_normalized() { }

	// RVA: 0x18F8BA0 Offset: 0x18F7FA0 VA: 0x1818F8BA0
	public static float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x2180380 Offset: 0x217F780 VA: 0x182180380
	public static float Magnitude(Vector4 a) { }

	// RVA: 0x236840 Offset: 0x235C40 VA: 0x180236840
	public float get_sqrMagnitude() { }

	// RVA: 0x2180BB0 Offset: 0x217FFB0 VA: 0x182180BB0
	public static Vector4 get_zero() { }

	// RVA: 0x2180AA0 Offset: 0x217FEA0 VA: 0x182180AA0
	public static Vector4 get_one() { }

	// RVA: 0x181F7F0 Offset: 0x181EBF0 VA: 0x18181F7F0
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	// RVA: 0x181FBA0 Offset: 0x181EFA0 VA: 0x18181FBA0
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x181FB10 Offset: 0x181EF10 VA: 0x18181FB10
	public static Vector4 op_Multiply(float d, Vector4 a) { }

	// RVA: 0x181F840 Offset: 0x181EC40 VA: 0x18181F840
	public static Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x2180C20 Offset: 0x2180020 VA: 0x182180C20
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x2180D60 Offset: 0x2180160 VA: 0x182180D60
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x2180CC0 Offset: 0x21800C0 VA: 0x182180CC0
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x2180D30 Offset: 0x2180130 VA: 0x182180D30
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x2180C80 Offset: 0x2180080 VA: 0x182180C80
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x2180D10 Offset: 0x2180110 VA: 0x182180D10
	public static Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0x2366D0 Offset: 0x235AD0 VA: 0x1802366D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21808B0 Offset: 0x217FCB0 VA: 0x1821808B0
	private static void .cctor() { }

}

