public struct Vector4 : IEquatable<Vector4> // TypeDefIndex: 3474
{
	public const float kEpsilon = 1E-05;
	public float x; 
	public float y; 
	public float z; 
	public float w; 
	private static readonly Vector4 zeroVector; 
	private static readonly Vector4 oneVector; 
	private static readonly Vector4 positiveInfinityVector; 
	private static readonly Vector4 negativeInfinityVector; 

	public float Item { get; set; }
	public Vector4 normalized { get; }
	public float sqrMagnitude { get; }
	public static Vector4 zero { get; }
	public static Vector4 one { get; }


	public float get_Item(int index) { }

	public void set_Item(int index, float value) { }

	public void .ctor(float x, float y, float z, float w) { }

	public void .ctor(float x, float y, float z) { }

	public static Vector4 Lerp(Vector4 a, Vector4 b, float t) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(Vector4 other) { }

	public static Vector4 Normalize(Vector4 a) { }

	public Vector4 get_normalized() { }

	public static float Dot(Vector4 a, Vector4 b) { }

	public static float Magnitude(Vector4 a) { }

	public float get_sqrMagnitude() { }

	public static Vector4 get_zero() { }

	public static Vector4 get_one() { }

	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	public static Vector4 op_Multiply(Vector4 a, float d) { }

	public static Vector4 op_Multiply(float d, Vector4 a) { }

	public static Vector4 op_Division(Vector4 a, float d) { }

	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	public static Vector4 op_Implicit(Vector3 v) { }

	public static Vector3 op_Implicit(Vector4 v) { }

	public static Vector4 op_Implicit(Vector2 v) { }

	public static Vector2 op_Implicit(Vector4 v) { }

	public override string ToString() { }

	private static void .cctor() { }

}

