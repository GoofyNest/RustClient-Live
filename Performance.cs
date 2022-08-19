public static class Performance // TypeDefIndex: 6208
{	// Fields
	public static Func<int> GetMemoryUsage; // 0x0
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

	// Properties
	public static FrameRateCategory FrameRateCategory { get; }
	public static int FrameCountLastSecond { get; set; }
	public static double AvgFrameTimeLastSecond { get; }
	public static int MemoryUsage { get; set; }
	public static int GarbageCollections { get; set; }
	public static float SecondsSinceLastConnection { get; set; }
	public static int[] CategorizedFrameCount { get; }

	// Methods

	// RVA: 0x14EE8D0 Offset: 0x14EDCD0 VA: 0x1814EE8D0
	public static FrameRateCategory get_FrameRateCategory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EE810 Offset: 0x14EDC10 VA: 0x1814EE810
	public static int get_FrameCountLastSecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EEC00 Offset: 0x14EE000 VA: 0x1814EEC00
	private static void set_FrameCountLastSecond(int value) { }

	// RVA: 0x14EE690 Offset: 0x14EDA90 VA: 0x1814EE690
	public static double get_AvgFrameTimeLastSecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EEB40 Offset: 0x14EDF40 VA: 0x1814EEB40
	public static int get_MemoryUsage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EECC0 Offset: 0x14EE0C0 VA: 0x1814EECC0
	private static void set_MemoryUsage(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EEAE0 Offset: 0x14EDEE0 VA: 0x1814EEAE0
	public static int get_GarbageCollections() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EEC60 Offset: 0x14EE060 VA: 0x1814EEC60
	private static void set_GarbageCollections(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EEBA0 Offset: 0x14EDFA0 VA: 0x1814EEBA0
	public static float get_SecondsSinceLastConnection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EED20 Offset: 0x14EE120 VA: 0x1814EED20
	private static void set_SecondsSinceLastConnection(float value) { }

	// RVA: 0x14EE7B0 Offset: 0x14EDBB0 VA: 0x1814EE7B0
	public static int[] get_CategorizedFrameCount() { }

	// RVA: 0x14EDE40 Offset: 0x14ED240 VA: 0x1814EDE40
	internal static void Frame() { }

	// RVA: 0x14EE090 Offset: 0x14ED490 VA: 0x1814EE090
	private static void OneSecond(double timelapse) { }

	// RVA: 0x14EDCC0 Offset: 0x14ED0C0 VA: 0x1814EDCC0
	private static FrameRateCategory CategorizeFrameRate(int i) { }

	// RVA: 0x14EE360 Offset: 0x14ED760 VA: 0x1814EE360
	private static void UpdateFrameBuckets() { }

	// RVA: 0x14EDF70 Offset: 0x14ED370 VA: 0x1814EDF70
	public static int GetFrameCount(FrameRateCategory category) { }

	// RVA: 0x14EE000 Offset: 0x14ED400 VA: 0x1814EE000
	public static float GetFrameFraction(FrameRateCategory category) { }

	// RVA: 0x14EE570 Offset: 0x14ED970 VA: 0x1814EE570
	private static void .cctor() { }

}

public class Performance : SingletonComponent<Performance> // TypeDefIndex: 9317
{	// Fields
	public static Performance.Tick current; // 0x0
	public static Performance.Tick report; // 0x50
	public const int FrameHistoryCount = 1000;
	private const int HistoryLength = 60;
	private static long cycles; // 0xA0
	private static int[] frameRateHistory; // 0xA8
	private static float[] frameTimeHistory; // 0xB0
	private static int[] frameTimes; // 0xB8
	private int frames; // 0x18
	private float time; // 0x1C

	// Methods

	// RVA: 0x94AF10 Offset: 0x94A310 VA: 0x18094AF10
	private void Update() { }

	// RVA: 0x94AD70 Offset: 0x94A170 VA: 0x18094AD70
	public List<int> GetFrameTimes(int requestedStart, int maxCount, out int startIndex) { }

	// RVA: 0x94A670 Offset: 0x949A70 VA: 0x18094A670
	private void FPSTimer() { }

	// RVA: 0x94A3E0 Offset: 0x9497E0 VA: 0x18094A3E0
	private float AverageFrameRate() { }

	// RVA: 0x94A510 Offset: 0x949910 VA: 0x18094A510
	private float AverageFrameTime() { }

	// RVA: 0x94B150 Offset: 0x94A550 VA: 0x18094B150
	public void .ctor() { }

	// RVA: 0x94B080 Offset: 0x94A480 VA: 0x18094B080
	private static void .cctor() { }

}

public struct Performance.Tick // TypeDefIndex: 9318
{	// Fields
	public int frameID; // 0x0
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
{	// Fields
	public int Index; // 0x0
	public int Time; // 0x4

}

