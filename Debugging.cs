public class Debugging : ConsoleSystem // TypeDefIndex: 11896
{	// Fields
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static bool checktriggers; // 0x0
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool checkparentingtriggers; // 0x1
	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static bool callbacks; // 0x2
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static Buttons.ConButton debugcamera_targetbind; // 0x8
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static Buttons.ConButton debugcamera_dollyforward; // 0x10
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static Buttons.ConButton debugcamera_dollyback; // 0x18
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static Buttons.ConButton debugcamera_cyclebone; // 0x20
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float debugcamera_dollyspeed; // 0x28
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static Buttons.ConButton debugcamera_raise; // 0x30
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static Buttons.ConButton debugcamera_lower; // 0x38
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static Buttons.ConButton debugcamera_zoomin; // 0x40
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static Buttons.ConButton debugcamera_zoomout; // 0x48
	[ClientVar] // RVA: 0x8E1F0 Offset: 0x8D5F0 VA: 0x18008E1F0
	public static Vector3 debugcamera_offset; // 0x50
	[ClientVar] // RVA: 0x93B80 Offset: 0x92F80 VA: 0x180093B80
	public static bool debugcamera_bonerotation; // 0x5C
	[ClientVar] // RVA: 0x93C10 Offset: 0x93010 VA: 0x180093C10
	public static bool debugcamera_lookat; // 0x5D
	[ClientVar] // RVA: 0x93D00 Offset: 0x93100 VA: 0x180093D00
	public static bool debugcamera_autosave; // 0x5E
	[ClientVar] // RVA: 0x93DE0 Offset: 0x931E0 VA: 0x180093DE0
	public static bool debugcamera_autoload; // 0x5F
	[ClientVar] // RVA: 0x93E50 Offset: 0x93250 VA: 0x180093E50
	public static bool debugcamera_preserve; // 0x60
	[ClientVar] // RVA: 0x93F60 Offset: 0x93360 VA: 0x180093F60
	public static bool debugcamera_lock; // 0x61
	[ClientVar] // RVA: 0x93FD0 Offset: 0x933D0 VA: 0x180093FD0
	public static bool drawcolliders; // 0x62
	[ClientVar] // RVA: 0x94070 Offset: 0x93470 VA: 0x180094070
	public static bool ambientvolumes; // 0x63
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool oninventorychanged; // 0x64
	[ClientVar] // RVA: 0x941F0 Offset: 0x935F0 VA: 0x1800941F0
	public static string fakeSpeechPlayer; // 0x68

	// Properties
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static bool log { get; set; }
	[ClientVar] // RVA: 0x95350 Offset: 0x94750 VA: 0x180095350
	public static bool skyreflection { get; set; }

	// Methods

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6D6430 Offset: 0x6D5830 VA: 0x1806D6430
	public static void renderinfo(ConsoleSystem.Arg arg) { }

	// RVA: 0x6D6440 Offset: 0x6D5840 VA: 0x1806D6440
	public static void set_log(bool value) { }

	// RVA: 0x6D5B30 Offset: 0x6D4F30 VA: 0x1806D5B30
	public static bool get_log() { }

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	// RVA: 0x6D6690 Offset: 0x6D5A90 VA: 0x1806D6690
	public static void stall(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94420 Offset: 0x93820 VA: 0x180094420
	// RVA: 0x6D5EE0 Offset: 0x6D52E0 VA: 0x1806D5EE0
	public static void lookingat(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x944E0 Offset: 0x938E0 VA: 0x1800944E0
	// RVA: 0x6D5C50 Offset: 0x6D5050 VA: 0x1806D5C50
	public static void lookingat_debug(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94650 Offset: 0x93A50 VA: 0x180094650
	// RVA: 0x6D4970 Offset: 0x6D3D70 VA: 0x1806D4970
	public static void debugcamera(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x946E0 Offset: 0x93AE0 VA: 0x1800946E0
	// RVA: 0x6D40B0 Offset: 0x6D34B0 VA: 0x1806D40B0
	public static string debugcamera_fov(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94770 Offset: 0x93B70 VA: 0x180094770
	// RVA: 0x6D51A0 Offset: 0x6D45A0 VA: 0x1806D51A0
	public static void debugcamera_target(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94800 Offset: 0x93C00 VA: 0x180094800
	// RVA: 0x6D45D0 Offset: 0x6D39D0 VA: 0x1806D45D0
	public static string debugcamera_guide(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x948C0 Offset: 0x93CC0 VA: 0x1800948C0
	// RVA: 0x6D43B0 Offset: 0x6D37B0 VA: 0x1806D43B0
	public static string debugcamera_guide_color(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x949C0 Offset: 0x93DC0 VA: 0x1800949C0
	// RVA: 0x6D4FC0 Offset: 0x6D43C0 VA: 0x1806D4FC0
	public static void debugcamera_shake(float amplitude, float frequency, float duration) { }

	[ClientVar] // RVA: 0x94A00 Offset: 0x93E00 VA: 0x180094A00
	// RVA: 0x6D50D0 Offset: 0x6D44D0 VA: 0x1806D50D0
	public static void debugcamera_stopshake() { }

	[ClientVar] // RVA: 0x94AB0 Offset: 0x93EB0 VA: 0x180094AB0
	// RVA: 0x6D4210 Offset: 0x6D3610 VA: 0x1806D4210
	public static string debugcamera_guide_aspectratio(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6D4D40 Offset: 0x6D4140 VA: 0x1806D4D40
	public static void debugcamera_save(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6D4820 Offset: 0x6D3C20 VA: 0x1806D4820
	public static void debugcamera_load(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6D4E70 Offset: 0x6D4270 VA: 0x1806D4E70
	public static void debugcamera_savetofile(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6D3FE0 Offset: 0x6D33E0 VA: 0x1806D3FE0
	public static void debugcamera_clear(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6D4730 Offset: 0x6D3B30 VA: 0x1806D4730
	public static void debugcamera_list(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6D53E0 Offset: 0x6D47E0 VA: 0x1806D53E0
	public static void debugcamera_targetprint(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x94F40 Offset: 0x94340 VA: 0x180094F40
	// RVA: 0x6D56C0 Offset: 0x6D4AC0 VA: 0x1806D56C0
	public static Debugging.EntityInfo[] ent_find_radius(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x95160 Offset: 0x94560 VA: 0x180095160
	// RVA: 0x6D6240 Offset: 0x6D5640 VA: 0x1806D6240
	public static void noclip(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x95220 Offset: 0x94620 VA: 0x180095220
	// RVA: 0x6D5580 Offset: 0x6D4980 VA: 0x1806D5580
	public static void debugcamera_unfreeze(ConsoleSystem.Arg arg) { }

	// RVA: 0x6D5BA0 Offset: 0x6D4FA0 VA: 0x1806D5BA0
	public static bool get_skyreflection() { }

	// RVA: 0x6D6520 Offset: 0x6D5920 VA: 0x1806D6520
	public static void set_skyreflection(bool value) { }

	// RVA: 0x6D3F80 Offset: 0x6D3380 VA: 0x1806D3F80
	public void .ctor() { }

	// RVA: 0x6D3C40 Offset: 0x6D3040 VA: 0x1806D3C40
	private static void .cctor() { }

}

public struct Debugging.EntityInfo // TypeDefIndex: 11897
{	// Fields
	public string name; // 0x0
	public uint netId; // 0x8

}

private sealed class Debugging.<>c__DisplayClass40_0 // TypeDefIndex: 11898
{	// Fields
	public Vector3 position; // 0x10
	public float radius; // 0x1C

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6E5CD0 Offset: 0x6E50D0 VA: 0x1806E5CD0
	internal bool <ent_find_radius>b__0(BaseNetworkable x) { }

}

private sealed class Debugging.<>c // TypeDefIndex: 11899
{	// Fields
	public static readonly Debugging.<>c <>9; // 0x0
	public static Func<BaseNetworkable, uint> <>9__40_1; // 0x8
	public static Func<IGrouping<uint, BaseNetworkable>, BaseNetworkable> <>9__40_2; // 0x10
	public static Func<BaseNetworkable, Debugging.EntityInfo> <>9__40_3; // 0x18

	// Methods

	// RVA: 0x6E5FB0 Offset: 0x6E53B0 VA: 0x1806E5FB0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6E5B70 Offset: 0x6E4F70 VA: 0x1806E5B70
	internal uint <ent_find_radius>b__40_1(BaseNetworkable x) { }

	// RVA: 0x6E5B90 Offset: 0x6E4F90 VA: 0x1806E5B90
	internal BaseNetworkable <ent_find_radius>b__40_2(IGrouping<uint, BaseNetworkable> x) { }

	// RVA: 0x6E5BD0 Offset: 0x6E4FD0 VA: 0x1806E5BD0
	internal Debugging.EntityInfo <ent_find_radius>b__40_3(BaseNetworkable x) { }

}

