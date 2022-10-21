public struct float2 : IEquatable<float2>, IFormattable // TypeDefIndex: 7137
{
	public float x; 
	public float y; 


	public void .ctor(float x, float y) { }

	public void .ctor(int2 v) { }

	public void .ctor(half2 v) { }

	public static float2 op_Implicit(int2 v) { }

	public static float2 op_Implicit(half2 v) { }

	public static float2 op_Subtraction(float2 lhs, float2 rhs) { }

	public bool Equals(float2 rhs) { }

	public override bool Equals(object o) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(string format, IFormatProvider formatProvider) { }

}

