public struct Vector2 : IEquatable<Vector2> // TypeDefIndex: 3471
{
	public float x; 
	public float y; 
	private static readonly Vector2 zeroVector; 
	private static readonly Vector2 oneVector; 
	private static readonly Vector2 upVector; 
	private static readonly Vector2 downVector; 
	private static readonly Vector2 leftVector; 
	private static readonly Vector2 rightVector; 
	private static readonly Vector2 positiveInfinityVector; 
	private static readonly Vector2 negativeInfinityVector; 
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;

	public float Item { get; set; }
	public Vector2 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector2 zero { get; }
	public static Vector2 one { get; }
	public static Vector2 up { get; }
	public static Vector2 right { get; }


	public float get_Item(int index) { }

	public void set_Item(int index, float value) { }

	public void .ctor(float x, float y) { }

	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	public void Normalize() { }

	public Vector2 get_normalized() { }

	public override string ToString() { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(Vector2 other) { }

	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	public float get_magnitude() { }

	public float get_sqrMagnitude() { }

	public static float Angle(Vector2 from, Vector2 to) { }

	public static float Distance(Vector2 a, Vector2 b) { }

	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	public static Vector2 op_UnaryNegation(Vector2 a) { }

	public static Vector2 op_Multiply(Vector2 a, float d) { }

	public static Vector2 op_Multiply(float d, Vector2 a) { }

	public static Vector2 op_Division(Vector2 a, float d) { }

	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	public static Vector2 op_Implicit(Vector3 v) { }

	public static Vector3 op_Implicit(Vector2 v) { }

	public static Vector2 get_zero() { }

	public static Vector2 get_one() { }

	public static Vector2 get_up() { }

	public static Vector2 get_right() { }

	private static void .cctor() { }

}

