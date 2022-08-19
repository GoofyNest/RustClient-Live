public static class GarbageCollector // TypeDefIndex: 3650
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Action<GarbageCollector.Mode> GCModeChanged; // 0x13AFC

	// Properties
	public static GarbageCollector.Mode GCMode { get; set; }
	public static bool isIncremental { get; }
	public static ulong incrementalTimeSliceNanoseconds { get; set; }

	// Methods

	// RVA: 0x19A4E30 Offset: 0x19A4230 VA: 0x1819A4E30
	public static GarbageCollector.Mode get_GCMode() { }

	// RVA: 0x19A4F00 Offset: 0x19A4300 VA: 0x1819A4F00
	public static void set_GCMode(GarbageCollector.Mode value) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x19A4E60 Offset: 0x19A4260 VA: 0x1819A4E60
	private static void SetMode(GarbageCollector.Mode mode) { }

	// RVA: 0x19A4E30 Offset: 0x19A4230 VA: 0x1819A4E30
	private static GarbageCollector.Mode GetMode() { }

	[NativeMethodAttribute] // RVA: 0xE11F0 Offset: 0xE05F0 VA: 0x1800E11F0
	// RVA: 0x19A4ED0 Offset: 0x19A42D0 VA: 0x1819A4ED0
	public static bool get_isIncremental() { }

	// RVA: 0x19A4EA0 Offset: 0x19A42A0 VA: 0x1819A4EA0
	public static ulong get_incrementalTimeSliceNanoseconds() { }

	// RVA: 0x19A4FA0 Offset: 0x19A43A0 VA: 0x1819A4FA0
	public static void set_incrementalTimeSliceNanoseconds(ulong value) { }

}

public enum GarbageCollector.Mode // TypeDefIndex: 3651
{	// Fields
	public int value__; // 0x0
	public const GarbageCollector.Mode Disabled = 0;
	public const GarbageCollector.Mode Enabled = 1;

}

