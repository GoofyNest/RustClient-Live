public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 7103
{
[DebuggerTypeProxyAttribute] // RVA: 0x7D3E0 Offset: 0x7C7E0 VA: 0x18007D3E0
[DefaultMemberAttribute] // RVA: 0x7D3E0 Offset: 0x7C7E0 VA: 0x18007D3E0
[Serializable]
public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 7103
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public static readonly float3 zero; // 0x0

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	public float3 yzx { get; }


	public void .ctor(float x, float y, float z) { }

	public static float3 op_Multiply(float3 lhs, float3 rhs) { }

	public static float3 op_Multiply(float3 lhs, float rhs) { }

	public static float3 op_Multiply(float lhs, float3 rhs) { }

	public static float3 op_Addition(float3 lhs, float3 rhs) { }

	public static float3 op_Subtraction(float3 lhs, float3 rhs) { }

	public static float3 op_Division(float3 lhs, float rhs) { }

	public static float3 op_UnaryNegation(float3 val) { }

	public float3 get_yzx() { }

	public bool Equals(float3 rhs) { }

	public override bool Equals(object o) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(string format, IFormatProvider formatProvider) { }

	public static Vector3 op_Implicit(float3 v) { }

	public static float3 op_Implicit(Vector3 v) { }

}

