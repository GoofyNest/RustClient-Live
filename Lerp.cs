public class Lerp : ConsoleSystem // TypeDefIndex: 11938
{	// Fields
	[ClientVar] // RVA: 0xAA5D0 Offset: 0xA99D0 VA: 0x1800AA5D0
	public static bool enabled; // 0x0
	private static float inertia_cur; // 0x4
	private const float inertia_def = 0;
	private const float inertia_min = 0;
	private const float inertia_max = 1;
	private static float smoothing_cur; // 0x8
	private const float smoothing_def = 0,1;
	private const float smoothing_min = 0;
	private const float smoothing_max = 1;
	private static float interpolation_cur; // 0xC
	private const float interpolation_def = 0,1;
	private const float interpolation_min = 0;
	private const float interpolation_max = 1;
	private static float extrapolation_cur; // 0x10
	private const float extrapolation_def = 1;
	private const float extrapolation_min = 0;
	private const float extrapolation_max = 2;

	// Properties
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool debug { get; set; }
	[ClientVar] // RVA: 0xAA810 Offset: 0xA9C10 VA: 0x1800AA810
	public static float inertia { get; set; }
	[ClientVar] // RVA: 0xAA930 Offset: 0xA9D30 VA: 0x1800AA930
	public static float smoothing { get; set; }
	[ClientVar] // RVA: 0xAA9D0 Offset: 0xA9DD0 VA: 0x1800AA9D0
	public static float interpolation { get; set; }
	[ClientVar] // RVA: 0xAAB00 Offset: 0xA9F00 VA: 0x1800AAB00
	public static float extrapolation { get; set; }
	[ClientVar] // RVA: 0xAAC90 Offset: 0xAA090 VA: 0x1800AAC90
	public static int timeoffsetinterval { get; set; }

	// Methods

	// RVA: 0x364100 Offset: 0x363500 VA: 0x180364100
	public static bool get_debug() { }

	// RVA: 0x364940 Offset: 0x363D40 VA: 0x180364940
	public static void set_debug(bool value) { }

	// RVA: 0x364340 Offset: 0x363740 VA: 0x180364340
	public static float get_inertia() { }

	// RVA: 0x364A50 Offset: 0x363E50 VA: 0x180364A50
	public static void set_inertia(float value) { }

	// RVA: 0x364700 Offset: 0x363B00 VA: 0x180364700
	public static float get_smoothing() { }

	// RVA: 0x364BB0 Offset: 0x363FB0 VA: 0x180364BB0
	public static void set_smoothing(float value) { }

	// RVA: 0x364520 Offset: 0x363920 VA: 0x180364520
	public static float get_interpolation() { }

	// RVA: 0x364B00 Offset: 0x363F00 VA: 0x180364B00
	public static void set_interpolation(float value) { }

	// RVA: 0x364160 Offset: 0x363560 VA: 0x180364160
	public static float get_extrapolation() { }

	// RVA: 0x3649A0 Offset: 0x363DA0 VA: 0x1803649A0
	public static void set_extrapolation(float value) { }

	// RVA: 0x3648E0 Offset: 0x363CE0 VA: 0x1803648E0
	public static int get_timeoffsetinterval() { }

	// RVA: 0x364C60 Offset: 0x364060 VA: 0x180364C60
	public static void set_timeoffsetinterval(int value) { }

	// RVA: 0x3640A0 Offset: 0x3634A0 VA: 0x1803640A0
	public void .ctor() { }

	// RVA: 0x364010 Offset: 0x363410 VA: 0x180364010
	private static void .cctor() { }

}

