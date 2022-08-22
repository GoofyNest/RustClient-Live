public struct float4 : IEquatable<float4>, IFormattable // TypeDefIndex: 7105
{
[DebuggerTypeProxyAttribute] // RVA: 0x7D680 Offset: 0x7CA80 VA: 0x18007D680
[DefaultMemberAttribute] // RVA: 0x7D680 Offset: 0x7CA80 VA: 0x18007D680
[Serializable]
public struct float4 : IEquatable<float4>, IFormattable // TypeDefIndex: 7105
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	public static readonly float4 zero; // 0x0

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


	public void .ctor(float x, float y, float z, float w) { }

	public void .ctor(float3 xyz, float w) { }

	public static float4 op_Multiply(float4 lhs, float4 rhs) { }

	public static float4 op_Multiply(float4 lhs, float rhs) { }

	public static float4 op_Multiply(float lhs, float4 rhs) { }

	public static float4 op_Addition(float4 lhs, float4 rhs) { }

	public static float4 op_Subtraction(float4 lhs, float4 rhs) { }

	public static float4 op_UnaryNegation(float4 val) { }

	public float4 get_xyzx() { }

	public float4 get_yzxy() { }

	public float4 get_yzxz() { }

	public float4 get_zxyy() { }

	public float4 get_zxyz() { }

	public float4 get_wwwx() { }

	public float4 get_wwww() { }

	public float3 get_xyz() { }

	public bool Equals(float4 rhs) { }

	public override bool Equals(object o) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(string format, IFormatProvider formatProvider) { }

}

