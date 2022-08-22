public static class Performance // TypeDefIndex: 6208
{	public static Func<int> GetMemoryUsage; // 0x0
	public static Func<int> GetGarbageCollections; // 0x8
	private static Stopwatch Stopwatch; // 0x10
	private static int frames; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static int <FrameCountLastSecond>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static int <MemoryUsage>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static int <GarbageCollections>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static float <SecondsSinceLastConnection>k__BackingField; // 0x28
	public static int TargetFrameRate; // 0x2C
	private static int[] frameBuckets; // 0x30
	private static float[] frameBucketFractions; // 0x38

	public static FrameRateCategory FrameRateCategory { get; }
	public static int FrameCountLastSecond { get; set; }
	public static double AvgFrameTimeLastSecond { get; }
	public static int MemoryUsage { get; set; }
	public static int GarbageCollections { get; set; }
	public static float SecondsSinceLastConnection { get; set; }
	public static int[] CategorizedFrameCount { get; }


	public static FrameRateCategory get_FrameRateCategory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static int get_FrameCountLastSecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_FrameCountLastSecond(int value) { }

	public static double get_AvgFrameTimeLastSecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static int get_MemoryUsage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_MemoryUsage(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static int get_GarbageCollections() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_GarbageCollections(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static float get_SecondsSinceLastConnection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_SecondsSinceLastConnection(float value) { }

	public static int[] get_CategorizedFrameCount() { }

	internal static void Frame() { }

	private static void OneSecond(double timelapse) { }

	private static FrameRateCategory CategorizeFrameRate(int i) { }

	private static void UpdateFrameBuckets() { }

	public static int GetFrameCount(FrameRateCategory category) { }

	public static float GetFrameFraction(FrameRateCategory category) { }

	private static void .cctor() { }

}

public class Performance : SingletonComponent<Performance> // TypeDefIndex: 9317
{	public static Performance.Tick current; // 0x0
	public static Performance.Tick report; // 0x50
	public const int FrameHistoryCount = 1000;
	private const int HistoryLength = 60;
	private static long cycles; // 0xA0
	private static int[] frameRateHistory; // 0xA8
	private static float[] frameTimeHistory; // 0xB0
	private static int[] frameTimes; // 0xB8
	private int frames; // 0x18
	private float time; // 0x1C


	private void Update() { }

	public List<int> GetFrameTimes(int requestedStart, int maxCount, out int startIndex) { }

	private void FPSTimer() { }

	private float AverageFrameRate() { }

	private float AverageFrameTime() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct Performance.Tick // TypeDefIndex: 9318
{	public int frameID; // 0x0
	public int frameRate; // 0x4
	public float frameTime; // 0x8
	public float frameRateAverage; // 0xC
	public float frameTimeAverage; // 0x10
	public long memoryUsageSystem; // 0x18
	public long memoryAllocations; // 0x20
	public long memoryCollections; // 0x28
	public long loadBalancerTasks; // 0x30
	public long invokeHandlerTasks; // 0x38
	public long workshopSkinsQueued; // 0x40
	public int ping; // 0x48
	public bool gcTriggered; // 0x4C

}

private struct Performance.LagSpike // TypeDefIndex: 9319
{	public int Index; // 0x0
	public int Time; // 0x4

}

