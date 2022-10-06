public class Random // TypeDefIndex: 288
{
	private const int MBIG = 2147483647;
	private const int MSEED = 161803398;
	private const int MZ = 0;
	private int inext; 
	private int inextp; 
	private int[] SeedArray; 


	public void .ctor() { }

	public void .ctor(int Seed) { }

	protected virtual double Sample() { }

	private int InternalSample() { }

	public virtual int Next() { }

	private double GetSampleForLargeRange() { }

	public virtual int Next(int minValue, int maxValue) { }

	public virtual int Next(int maxValue) { }

	public virtual double NextDouble() { }

}

public sealed class Random // TypeDefIndex: 3489
{
	[StaticAccessorAttribute] 
	public static Random.State state { get; set; }
	public static float value { get; }
	public static Vector3 insideUnitSphere { get; }
	public static Vector2 insideUnitCircle { get; }
	public static Vector3 onUnitSphere { get; }
	public static Quaternion rotation { get; }


	[StaticAccessorAttribute] 
	[NativeMethodAttribute] 
	public static void InitState(int seed) { }

	public static Random.State get_state() { }

	public static void set_state(Random.State value) { }

	[FreeFunctionAttribute] 
	public static float Range(float min, float max) { }

	public static int Range(int min, int max) { }

	[FreeFunctionAttribute] 
	private static int RandomRangeInt(int min, int max) { }

	[FreeFunctionAttribute] 
	public static float get_value() { }

	[FreeFunctionAttribute] 
	public static Vector3 get_insideUnitSphere() { }

	[FreeFunctionAttribute] 
	private static void GetRandomUnitCircle(out Vector2 output) { }

	public static Vector2 get_insideUnitCircle() { }

	[FreeFunctionAttribute] 
	public static Vector3 get_onUnitSphere() { }

	[FreeFunctionAttribute] 
	public static Quaternion get_rotation() { }

	[ObsoleteAttribute] 
	public static int RandomRange(int min, int max) { }

	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) { }

	private static void get_state_Injected(out Random.State ret) { }

	private static void set_state_Injected(ref Random.State value) { }

	private static void get_insideUnitSphere_Injected(out Vector3 ret) { }

	private static void get_onUnitSphere_Injected(out Vector3 ret) { }

	private static void get_rotation_Injected(out Quaternion ret) { }

}

public struct Random.State // TypeDefIndex: 3490
{
	[SerializeField] 
	private int s0; 
	[SerializeField] 
	private int s1; 
	[SerializeField] 
	private int s2; 
	[SerializeField] 
	private int s3; 

}

