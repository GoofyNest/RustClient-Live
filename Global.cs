public static class Global // TypeDefIndex: 6621
{	// Fields
	public static Func<string, GameObject> LoadPrefab; // 0x0
	public static Func<string, GameObject> FindPrefab; // 0x8
	public static Func<string, GameObject> CreatePrefab; // 0x10
	public static Action OpenMainMenu; // 0x18
	private static MonoBehaviour _runner; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static int <LaunchCountThisVersion>k__BackingField; // 0x28

	// Properties
	public static MonoBehaviour Runner { get; }
	public static int LaunchCountThisVersion { get; set; }

	// Methods

	// RVA: 0x1B9DC70 Offset: 0x1B9D070 VA: 0x181B9DC70
	public static MonoBehaviour get_Runner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1B9DC30 Offset: 0x1B9D030 VA: 0x181B9DC30
	public static int get_LaunchCountThisVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1B9DD70 Offset: 0x1B9D170 VA: 0x181B9DD70
	private static void set_LaunchCountThisVersion(int value) { }

	// RVA: 0x1B9DB30 Offset: 0x1B9CF30 VA: 0x181B9DB30
	public static void Init() { }

}

public class Global : ConsoleSystem // TypeDefIndex: 11922
{	// Fields
	private static int _developer; // 0x0
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static bool skipassetwarmup; // 0x4
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static int maxthreads; // 0x8
	private const int DefaultWarmupConcurrency = 1;
	private const int DefaultPreloadConcurrency = 1;
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static int warmupConcurrency; // 0xC
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static int preloadConcurrency; // 0x10
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static bool forceUnloadBundles; // 0x14
	private const bool DefaultAsyncWarmupEnabled = False;
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static bool asyncWarmup; // 0x15
	private static int _censornudity; // 0x18
	private static bool _censorsigns; // 0x1C
	[ClientVar] // RVA: 0x9DA70 Offset: 0x9CE70 VA: 0x18009DA70
	public static int signUndoBuffer; // 0x20
	private static bool _censorRecordings; // 0x24
	private static bool _processMidiInput; // 0x25
	private static bool _showBlood; // 0x26
	[ClientVar] // RVA: 0x9DB00 Offset: 0x9CF00 VA: 0x18009DB00
	public static bool limitFlashing; // 0x27
	[ClientVar] // RVA: 0x9DBC0 Offset: 0x9CFC0 VA: 0x18009DBC0
	public static bool showItemCountsOnPickup; // 0x28
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static bool showItemPickupNotices; // 0x29
	[ClientVar] // RVA: 0x9DD80 Offset: 0x9D180 VA: 0x18009DD80
	public static float vehicleDismountHoldTime; // 0x2C
	[ServerVar] // RVA: 0x9DE00 Offset: 0x9D200 VA: 0x18009DE00
	[ClientVar] // RVA: 0x9DE00 Offset: 0x9D200 VA: 0x18009DE00
	public static int perf; // 0x30
	[ClientVar] // RVA: 0x9DF80 Offset: 0x9D380 VA: 0x18009DF80
	public static bool god; // 0x34
	[ClientVar] // RVA: 0x9E040 Offset: 0x9D440 VA: 0x18009E040
	public static bool specnet; // 0x35
	[ClientVar] // RVA: 0x8EA50 Offset: 0x8DE50 VA: 0x18008EA50
	public static bool streamermode; // 0x36
	[ClientVar] // RVA: 0x8EA50 Offset: 0x8DE50 VA: 0x18008EA50
	public static bool richPresence; // 0x37

	// Properties
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static int developer { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int censornudity { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool censorsigns { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool censorrecordings { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool processMidiInput { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool showBlood { get; set; }
	[ClientVar] // RVA: 0x8EA50 Offset: 0x8DE50 VA: 0x18008EA50
	public static string language { get; set; }

	// Methods

	// RVA: 0x6E0340 Offset: 0x6DF740 VA: 0x1806E0340
	public static void set_developer(int value) { }

	// RVA: 0x6DF1E0 Offset: 0x6DE5E0 VA: 0x1806DF1E0
	public static int get_developer() { }

	// RVA: 0x6DF090 Offset: 0x6DE490 VA: 0x1806DF090
	public static int get_censornudity() { }

	// RVA: 0x6DFF50 Offset: 0x6DF350 VA: 0x1806DFF50
	public static void set_censornudity(int value) { }

	// RVA: 0x6DE570 Offset: 0x6DD970 VA: 0x1806DE570
	private static bool ForceUnderwear() { }

	// RVA: 0x6DF180 Offset: 0x6DE580 VA: 0x1806DF180
	public static bool get_censorsigns() { }

	// RVA: 0x6E0250 Offset: 0x6DF650 VA: 0x1806E0250
	public static void set_censorsigns(bool value) { }

	// RVA: 0x6DF120 Offset: 0x6DE520 VA: 0x1806DF120
	public static bool get_censorrecordings() { }

	// RVA: 0x6E0030 Offset: 0x6DF430 VA: 0x1806E0030
	public static void set_censorrecordings(bool value) { }

	// RVA: 0x6DF420 Offset: 0x6DE820 VA: 0x1806DF420
	public static bool get_processMidiInput() { }

	// RVA: 0x6E04D0 Offset: 0x6DF8D0 VA: 0x1806E04D0
	public static void set_processMidiInput(bool value) { }

	// RVA: 0x6DF480 Offset: 0x6DE880 VA: 0x1806DF480
	public static bool get_showBlood() { }

	// RVA: 0x6E05C0 Offset: 0x6DF9C0 VA: 0x1806E05C0
	public static void set_showBlood(bool value) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void restart(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	// RVA: 0x6DFD40 Offset: 0x6DF140 VA: 0x1806DFD40
	public static void quit(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6E10C0 Offset: 0x6E04C0 VA: 0x1806E10C0
	public static void writecfg() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6DFE20 Offset: 0x6DF220 VA: 0x1806DFE20
	public static void readcfg(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6DEDB0 Offset: 0x6DE1B0 VA: 0x1806DEDB0
	public static void exec(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void report(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DF4E0 Offset: 0x6DE8E0 VA: 0x1806DF4E0
	public static void objects(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6E0AB0 Offset: 0x6DFEB0 VA: 0x1806E0AB0
	public static void textures(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DE960 Offset: 0x6DDD60 VA: 0x1806DE960
	public static void colliders(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DED80 Offset: 0x6DE180 VA: 0x1806DED80
	public static void error(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DFCF0 Offset: 0x6DF0F0 VA: 0x1806DFCF0
	public static void queue(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6E0620 Offset: 0x6DFA20 VA: 0x1806E0620
	public static void status_cl(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void teleport(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void teleport2me(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void teleportany(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void teleportpos(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void teleportlos(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void teleport2owneditem(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void teleport2autheditem(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void teleport2marker(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void teleport2death(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6DEF20 Offset: 0x6DE320 VA: 0x1806DEF20
	public static void free(ConsoleSystem.Arg args) { }

	// RVA: 0x6DF380 Offset: 0x6DE780 VA: 0x1806DF380
	public static string get_language() { }

	// RVA: 0x6E03A0 Offset: 0x6DF7A0 VA: 0x1806E03A0
	public static void set_language(string value) { }

	[ServerVar] // RVA: 0x9F190 Offset: 0x9E590 VA: 0x18009F190
	[ClientVar] // RVA: 0x9F190 Offset: 0x9E590 VA: 0x18009F190
	// RVA: 0x6E0E00 Offset: 0x6E0200 VA: 0x1806E0E00
	public static void version(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6E0A50 Offset: 0x6DFE50 VA: 0x1806E0A50
	public static void sysinfo(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6E0A80 Offset: 0x6DFE80 VA: 0x1806E0A80
	public static void sysuid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void breakitem(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void breakclothing(ConsoleSystem.Arg args) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6E06F0 Offset: 0x6DFAF0 VA: 0x1806E06F0
	public static void subscriptions(ConsoleSystem.Arg arg) { }

	// RVA: 0x6DE900 Offset: 0x6DDD00 VA: 0x1806DE900
	public void .ctor() { }

	// RVA: 0x6DE750 Offset: 0x6DDB50 VA: 0x1806DE750
	private static void .cctor() { }

}

private sealed class Global.<>c // TypeDefIndex: 11923
{	// Fields
	public static readonly Global.<>c <>9; // 0x0
	public static Func<KeyValuePair<Type, long>, long> <>9__45_0; // 0x8
	public static Func<Collider, bool> <>9__47_0; // 0x10
	public static Func<Collider, bool> <>9__47_1; // 0x18

	// Methods

	// RVA: 0x6E6070 Offset: 0x6E5470 VA: 0x1806E6070
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6E5C30 Offset: 0x6E5030 VA: 0x1806E5C30
	internal long <objects>b__45_0(KeyValuePair<Type, long> x) { }

	// RVA: 0x6E5B20 Offset: 0x6E4F20 VA: 0x1806E5B20
	internal bool <colliders>b__47_0(Collider x) { }

	// RVA: 0x6E5B40 Offset: 0x6E4F40 VA: 0x1806E5B40
	internal bool <colliders>b__47_1(Collider x) { }

}

