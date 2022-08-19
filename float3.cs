public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 7103
{
// Namespace: Unity.Mathematics
[DebuggerTypeProxyAttribute] // RVA: 0x7D3E0 Offset: 0x7C7E0 VA: 0x18007D3E0
[DefaultMemberAttribute] // RVA: 0x7D3E0 Offset: 0x7C7E0 VA: 0x18007D3E0
[Serializable]
public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 7103
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public static readonly float3 zero; // 0x0

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	public float3 yzx { get; }

	// Methods

	// RVA: 0xFAFF0 Offset: 0xFA3F0 VA: 0x1800FAFF0
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x22A8990 Offset: 0x22A7D90 VA: 0x1822A8990
	public static float3 op_Multiply(float3 lhs, float3 rhs) { }

	// RVA: 0x22A8A30 Offset: 0x22A7E30 VA: 0x1822A8A30
	public static float3 op_Multiply(float3 lhs, float rhs) { }

	// RVA: 0x22A89E0 Offset: 0x22A7DE0 VA: 0x1822A89E0
	public static float3 op_Multiply(float lhs, float3 rhs) { }

	// RVA: 0x22A8900 Offset: 0x22A7D00 VA: 0x1822A8900
	public static float3 op_Addition(float3 lhs, float3 rhs) { }

	// RVA: 0x22A8A70 Offset: 0x22A7E70 VA: 0x1822A8A70
	public static float3 op_Subtraction(float3 lhs, float3 rhs) { }

	// RVA: 0x22A8950 Offset: 0x22A7D50 VA: 0x1822A8950
	public static float3 op_Division(float3 lhs, float rhs) { }

	// RVA: 0x22A8AC0 Offset: 0x22A7EC0 VA: 0x1822A8AC0
	public static float3 op_UnaryNegation(float3 val) { }

	// RVA: 0x239E10 Offset: 0x239210 VA: 0x180239E10
	public float3 get_yzx() { }

	// RVA: 0x236020 Offset: 0x235420 VA: 0x180236020 Slot: 4
	public bool Equals(float3 rhs) { }

	// RVA: 0x239B30 Offset: 0x238F30 VA: 0x180239B30 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x239BF0 Offset: 0x238FF0 VA: 0x180239BF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x239CA0 Offset: 0x2390A0 VA: 0x180239CA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x239D50 Offset: 0x239150 VA: 0x180239D50 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1EF4540 Offset: 0x1EF3940 VA: 0x181EF4540
	public static Vector3 op_Implicit(float3 v) { }

	// RVA: 0x1EF4510 Offset: 0x1EF3910 VA: 0x181EF4510
	public static float3 op_Implicit(Vector3 v) { }

}

