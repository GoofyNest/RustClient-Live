public class Grass : ConsoleSystem // TypeDefIndex: 11926
{	// Fields
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool displacement; // 0x0
	private static float m_quality; // 0x4
	private static float m_distance; // 0x8
	private static int m_maxthreads; // 0xC
	private static float m_refresh_budget; // 0x10

	// Properties
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float quality { get; set; }
	public static float quality01 { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float distance { get; set; }
	[ClientVar] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	public static int maxthreads { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float refresh_budget { get; set; }

	// Methods

	// RVA: 0x361E10 Offset: 0x361210 VA: 0x180361E10
	public static float get_quality() { }

	// RVA: 0x362610 Offset: 0x361A10 VA: 0x180362610
	public static void set_quality(float value) { }

	// RVA: 0x361D60 Offset: 0x361160 VA: 0x180361D60
	public static float get_quality01() { }

	// RVA: 0x362430 Offset: 0x361830 VA: 0x180362430
	public static void set_quality01(float value) { }

	// RVA: 0x361CA0 Offset: 0x3610A0 VA: 0x180361CA0
	public static float get_distance() { }

	// RVA: 0x362200 Offset: 0x361600 VA: 0x180362200
	public static void set_distance(float value) { }

	// RVA: 0x361D00 Offset: 0x361100 VA: 0x180361D00
	public static int get_maxthreads() { }

	// RVA: 0x362390 Offset: 0x361790 VA: 0x180362390
	public static void set_maxthreads(int value) { }

	// RVA: 0x361E70 Offset: 0x361270 VA: 0x180361E70
	public static float get_refresh_budget() { }

	// RVA: 0x3627A0 Offset: 0x361BA0 VA: 0x1803627A0
	public static void set_refresh_budget(float value) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x361ED0 Offset: 0x3612D0 VA: 0x180361ED0
	public static void print_foliage(ConsoleSystem.Arg args) { }

	// RVA: 0x361C40 Offset: 0x361040 VA: 0x180361C40
	public void .ctor() { }

	// RVA: 0x361BB0 Offset: 0x360FB0 VA: 0x180361BB0
	private static void .cctor() { }

}

