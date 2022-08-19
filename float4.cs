public struct float4 : IEquatable<float4>, IFormattable // TypeDefIndex: 7105
{
// Namespace: Unity.Mathematics
[DebuggerTypeProxyAttribute] // RVA: 0x7D680 Offset: 0x7CA80 VA: 0x18007D680
[DefaultMemberAttribute] // RVA: 0x7D680 Offset: 0x7CA80 VA: 0x18007D680
[Serializable]
public struct float4 : IEquatable<float4>, IFormattable // TypeDefIndex: 7105
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	public static readonly float4 zero; // 0x0

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	public float4 xyzx { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	public float4 yzxy { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	public float4 yzxz { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	public float4 zxyy { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	public float4 zxyz { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	public float4 wwwx { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	public float4 wwww { get; }
	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	public float3 xyz { get; }

	// Methods

	// RVA: 0xF2CA0 Offset: 0xF20A0 VA: 0x1800F2CA0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x239FE0 Offset: 0x2393E0 VA: 0x180239FE0
	public void .ctor(float3 xyz, float w) { }

	// RVA: 0x22A8FF0 Offset: 0x22A83F0 VA: 0x1822A8FF0
	public static float4 op_Multiply(float4 lhs, float4 rhs) { }

	// RVA: 0x22A9070 Offset: 0x22A8470 VA: 0x1822A9070
	public static float4 op_Multiply(float4 lhs, float rhs) { }

	// RVA: 0x22A9050 Offset: 0x22A8450 VA: 0x1822A9050
	public static float4 op_Multiply(float lhs, float4 rhs) { }

	// RVA: 0x22A8F90 Offset: 0x22A8390 VA: 0x1822A8F90
	public static float4 op_Addition(float4 lhs, float4 rhs) { }

	// RVA: 0x22A9090 Offset: 0x22A8490 VA: 0x1822A9090
	public static float4 op_Subtraction(float4 lhs, float4 rhs) { }

	// RVA: 0x22A90F0 Offset: 0x22A84F0 VA: 0x1822A90F0
	public static float4 op_UnaryNegation(float4 val) { }

	// RVA: 0x23A070 Offset: 0x239470 VA: 0x18023A070
	public float4 get_xyzx() { }

	// RVA: 0x23A090 Offset: 0x239490 VA: 0x18023A090
	public float4 get_yzxy() { }

	// RVA: 0x23A0B0 Offset: 0x2394B0 VA: 0x18023A0B0
	public float4 get_yzxz() { }

	// RVA: 0x23A0D0 Offset: 0x2394D0 VA: 0x18023A0D0
	public float4 get_zxyy() { }

	// RVA: 0x23A0F0 Offset: 0x2394F0 VA: 0x18023A0F0
	public float4 get_zxyz() { }

	// RVA: 0x23A030 Offset: 0x239430 VA: 0x18023A030
	public float4 get_wwwx() { }

	// RVA: 0x23A020 Offset: 0x239420 VA: 0x18023A020
	public float4 get_wwww() { }

	// RVA: 0x23A050 Offset: 0x239450 VA: 0x18023A050
	public float3 get_xyz() { }

	// RVA: 0x236680 Offset: 0x235A80 VA: 0x180236680 Slot: 4
	public bool Equals(float4 rhs) { }

	// RVA: 0x239E30 Offset: 0x239230 VA: 0x180239E30 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x239EE0 Offset: 0x2392E0 VA: 0x180239EE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x239FC0 Offset: 0x2393C0 VA: 0x180239FC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x239FD0 Offset: 0x2393D0 VA: 0x180239FD0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

}

