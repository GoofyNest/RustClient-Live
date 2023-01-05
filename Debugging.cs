public class Debugging : ConsoleSystem // TypeDefIndex: 13715
{
	[ServerVar]
	[ClientVar]
	public static bool checktriggers;
	[ServerVar]
	public static bool checkparentingtriggers;
	[ServerVar]
	[ClientVar]
	public static bool DebugDismounts;
	[ClientVar]
	[ServerVar]
	public static bool callbacks;
	[ClientVar]
	public static Buttons.ConButton debugcamera_targetbind;
	[ClientVar]
	public static Buttons.ConButton debugcamera_dollyforward;
	[ClientVar]
	public static Buttons.ConButton debugcamera_dollyback;
	[ClientVar]
	public static Buttons.ConButton debugcamera_cyclebone;
	[ClientVar]
	public static float debugcamera_dollyspeed;
	[ClientVar]
	public static Buttons.ConButton debugcamera_raise;
	[ClientVar]
	public static Buttons.ConButton debugcamera_lower;
	[ClientVar]
	public static Buttons.ConButton debugcamera_zoomin;
	[ClientVar]
	public static Buttons.ConButton debugcamera_zoomout;
	[ClientVar]
	public static Vector3 debugcamera_offset;
	[ClientVar]
	public static bool debugcamera_bonerotation;
	[ClientVar]
	public static bool debugcamera_lookat;
	[ClientVar]
	public static bool debugcamera_autosave;
	[ClientVar]
	public static bool debugcamera_autoload;
	[ClientVar]
	public static bool debugcamera_preserve;
	[ClientVar]
	public static bool debugcamera_lock;
	[ClientVar]
	public static bool drawcolliders;
	[ClientVar]
	public static bool ambientvolumes;
	[ClientVar]
	public static bool oninventorychanged;
	[ClientVar]
	public static string fakeSpeechPlayer;
	[ClientVar]
	public static bool showWorldInfoInPerformanceReadout;
	[ClientVar]
	public static bool showViewmodelAimHelper;
	[ClientVar]
	public static float viewmodelAimHelpWidth;

	[ServerVar]
	[ClientVar]
	public static bool log { get; set; }
	[ClientVar]
	public static bool skyreflection { get; set; }
	[ClientVar]
	public static bool invokePerformanceTracking { get; set; }
	[ClientVar]
	public static float invokePerformanceThreshold { get; set; }


	[ServerVar]
	[ClientVar]
	public static void renderinfo(ConsoleSystem.Arg arg) { }

	public static void set_log(bool value) { }

	public static bool get_log() { }

	[ServerVar]
	public static void enable_player_movement(ConsoleSystem.Arg arg) { }

	[ClientVar]
	[ServerVar]
	public static void stall(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void lookingat(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void lookingat_debug(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void debugcamera(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static string debugcamera_fov(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void debugcamera_target(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static string debugcamera_guide(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static string debugcamera_guide_color(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void debugcamera_shake(float amplitude, float frequency, float duration) { }

	[ClientVar]
	public static void debugcamera_stopshake() { }

	[ClientVar]
	public static string debugcamera_guide_aspectratio(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void debugcamera_save(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void debugcamera_load(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void debugcamera_savetofile(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void debugcamera_clear(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void debugcamera_list(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void debugcamera_targetprint(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static Debugging.EntityInfo[] ent_find_radius(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void noclip(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void debugcamera_unfreeze(ConsoleSystem.Arg arg) { }

	public static bool get_skyreflection() { }

	public static void set_skyreflection(bool value) { }

	[ClientVar]
	public static void PrintDebugWorldInfo(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void CopyDebugWorldInfo(ConsoleSystem.Arg arg) { }

	private static string DebugPrintout() { }

	public static bool get_invokePerformanceTracking() { }

	public static void set_invokePerformanceTracking(bool value) { }

	public static float get_invokePerformanceThreshold() { }

	public static void set_invokePerformanceThreshold(float value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct Debugging.EntityInfo // TypeDefIndex: 13716
{
	public string name;
	public uint netId;

}

private sealed class Debugging.<>c__DisplayClass42_0 // TypeDefIndex: 13717
{
	public Vector3 position;
	public float radius;


	public void .ctor() { }

	internal bool <ent_find_radius>

}

private sealed class Debugging.<>c // TypeDefIndex: 13718
{
	public static readonly Debugging.<>c <>9;
	public static Func<BaseNetworkable, uint> <>9__42_1;
	public static Func<IGrouping<uint, BaseNetworkable>, BaseNetworkable> <>9__42_2;
	public static Func<BaseNetworkable, Debugging.EntityInfo> <>9__42_3;


	private static void .cctor() { }

	public void .ctor() { }

	internal uint <ent_find_radius>

	internal BaseNetworkable <ent_find_radius>

	internal Debugging.EntityInfo <ent_find_radius>

}

