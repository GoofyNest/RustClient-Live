public struct Vector3i : IEquatable<Vector3i> // TypeDefIndex: 4823
{
	public static readonly Vector3i zero; 
	public static readonly Vector3i one; 
	public static readonly Vector3i forward; 
	public static readonly Vector3i back; 
	public static readonly Vector3i up; 
	public static readonly Vector3i down; 
	public static readonly Vector3i right; 
	public static readonly Vector3i left; 
	public int x; 
	public int y; 
	public int z; 


public void .ctor(int x, int y, int z) { }

public static Vector3i op_RightShift(Vector3i v, int shift) { }

public static Vector3i op_LeftShift(Vector3i v, int shift) { }

public static Vector3i op_UnaryPlus(Vector3i v) { }

public static Vector3i op_UnaryNegation(Vector3i v) { }

public static Vector3i op_Addition(Vector3i a, Vector3i b) { }

public static Vector3i op_Subtraction(Vector3i a, Vector3i b) { }

public static Vector3i op_Multiply(Vector3i v, int multiplier) { }

public static Vector3i op_Division(Vector3i v, int divisor) { }

public static Vector3 op_Multiply(Vector3i v, float multiplier) { }

public static Vector3 op_Division(Vector3i v, float divisor) { }

public static Vector3i op_Modulus(Vector3i v, int mod) { }

public static Vector3 op_Implicit(Vector3i other) { }

public static Vector3i op_Explicit(Vector3 other) { }

public static bool op_Equality(Vector3i a, Vector3i b) { }

public static bool op_Inequality(Vector3i a, Vector3i b) { }

public bool Equals(Vector3i o) { }

public override int GetHashCode() { }

public override bool Equals(object o) { }

public override string ToString() { }

private static void .cctor() { }

}

