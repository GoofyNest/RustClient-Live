public class Culling : ConsoleSystem // TypeDefIndex: 11893
{	// Fields
	[ClientVar] // RVA: 0x91110 Offset: 0x90510 VA: 0x180091110
	public static float entityUpdateRate; // 0x0
	[ClientVar] // RVA: 0x911B0 Offset: 0x905B0 VA: 0x1800911B0
	public static float entityMinCullDist; // 0x4
	public const float entityMinAnimatorCullDist = 100;
	[ClientVar] // RVA: 0x91250 Offset: 0x90650 VA: 0x180091250
	public static float entityMinShadowCullDist; // 0x8
	[ClientVar] // RVA: 0x912C0 Offset: 0x906C0 VA: 0x1800912C0
	public static float entityMaxDist; // 0xC
	private static bool _env; // 0x10
	[ClientVar] // RVA: 0x91330 Offset: 0x90730 VA: 0x180091330
	public static float envMinDist; // 0x14
	[ClientVar] // RVA: 0x91400 Offset: 0x90800 VA: 0x180091400
	public static bool noDataVisible; // 0x18

	// Properties
	[ClientVar] // RVA: 0x91570 Offset: 0x90970 VA: 0x180091570
	public static bool toggle { get; set; }
	[ClientVar] // RVA: 0x91640 Offset: 0x90A40 VA: 0x180091640
	public static bool safeMode { get; set; }
	[ClientVar] // RVA: 0x917C0 Offset: 0x90BC0 VA: 0x1800917C0
	public static bool env { get; set; }
	[ClientVar] // RVA: 0x91870 Offset: 0x90C70 VA: 0x180091870
	public static int debug { get; set; }

	// Methods

	// RVA: 0x6D2870 Offset: 0x6D1C70 VA: 0x1806D2870
	public static bool get_toggle() { }

	// RVA: 0x6D2B00 Offset: 0x6D1F00 VA: 0x1806D2B00
	public static void set_toggle(bool value) { }

	// RVA: 0x6D27D0 Offset: 0x6D1BD0 VA: 0x1806D27D0
	public static bool get_safeMode() { }

	// RVA: 0x6D2A50 Offset: 0x6D1E50 VA: 0x1806D2A50
	public static void set_safeMode(bool value) { }

	// RVA: 0x6D2770 Offset: 0x6D1B70 VA: 0x1806D2770
	public static bool get_env() { }

	// RVA: 0x6D29C0 Offset: 0x6D1DC0 VA: 0x1806D29C0
	public static void set_env(bool value) { }

	// RVA: 0x6D2590 Offset: 0x6D1990 VA: 0x1806D2590
	public static int get_debug() { }

	// RVA: 0x6D2910 Offset: 0x6D1D10 VA: 0x1806D2910
	public static void set_debug(int value) { }

	// RVA: 0x6D2530 Offset: 0x6D1930 VA: 0x1806D2530
	public void .ctor() { }

	// RVA: 0x6D2480 Offset: 0x6D1880 VA: 0x1806D2480
	private static void .cctor() { }

}

