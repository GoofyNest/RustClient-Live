public class Random // TypeDefIndex: 288
{	// Fields
	private const int MBIG = 2147483647;
	private const int MSEED = 161803398;
	private const int MZ = 0;
	private int inext; // 0x10
	private int inextp; // 0x14
	private int[] SeedArray; // 0x18

	// Methods

	// RVA: 0x18CFAC0 Offset: 0x18CEEC0 VA: 0x1818CFAC0
	public void .ctor() { }

	// RVA: 0x18CFAF0 Offset: 0x18CEEF0 VA: 0x1818CFAF0
	public void .ctor(int Seed) { }

	// RVA: 0x18CFAA0 Offset: 0x18CEEA0 VA: 0x1818CFAA0 Slot: 4
	protected virtual double Sample() { }

	// RVA: 0x18CF760 Offset: 0x18CEB60 VA: 0x1818CF760
	private int InternalSample() { }

	// RVA: 0x18CF810 Offset: 0x18CEC10 VA: 0x1818CF810 Slot: 5
	public virtual int Next() { }

	// RVA: 0x18CF700 Offset: 0x18CEB00 VA: 0x1818CF700
	private double GetSampleForLargeRange() { }

	// RVA: 0x18CF820 Offset: 0x18CEC20 VA: 0x1818CF820 Slot: 6
	public virtual int Next(int minValue, int maxValue) { }

	// RVA: 0x18CF9B0 Offset: 0x18CEDB0 VA: 0x1818CF9B0 Slot: 7
	public virtual int Next(int maxValue) { }

	// RVA: 0x4D0950 Offset: 0x4CFD50 VA: 0x1804D0950 Slot: 8
	public virtual double NextDouble() { }

}

public sealed class Random // TypeDefIndex: 3487
{	// Properties
	[StaticAccessorAttribute] // RVA: 0xB41C0 Offset: 0xB35C0 VA: 0x1800B41C0
	public static Random.State state { get; set; }
	public static float value { get; }
	public static Vector3 insideUnitSphere { get; }
	public static Vector2 insideUnitCircle { get; }
	public static Vector3 onUnitSphere { get; }
	public static Quaternion rotation { get; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xB3810 Offset: 0xB2C10 VA: 0x1800B3810
	[NativeMethodAttribute] // RVA: 0xB3810 Offset: 0xB2C10 VA: 0x1800B3810
	// RVA: 0x18FAB40 Offset: 0x18F9F40 VA: 0x1818FAB40
	public static void InitState(int seed) { }

	// RVA: 0x18FAE10 Offset: 0x18FA210 VA: 0x1818FAE10
	public static Random.State get_state() { }

	// RVA: 0x18FAEC0 Offset: 0x18FA2C0 VA: 0x1818FAEC0
	public static void set_state(Random.State value) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x18FABC0 Offset: 0x18F9FC0 VA: 0x1818FABC0
	public static float Range(float min, float max) { }

	// RVA: 0x18FAB80 Offset: 0x18F9F80 VA: 0x1818FAB80
	public static int Range(int min, int max) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x18FAB80 Offset: 0x18F9F80 VA: 0x1818FAB80
	private static int RandomRangeInt(int min, int max) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x18FAE50 Offset: 0x18FA250 VA: 0x1818FAE50
	public static float get_value() { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x18FAC90 Offset: 0x18FA090 VA: 0x1818FAC90
	public static Vector3 get_insideUnitSphere() { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x18FAB00 Offset: 0x18F9F00 VA: 0x1818FAB00
	private static void GetRandomUnitCircle(out Vector2 output) { }

	// RVA: 0x18FAC10 Offset: 0x18FA010 VA: 0x1818FAC10
	public static Vector2 get_insideUnitCircle() { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x18FAD10 Offset: 0x18FA110 VA: 0x1818FAD10
	public static Vector3 get_onUnitSphere() { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x18FAD90 Offset: 0x18FA190 VA: 0x1818FAD90
	public static Quaternion get_rotation() { }

	[ObsoleteAttribute] // RVA: 0xB40E0 Offset: 0xB34E0 VA: 0x1800B40E0
	// RVA: 0x18FAB80 Offset: 0x18F9F80 VA: 0x1818FAB80
	public static int RandomRange(int min, int max) { }

	// RVA: 0x18FA940 Offset: 0x18F9D40 VA: 0x1818FA940
	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) { }

	// RVA: 0x18FADD0 Offset: 0x18FA1D0 VA: 0x1818FADD0
	private static void get_state_Injected(out Random.State ret) { }

	// RVA: 0x18FAE80 Offset: 0x18FA280 VA: 0x1818FAE80
	private static void set_state_Injected(ref Random.State value) { }

	// RVA: 0x18FAC50 Offset: 0x18FA050 VA: 0x1818FAC50
	private static void get_insideUnitSphere_Injected(out Vector3 ret) { }

	// RVA: 0x18FACD0 Offset: 0x18FA0D0 VA: 0x1818FACD0
	private static void get_onUnitSphere_Injected(out Vector3 ret) { }

	// RVA: 0x18FAD50 Offset: 0x18FA150 VA: 0x1818FAD50
	private static void get_rotation_Injected(out Quaternion ret) { }

}

public struct Random.State // TypeDefIndex: 3488
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int s0; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int s1; // 0x4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int s2; // 0x8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int s3; // 0xC

}

