public class Culling : ConsoleSystem // TypeDefIndex: 11893
{	[ClientVar] // RVA: 0x91110 Offset: 0x90510 VA: 0x180091110
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

	[ClientVar] // RVA: 0x91570 Offset: 0x90970 VA: 0x180091570
	public static bool toggle { get; set; }
	[ClientVar] // RVA: 0x91640 Offset: 0x90A40 VA: 0x180091640
	public static bool safeMode { get; set; }
	[ClientVar] // RVA: 0x917C0 Offset: 0x90BC0 VA: 0x1800917C0
	public static bool env { get; set; }
	[ClientVar] // RVA: 0x91870 Offset: 0x90C70 VA: 0x180091870
	public static int debug { get; set; }


	public static bool get_toggle() { }

	public static void set_toggle(bool value) { }

	public static bool get_safeMode() { }

	public static void set_safeMode(bool value) { }

	public static bool get_env() { }

	public static void set_env(bool value) { }

	public static int get_debug() { }

	public static void set_debug(int value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

