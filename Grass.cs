public class Grass : ConsoleSystem // TypeDefIndex: 11926
{	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool displacement; // 0x0
	private static float m_quality; // 0x4
	private static float m_distance; // 0x8
	private static int m_maxthreads; // 0xC
	private static float m_refresh_budget; // 0x10

	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float quality { get; set; }
	public static float quality01 { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float distance { get; set; }
	[ClientVar] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	public static int maxthreads { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
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

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void print_foliage(ConsoleSystem.Arg args) { }

	public void .ctor() { }

	private static void .cctor() { }

}

