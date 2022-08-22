public class Lerp : ConsoleSystem // TypeDefIndex: 11938
{	[ClientVar] // RVA: 0xAA5D0 Offset: 0xA99D0 VA: 0x1800AA5D0
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


	public static bool get_debug() { }

	public static void set_debug(bool value) { }

	public static float get_inertia() { }

	public static void set_inertia(float value) { }

	public static float get_smoothing() { }

	public static void set_smoothing(float value) { }

	public static float get_interpolation() { }

	public static void set_interpolation(float value) { }

	public static float get_extrapolation() { }

	public static void set_extrapolation(float value) { }

	public static int get_timeoffsetinterval() { }

	public static void set_timeoffsetinterval(int value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

