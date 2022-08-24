public static class Vector3Ex // TypeDefIndex: 6612
{

	[ExtensionAttribute] 
public static Vector3 WithX(Vector3 v, float x) { }

	[ExtensionAttribute] 
public static Vector3 WithY(Vector3 v, float y) { }

	[ExtensionAttribute] 
public static Vector3 WithZ(Vector3 v, float z) { }

public static Vector3 XZ(Vector3 v) { }

public static float Distance2D(Vector3 a, Vector3 b) { }

public static float HeightDelta(Vector3 a, Vector3 b) { }

public static Vector3 Direction2D(Vector3 aimAt, Vector3 aimFrom) { }

public static Vector3 Direction(Vector3 aimAt, Vector3 aimFrom) { }

public static Vector3 Range(float x, float y) { }

	[ExtensionAttribute] 
public static Vector3 Scale(Vector3 vector, float x, float y, float z) { }

	[ExtensionAttribute] 
public static Vector3 SnapTo(Vector3 vector, float snapValue) { }

	[ExtensionAttribute] 
public static Vector3 Inverse(Vector3 v) { }

	[ExtensionAttribute] 
public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 n) { }

	[ExtensionAttribute] 
public static void FastRenormalize(Vector3 n, float scale = 1) { }

	[ExtensionAttribute] 
public static void ToDirectionAndMagnitude(Vector3 value, out Vector3 direction, out float magnitude) { }

public static Vector3 BlendNormals(Vector3 n1, Vector3 n2) { }

	[ExtensionAttribute] 
public static bool IsNaNOrInfinity(Vector3 v) { }

	[ExtensionAttribute] 
public static float DotRadians(Vector3 a, Vector3 b) { }

	[ExtensionAttribute] 
public static float DotDegrees(Vector3 a, Vector3 b) { }

	[ExtensionAttribute] 
public static float Magnitude2D(Vector3 v) { }

	[ExtensionAttribute] 
public static float SqrMagnitude2D(Vector3 v) { }

	[ExtensionAttribute] 
public static float MagnitudeXY(Vector3 v) { }

	[ExtensionAttribute] 
public static float SqrMagnitudeXY(Vector3 v) { }

	[ExtensionAttribute] 
public static float MagnitudeXZ(Vector3 v) { }

	[ExtensionAttribute] 
public static float SqrMagnitudeXZ(Vector3 v) { }

	[ExtensionAttribute] 
public static float MagnitudeYZ(Vector3 v) { }

	[ExtensionAttribute] 
public static float SqrMagnitudeYZ(Vector3 v) { }

	[ExtensionAttribute] 
public static Vector3 XY3D(Vector3 v) { }

	[ExtensionAttribute] 
public static Vector3 XZ3D(Vector3 v) { }

	[ExtensionAttribute] 
public static Vector3 YZ3D(Vector3 v) { }

	[ExtensionAttribute] 
public static Vector2 XY2D(Vector3 v) { }

	[ExtensionAttribute] 
public static Vector2 XZ2D(Vector3 v) { }

	[ExtensionAttribute] 
public static Vector2 YZ2D(Vector3 v) { }

	[ExtensionAttribute] 
public static Vector2 YX2D(Vector3 v) { }

	[ExtensionAttribute] 
public static Vector2 ZX2D(Vector3 v) { }

	[ExtensionAttribute] 
public static Vector2 ZY2D(Vector3 v) { }

	[ExtensionAttribute] 
public static Vector3 XZ3D(Vector2 v) { }

	[ExtensionAttribute] 
public static float Max(Vector4 v) { }

	[ExtensionAttribute] 
public static float Max(Vector3 v) { }

	[ExtensionAttribute] 
public static float Max(Vector2 v) { }

	[ExtensionAttribute] 
public static Vector4 Abs(Vector4 v) { }

	[ExtensionAttribute] 
public static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] 
public static Vector2 Abs(Vector2 v) { }

public static Vector3 Parse(string p) { }

	[ExtensionAttribute] 
public static Vector3 GetWithInaccuracy(Vector3 o, float maxAngle) { }

}

