public static class Performance // TypeDefIndex: 6209
{
	public static Func<int> GetMemoryUsage; 
	public static Func<int> GetGarbageCollections; 
	private static Stopwatch Stopwatch; 
	private static int frames; 
	[CompilerGeneratedAttribute] 
	private static int <FrameCountLastSecond>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static int <MemoryUsage>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static int <GarbageCollections>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static float <SecondsSinceLastConnection>k__BackingField; 
	public static int TargetFrameRate; 
	private static int[] frameBuckets; 
	private static float[] frameBucketFractions; 

	public static FrameRateCategory FrameRateCategory { get; }
	public static int FrameCountLastSecond { get; set; }
	public static double AvgFrameTimeLastSecond { get; }
	public static int MemoryUsage { get; set; }
	public static int GarbageCollections { get; set; }
	public static float SecondsSinceLastConnection { get; set; }
	public static int[] CategorizedFrameCount { get; }


	public static FrameRateCategory get_FrameRateCategory() { }

	[CompilerGeneratedAttribute] 
	public static int get_FrameCountLastSecond() { }

	[CompilerGeneratedAttribute] 
	private static void set_FrameCountLastSecond(int value) { }

	public static double get_AvgFrameTimeLastSecond() { }

	[CompilerGeneratedAttribute] 
	public static int get_MemoryUsage() { }

	[CompilerGeneratedAttribute] 
	private static void set_MemoryUsage(int value) { }

	[CompilerGeneratedAttribute] 
	public static int get_GarbageCollections() { }

	[CompilerGeneratedAttribute] 
	private static void set_GarbageCollections(int value) { }

	[CompilerGeneratedAttribute] 
	public static float get_SecondsSinceLastConnection() { }

	[CompilerGeneratedAttribute] 
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

public class Performance : SingletonComponent<Performance> // TypeDefIndex: 9321
{
	public static Performance.Tick current; 
	public static Performance.Tick report; 
	public const int FrameHistoryCount = 1000;
	private const int HistoryLength = 60;
	private static long cycles; 
	private static int[] frameRateHistory; 
	private static float[] frameTimeHistory; 
	private static int[] frameTimes; 
	private int frames; 
	private float time; 


	private void Update() { }

	public List<int> GetFrameTimes(int requestedStart, int maxCount, out int startIndex) { }

	private void FPSTimer() { }

	private float AverageFrameRate() { }

	private float AverageFrameTime() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct Performance.Tick // TypeDefIndex: 9322
{
	public int frameID; 
	public int frameRate; 
	public float frameTime; 
	public float frameRateAverage; 
	public float frameTimeAverage; 
	public long memoryUsageSystem; 
	public long memoryAllocations; 
	public long memoryCollections; 
	public long loadBalancerTasks; 
	public long invokeHandlerTasks; 
	public long workshopSkinsQueued; 
	public int ping; 
	public bool gcTriggered; 

}

private struct Performance.LagSpike // TypeDefIndex: 9323
{
	public int Index; 
	public int Time; 

}

