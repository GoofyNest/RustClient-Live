public struct Mathf // TypeDefIndex: 3469
{
	public static readonly float Epsilon; 


	[FreeFunctionAttribute] 
public static int ClosestPowerOfTwo(int value) { }

	[FreeFunctionAttribute] 
public static bool IsPowerOfTwo(int value) { }

	[FreeFunctionAttribute] 
public static int NextPowerOfTwo(int value) { }

	[FreeFunctionAttribute] 
public static float GammaToLinearSpace(float value) { }

	[FreeFunctionAttribute] 
public static float LinearToGammaSpace(float value) { }

	[FreeFunctionAttribute] 
public static ushort FloatToHalf(float val) { }

	[FreeFunctionAttribute] 
public static float HalfToFloat(ushort val) { }

	[FreeFunctionAttribute] 
public static float PerlinNoise(float x, float y) { }

public static float Sin(float f) { }

public static float Cos(float f) { }

public static float Tan(float f) { }

public static float Asin(float f) { }

public static float Acos(float f) { }

public static float Atan(float f) { }

public static float Atan2(float y, float x) { }

public static float Sqrt(float f) { }

public static float Abs(float f) { }

public static int Abs(int value) { }

public static float Min(float a, float b) { }

public static int Min(int a, int b) { }

public static float Max(float a, float b) { }

public static float Max(float[] values) { }

public static int Max(int a, int b) { }

public static float Pow(float f, float p) { }

public static float Exp(float power) { }

public static float Log(float f, float p) { }

public static float Log(float f) { }

public static float Log10(float f) { }

public static float Ceil(float f) { }

public static float Floor(float f) { }

public static float Round(float f) { }

public static int CeilToInt(float f) { }

public static int FloorToInt(float f) { }

public static int RoundToInt(float f) { }

public static float Sign(float f) { }

public static float Clamp(float value, float min, float max) { }

public static int Clamp(int value, int min, int max) { }

public static float Clamp01(float value) { }

public static float Lerp(float a, float b, float t) { }

public static float LerpUnclamped(float a, float b, float t) { }

public static float LerpAngle(float a, float b, float t) { }

public static float MoveTowards(float current, float target, float maxDelta) { }

public static float MoveTowardsAngle(float current, float target, float maxDelta) { }

public static float SmoothStep(float from, float to, float t) { }

public static bool Approximately(float a, float b) { }

	[ExcludeFromDocsAttribute] 
public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime) { }

public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

public static float Repeat(float t, float length) { }

public static float InverseLerp(float a, float b, float value) { }

public static float DeltaAngle(float current, float target) { }

private static void .cctor() { }

}

