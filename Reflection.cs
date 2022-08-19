public class Reflection : ConsoleSystem // TypeDefIndex: 11954
{	// Fields
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool interiors; // 0x0
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool forests; // 0x1

	// Properties
	[ClientVar] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	public static int resolution { get; set; }
	[ClientVar] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	public static float updateinterval { get; set; }
	[ClientVar] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	public static int timeslicing { get; set; }

	// Methods

	// RVA: 0x369070 Offset: 0x368470 VA: 0x180369070
	public static int get_resolution() { }

	// RVA: 0x3691C0 Offset: 0x3685C0 VA: 0x1803691C0
	public static void set_resolution(int value) { }

	// RVA: 0x369160 Offset: 0x368560 VA: 0x180369160
	public static float get_updateinterval() { }

	// RVA: 0x369340 Offset: 0x368740 VA: 0x180369340
	public static void set_updateinterval(float value) { }

	// RVA: 0x3690D0 Offset: 0x3684D0 VA: 0x1803690D0
	public static int get_timeslicing() { }

	// RVA: 0x369270 Offset: 0x368670 VA: 0x180369270
	public static void set_timeslicing(int value) { }

	// RVA: 0x368FD0 Offset: 0x3683D0 VA: 0x180368FD0
	private static ReflectionProbeTimeSlicingMode TimeSlicingFromInt(int i) { }

	// RVA: 0x368FF0 Offset: 0x3683F0 VA: 0x180368FF0
	private static int TimeSlicingToInt(ReflectionProbeTimeSlicingMode mode) { }

	// RVA: 0x369010 Offset: 0x368410 VA: 0x180369010
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

