public class Reflection : ConsoleSystem // TypeDefIndex: 13695
{
	[ClientVar] 
	public static int resolution { get; set; }
	[ClientVar] 
	public static float updateinterval { get; set; }
	[ClientVar] 
	public static int timeslicing { get; set; }


	public static int get_resolution() { }

	public static void set_resolution(int value) { }

	public static float get_updateinterval() { }

	public static void set_updateinterval(float value) { }

	public static int get_timeslicing() { }

	public static void set_timeslicing(int value) { }

	private static ReflectionProbeTimeSlicingMode TimeSlicingFromInt(int i) { }

	private static int TimeSlicingToInt(ReflectionProbeTimeSlicingMode mode) { }

	public void .ctor() { }

}

