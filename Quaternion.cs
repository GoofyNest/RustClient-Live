public struct Quaternion : IEquatable<Quaternion> // TypeDefIndex: 3468
{	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Quaternion identityQuaternion; // 0x0
	public const float kEpsilon = 1E-06;

	// Properties
	public static Quaternion identity { get; }
	public Vector3 eulerAngles { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xAC150 Offset: 0xAB550 VA: 0x1800AC150
	// RVA: 0x18F9000 Offset: 0x18F8400 VA: 0x1818F9000
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[FreeFunctionAttribute] // RVA: 0x85470 Offset: 0x84870 VA: 0x180085470
	// RVA: 0x18F93F0 Offset: 0x18F87F0 VA: 0x1818F93F0
	public static Quaternion Inverse(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0xAC3F0 Offset: 0xAB7F0 VA: 0x1800AC3F0
	// RVA: 0x18F9E70 Offset: 0x18F9270 VA: 0x1818F9E70
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xAC5B0 Offset: 0xAB9B0 VA: 0x1800AC5B0
	// RVA: 0x18F9D50 Offset: 0x18F9150 VA: 0x1818F9D50
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xAC690 Offset: 0xABA90 VA: 0x1800AC690
	// RVA: 0x18F9620 Offset: 0x18F8A20 VA: 0x1818F9620
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xAC7E0 Offset: 0xABBE0 VA: 0x1800AC7E0
	// RVA: 0x18F9500 Offset: 0x18F8900 VA: 0x1818F9500
	public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xAC940 Offset: 0xABD40 VA: 0x1800AC940
	// RVA: 0x18F9160 Offset: 0x18F8560 VA: 0x1818F9160
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[FreeFunctionAttribute] // RVA: 0xACA50 Offset: 0xABE50 VA: 0x1800ACA50
	// RVA: 0x18F9310 Offset: 0x18F8710 VA: 0x1818F9310
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0xACB20 Offset: 0xABF20 VA: 0x1800ACB20
	// RVA: 0x18F89E0 Offset: 0x18F7DE0 VA: 0x1818F89E0
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[FreeFunctionAttribute] // RVA: 0xACC70 Offset: 0xAC070 VA: 0x1800ACC70
	// RVA: 0x18F9880 Offset: 0x18F8C80 VA: 0x1818F9880
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18F9730 Offset: 0x18F8B30 VA: 0x1818F9730
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0xF2CA0 Offset: 0xF20A0 VA: 0x1800F2CA0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x18FA370 Offset: 0x18F9770 VA: 0x1818FA370
	public static Quaternion get_identity() { }

	// RVA: 0x18FA790 Offset: 0x18F9B90 VA: 0x1818FA790
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x18FA5A0 Offset: 0x18F99A0 VA: 0x1818FA5A0
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x18F9480 Offset: 0x18F8880 VA: 0x1818F9480
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x18FA3E0 Offset: 0x18F97E0 VA: 0x1818FA3E0
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x18FA4A0 Offset: 0x18F98A0 VA: 0x1818FA4A0
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x18F8BA0 Offset: 0x18F7FA0 VA: 0x1818F8BA0
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x217850 Offset: 0x216C50 VA: 0x180217850
	public void SetLookRotation(Vector3 view, Vector3 up) { }

	// RVA: 0x18F8A80 Offset: 0x18F7E80 VA: 0x1818F8A80
	public static float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x18F91F0 Offset: 0x18F85F0 VA: 0x1818F91F0
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x217970 Offset: 0x216D70 VA: 0x180217970
	public Vector3 get_eulerAngles() { }

	// RVA: 0x18F8CD0 Offset: 0x18F80D0 VA: 0x1818F8CD0
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x18F8E60 Offset: 0x18F8260 VA: 0x1818F8E60
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x18F9920 Offset: 0x18F8D20 VA: 0x1818F9920
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x2177E0 Offset: 0x216BE0 VA: 0x1802177E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x217700 Offset: 0x216B00 VA: 0x180217700 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x212E70 Offset: 0x212270 VA: 0x180212E70 Slot: 4
	public bool Equals(Quaternion other) { }

	// RVA: 0x217960 Offset: 0x216D60 VA: 0x180217960 Slot: 3
	public override string ToString() { }

	// RVA: 0x18FA160 Offset: 0x18F9560 VA: 0x1818FA160
	private static void .cctor() { }

	// RVA: 0x18F8FA0 Offset: 0x18F83A0 VA: 0x1818F8FA0
	private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) { }

	// RVA: 0x18F93A0 Offset: 0x18F87A0 VA: 0x1818F93A0
	private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	// RVA: 0x18F9E00 Offset: 0x18F9200 VA: 0x1818F9E00
	private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18F9CE0 Offset: 0x18F90E0 VA: 0x1818F9CE0
	private static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18F95B0 Offset: 0x18F89B0 VA: 0x1818F95B0
	private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18F9490 Offset: 0x18F8890 VA: 0x1818F9490
	private static void LerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x18F9110 Offset: 0x18F8510 VA: 0x1818F9110
	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	// RVA: 0x18F92C0 Offset: 0x18F86C0 VA: 0x1818F92C0
	private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	// RVA: 0x18F8980 Offset: 0x18F7D80 VA: 0x1818F8980
	private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	// RVA: 0x18F96D0 Offset: 0x18F8AD0 VA: 0x1818F96D0
	private static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret) { }

}

public struct quaternion : IEquatable<quaternion>, IFormattable // TypeDefIndex: 7112
{
// Namespace: Unity.Mathematics
[Serializable]
public struct quaternion : IEquatable<quaternion>, IFormattable // TypeDefIndex: 7112
	// Fields
	public float4 value; // 0x0
	public static readonly quaternion identity; // 0x0

	// Methods

	// RVA: 0x22AB580 Offset: 0x22AA980 VA: 0x1822AB580
	public static Quaternion op_Implicit(quaternion q) { }

	// RVA: 0x9533A0 Offset: 0x9527A0 VA: 0x1809533A0
	public static quaternion op_Implicit(Quaternion q) { }

	// RVA: 0xF2CA0 Offset: 0xF20A0 VA: 0x1800F2CA0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x19E2A0 Offset: 0x19D6A0 VA: 0x18019E2A0
	public void .ctor(float4 value) { }

	// RVA: 0x22AAF90 Offset: 0x22AA390 VA: 0x1822AAF90
	public static quaternion AxisAngle(float3 axis, float angle) { }

	// RVA: 0x23A6B0 Offset: 0x239AB0 VA: 0x18023A6B0 Slot: 4
	public bool Equals(quaternion x) { }

	// RVA: 0x23A600 Offset: 0x239A00 VA: 0x18023A600 Slot: 0
	public override bool Equals(object x) { }

	// RVA: 0x239EE0 Offset: 0x2392E0 VA: 0x180239EE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23A700 Offset: 0x239B00 VA: 0x18023A700 Slot: 3
	public override string ToString() { }

	// RVA: 0x23A6F0 Offset: 0x239AF0 VA: 0x18023A6F0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x22AB540 Offset: 0x22AA940 VA: 0x1822AB540
	private static void .cctor() { }

}

