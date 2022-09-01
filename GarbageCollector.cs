public static class GarbageCollector // TypeDefIndex: 3650
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<GarbageCollector.Mode> GCModeChanged; 

	public static GarbageCollector.Mode GCMode { get; set; }
	public static bool isIncremental { get; }
	public static ulong incrementalTimeSliceNanoseconds { get; set; }


	public static GarbageCollector.Mode get_GCMode() { }

	public static void set_GCMode(GarbageCollector.Mode value) { }

	[NativeThrowsAttribute] 
	private static void SetMode(GarbageCollector.Mode mode) { }

	private static GarbageCollector.Mode GetMode() { }

	[NativeMethodAttribute] 
	public static bool get_isIncremental() { }

	public static ulong get_incrementalTimeSliceNanoseconds() { }

	public static void set_incrementalTimeSliceNanoseconds(ulong value) { }

}

public enum GarbageCollector.Mode // TypeDefIndex: 3651
{
	public int value__; 
	public const GarbageCollector.Mode Disabled = 0;
	public const GarbageCollector.Mode Enabled = 1;

}

