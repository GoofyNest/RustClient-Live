public class Culling : ConsoleSystem // TypeDefIndex: 13712
{
	[ClientVar]
	public static float entityUpdateRate;
	[ClientVar]
	public static float entityMinCullDist;
	public const float entityMinAnimatorCullDist = 100;
	[ClientVar]
	public static float entityMinShadowCullDist;
	[ClientVar]
	public static float entityMaxDist;
	private static bool _env;
	[ClientVar]
	public static float envMinDist;
	[ClientVar]
	public static bool noDataVisible;

	[ClientVar]
	public static bool toggle { get; set; }
	[ClientVar]
	public static bool safeMode { get; set; }
	[ClientVar]
	public static bool env { get; set; }
	[ClientVar]
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

