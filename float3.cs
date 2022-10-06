public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 7138
{

[DebuggerTypeProxyAttribute] 
[DefaultMemberAttribute] 
[Serializable]
public struct float3 : IEquatable<float3>, IFormattable
	public float x; 
	public float y; 
	public float z; 
	public static readonly float3 zero; 

	[EditorBrowsableAttribute] 
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

