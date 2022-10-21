public struct half : IEquatable<half>, IFormattable // TypeDefIndex: 7143
{

[Serializable]
public struct half : IEquatable<half>, IFormattable
	public ushort value; 


	public static float op_Implicit(half d) { }

	public static bool op_Equality(half lhs, half rhs) { }

	public bool Equals(half rhs) { }

	public override bool Equals(object o) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(string format, IFormatProvider formatProvider) { }

}

