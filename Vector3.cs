public struct Vector3 : IEquatable<Vector3> // TypeDefIndex: 3467
{	// Fields
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	private static readonly Vector3 zeroVector; // 0x0
	private static readonly Vector3 oneVector; // 0xC
	private static readonly Vector3 upVector; // 0x18
	private static readonly Vector3 downVector; // 0x24
	private static readonly Vector3 leftVector; // 0x30
	private static readonly Vector3 rightVector; // 0x3C
	private static readonly Vector3 forwardVector; // 0x48
	private static readonly Vector3 backVector; // 0x54
	private static readonly Vector3 positiveInfinityVector; // 0x60
	private static readonly Vector3 negativeInfinityVector; // 0x6C

	// Properties
	public float Item { get; set; }
	public Vector3 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector3 zero { get; }
	public static Vector3 one { get; }
	public static Vector3 forward { get; }
	public static Vector3 back { get; }
	public static Vector3 up { get; }
	public static Vector3 down { get; }
	public static Vector3 left { get; }
	public static Vector3 right { get; }
	public static Vector3 positiveInfinity { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xABC30 Offset: 0xAB030 VA: 0x1800ABC30
	// RVA: 0x217ED20 Offset: 0x217E120 VA: 0x18217ED20
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xABCE0 Offset: 0xAB0E0 VA: 0x1800ABCE0
	// RVA: 0x217E5A0 Offset: 0x217D9A0 VA: 0x18217E5A0
	private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

	// RVA: 0x217E5F0 Offset: 0x217D9F0 VA: 0x18217E5F0
	public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	[FreeFunctionAttribute] // RVA: 0x85470 Offset: 0x84870 VA: 0x180085470
	// RVA: 0x217EA00 Offset: 0x217DE00 VA: 0x18217EA00
	public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	// RVA: 0x217DC60 Offset: 0x217D060 VA: 0x18217DC60
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x217DBE0 Offset: 0x217CFE0 VA: 0x18217DBE0
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x217E010 Offset: 0x217D410 VA: 0x18217E010
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x217EDD0 Offset: 0x217E1D0 VA: 0x18217EDD0
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) { }

	// RVA: 0x217EF00 Offset: 0x217E300 VA: 0x18217EF00
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x236300 Offset: 0x235700 VA: 0x180236300
	public float get_Item(int index) { }

	// RVA: 0x236510 Offset: 0x235910 VA: 0x180236510
	public void set_Item(int index, float value) { }

	// RVA: 0xFAFF0 Offset: 0xFA3F0 VA: 0x1800FAFF0
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x2362E0 Offset: 0x2356E0 VA: 0x1802362E0
	public void .ctor(float x, float y) { }

	// RVA: 0xFAFF0 Offset: 0xFA3F0 VA: 0x1800FAFF0
	public void Set(float newX, float newY, float newZ) { }

	// RVA: 0x217EAB0 Offset: 0x217DEB0 VA: 0x18217EAB0
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x217D8B0 Offset: 0x217CCB0 VA: 0x18217D8B0
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x236080 Offset: 0x235480 VA: 0x180236080 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x235F60 Offset: 0x235360 VA: 0x180235F60 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x236020 Offset: 0x235420 VA: 0x180236020 Slot: 4
	public bool Equals(Vector3 other) { }

	// RVA: 0x217E880 Offset: 0x217DC80 VA: 0x18217E880
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	// RVA: 0x217E3A0 Offset: 0x217D7A0 VA: 0x18217E3A0
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x2360E0 Offset: 0x2354E0 VA: 0x1802360E0
	public void Normalize() { }

	// RVA: 0x236440 Offset: 0x235840 VA: 0x180236440
	public Vector3 get_normalized() { }

	// RVA: 0x217DA30 Offset: 0x217CE30 VA: 0x18217DA30
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x217E670 Offset: 0x217DA70 VA: 0x18217E670
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x217D700 Offset: 0x217CB00 VA: 0x18217D700
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x217EB10 Offset: 0x217DF10 VA: 0x18217EB10
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0x217D950 Offset: 0x217CD50 VA: 0x18217D950
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x217DD60 Offset: 0x217D160 VA: 0x18217DD60
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x2363A0 Offset: 0x2357A0 VA: 0x1802363A0
	public float get_magnitude() { }

	// RVA: 0x217F310 Offset: 0x217E710 VA: 0x18217F310
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x2364E0 Offset: 0x2358E0 VA: 0x1802364E0
	public float get_sqrMagnitude() { }

	// RVA: 0x217DF10 Offset: 0x217D310 VA: 0x18217DF10
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x217DE10 Offset: 0x217D210 VA: 0x18217DE10
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x217FD30 Offset: 0x217F130 VA: 0x18217FD30
	public static Vector3 get_zero() { }

	// RVA: 0x217FB00 Offset: 0x217EF00 VA: 0x18217FB00
	public static Vector3 get_one() { }

	// RVA: 0x217F8C0 Offset: 0x217ECC0 VA: 0x18217F8C0
	public static Vector3 get_forward() { }

	// RVA: 0x217F7C0 Offset: 0x217EBC0 VA: 0x18217F7C0
	public static Vector3 get_back() { }

	// RVA: 0x217FCB0 Offset: 0x217F0B0 VA: 0x18217FCB0
	public static Vector3 get_up() { }

	// RVA: 0x217F840 Offset: 0x217EC40 VA: 0x18217F840
	public static Vector3 get_down() { }

	// RVA: 0x217F940 Offset: 0x217ED40 VA: 0x18217F940
	public static Vector3 get_left() { }

	// RVA: 0x217FC00 Offset: 0x217F000 VA: 0x18217FC00
	public static Vector3 get_right() { }

	// RVA: 0x217FB80 Offset: 0x217EF80 VA: 0x18217FB80
	public static Vector3 get_positiveInfinity() { }

	// RVA: 0x217FDB0 Offset: 0x217F1B0 VA: 0x18217FDB0
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x2180010 Offset: 0x217F410 VA: 0x182180010
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x2180060 Offset: 0x217F460 VA: 0x182180060
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x217FF80 Offset: 0x217F380 VA: 0x18217FF80
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x217FFC0 Offset: 0x217F3C0 VA: 0x18217FFC0
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x217FE00 Offset: 0x217F200 VA: 0x18217FE00
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x217FE50 Offset: 0x217F250 VA: 0x18217FE50
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x217FEC0 Offset: 0x217F2C0 VA: 0x18217FEC0
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2362D0 Offset: 0x2356D0 VA: 0x1802362D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x217F520 Offset: 0x217E920 VA: 0x18217F520
	private static void .cctor() { }

	// RVA: 0x217ECB0 Offset: 0x217E0B0 VA: 0x18217ECB0
	private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }

	// RVA: 0x217E990 Offset: 0x217DD90 VA: 0x18217E990
	private static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) { }

}

