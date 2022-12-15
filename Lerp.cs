public class Lerp : ConsoleSystem // TypeDefIndex: 13757
{
	[ClientVar]
	public static bool enabled;
	private static float inertia_cur;
	private const float inertia_def = 0;
	private const float inertia_min = 0;
	private const float inertia_max = 1;
	private static float smoothing_cur;
	private const float smoothing_def = 0,1;
	private const float smoothing_min = 0;
	private const float smoothing_max = 1;
	private static float interpolation_cur;
	private const float interpolation_def = 0,1;
	private const float interpolation_min = 0;
	private const float interpolation_max = 1;
	private static float extrapolation_cur;
	private const float extrapolation_def = 1;
	private const float extrapolation_min = 0;
	private const float extrapolation_max = 2;

	[ClientVar]
	public static bool debug { get; set; }
	[ClientVar]
	public static float inertia { get; set; }
	[ClientVar]
	public static float smoothing { get; set; }
	[ClientVar]
	public static float interpolation { get; set; }
	[ClientVar]
	public static float extrapolation { get; set; }
	[ClientVar]
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

