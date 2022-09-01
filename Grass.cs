public class Grass : ConsoleSystem // TypeDefIndex: 11954
{
	[ClientVar] 
	public static bool displacement; 
	private static float m_quality; 
	private static float m_distance; 
	private static int m_maxthreads; 
	private static float m_refresh_budget; 

	[ClientVar] 
	public static float quality { get; set; }
	public static float quality01 { get; set; }
	[ClientVar] 
	public static float distance { get; set; }
	[ClientVar] 
	public static int maxthreads { get; set; }
	[ClientVar] 
	public static float refresh_budget { get; set; }


	public static float get_quality() { }

	public static void set_quality(float value) { }

	public static float get_quality01() { }

	public static void set_quality01(float value) { }

	public static float get_distance() { }

	public static void set_distance(float value) { }

	public static int get_maxthreads() { }

	public static void set_maxthreads(int value) { }

	public static float get_refresh_budget() { }

	public static void set_refresh_budget(float value) { }

	[ClientVar] 
	public static void print_foliage(ConsoleSystem.Arg args) { }

	public void .ctor() { }

	private static void .cctor() { }

}

