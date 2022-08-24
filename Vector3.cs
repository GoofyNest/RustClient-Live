public struct Vector3 : IEquatable<Vector3> // TypeDefIndex: 3467
{
public const float kEpsilon = 1E-05;
public const float kEpsilonNormalSqrt = 1E-15;
	public float x; 
	public float y; 
	public float z; 
	private static readonly Vector3 zeroVector; 
	private static readonly Vector3 oneVector; 
	private static readonly Vector3 upVector; 
	private static readonly Vector3 downVector; 
	private static readonly Vector3 leftVector; 
	private static readonly Vector3 rightVector; 
	private static readonly Vector3 forwardVector; 
	private static readonly Vector3 backVector; 
	private static readonly Vector3 positiveInfinityVector; 
	private static readonly Vector3 negativeInfinityVector; 

public float Item { get; set; }
public Vector3 normalized { get; }
public float magnitude { get; }
public float sqrMagnitude { get; }
public static Vector3 zero { get; }
public static Vector3 one { get; }
public static Vector3 forward { get; }
public static Vector3 back { get; }
public static Vector3 up { get; }
public static Vector3 down { get; }
public static Vector3 left { get; }
public static Vector3 right { get; }
public static Vector3 positiveInfinity { get; }


	[FreeFunctionAttribute] 
public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[FreeFunctionAttribute] 
private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	[FreeFunctionAttribute] 
public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	[ExcludeFromDocsAttribute] 
public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) { }

public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

public float get_Item(int index) { }

public void set_Item(int index, float value) { }

public void .ctor(float x, float y, float z) { }

public void .ctor(float x, float y) { }

public void Set(float newX, float newY, float newZ) { }

public static Vector3 Scale(Vector3 a, Vector3 b) { }

public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

public override int GetHashCode() { }

public override bool Equals(object other) { }

public bool Equals(Vector3 other) { }

public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

public static Vector3 Normalize(Vector3 value) { }

public void Normalize() { }

public Vector3 get_normalized() { }

public static float Dot(Vector3 lhs, Vector3 rhs) { }

public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

public static float Angle(Vector3 from, Vector3 to) { }

public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

public static float Distance(Vector3 a, Vector3 b) { }

public static float Magnitude(Vector3 vector) { }

public float get_magnitude() { }

public static float SqrMagnitude(Vector3 vector) { }

public float get_sqrMagnitude() { }

public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

public static Vector3 get_zero() { }

public static Vector3 get_one() { }

public static Vector3 get_forward() { }

public static Vector3 get_back() { }

public static Vector3 get_up() { }

public static Vector3 get_down() { }

public static Vector3 get_left() { }

public static Vector3 get_right() { }

public static Vector3 get_positiveInfinity() { }

public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

public static Vector3 op_UnaryNegation(Vector3 a) { }

public static Vector3 op_Multiply(Vector3 a, float d) { }

public static Vector3 op_Multiply(float d, Vector3 a) { }

public static Vector3 op_Division(Vector3 a, float d) { }

public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

public override string ToString() { }

private static void .cctor() { }

private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }

private static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) { }

}

