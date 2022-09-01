public struct Vector3b : IEquatable<Vector3b> // TypeDefIndex: 4823
{
	public static readonly Vector3b alltrue; 
	public static readonly Vector3b allfalse; 
	public bool x; 
	public bool y; 
	public bool z; 


	public void .ctor(bool x, bool y, bool z) { }

	public static bool op_Equality(Vector3b a, Vector3b b) { }

	public static bool op_Inequality(Vector3b a, Vector3b b) { }

	public bool Equals(Vector3b o) { }

	public override int GetHashCode() { }

	public override bool Equals(object o) { }

	public override string ToString() { }

	private static void .cctor() { }

}

