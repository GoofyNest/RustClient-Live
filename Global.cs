public static class Global // TypeDefIndex: 6627
{
	public static Func<string, GameObject> LoadPrefab; 
	public static Func<string, GameObject> FindPrefab; 
	public static Func<string, GameObject> CreatePrefab; 
	public static Action OpenMainMenu; 
	private static FacepunchBehaviour _runner; 
	[CompilerGeneratedAttribute] 
	private static int <LaunchCountThisVersion>k__BackingField; 

	public static FacepunchBehaviour Runner { get; }
	public static int LaunchCountThisVersion { get; set; }


	public static FacepunchBehaviour get_Runner() { }

	[CompilerGeneratedAttribute] 
	public static int get_LaunchCountThisVersion() { }

	[CompilerGeneratedAttribute] 
	private static void set_LaunchCountThisVersion(int value) { }

	public static void Init() { }

}

public class Global : ConsoleSystem // TypeDefIndex: 13676
{
	private static int _developer; 
	[ServerVar] 
	[ClientVar] 
	public static bool skipassetwarmup; 
	[ServerVar] 
	[ClientVar] 
	public static int maxthreads; 
	private const int DefaultWarmupConcurrency = 1;
	private const int DefaultPreloadConcurrency = 1;
	[ServerVar] 
	[ClientVar] 
	public static int warmupConcurrency; 
	[ServerVar] 
	[ClientVar] 
	public static int preloadConcurrency; 
	[ServerVar] 
	[ClientVar] 
	public static bool forceUnloadBundles; 
	private const bool DefaultAsyncWarmupEnabled = False;
	[ServerVar] 
	[ClientVar] 
	public static bool asyncWarmup; 
	[ClientVar] 
	public static int asyncLoadingPreset; 
	private static int _censornudity; 
	private static bool _censorsigns; 
	[ClientVar] 
	public static int signUndoBuffer; 
	private static bool _censorRecordings; 
	private static bool _processMidiInput; 
	private static bool _showBlood; 
	[ClientVar] 
	public static bool limitFlashing; 
	[ClientVar] 
	public static bool showItemCountsOnPickup; 
	[ClientVar] 
	public static bool useSingleItemPickupNotice; 
	[ClientVar] 
	public static bool showItemPickupNotices; 
	[ClientVar] 
	public static float vehicleDismountHoldTime; 
	[ClientVar] 
	public static bool hideInteractTextWhileADS; 
	[ServerVar] 
	[ClientVar] 
	public static int perf; 
	[ClientVar] 
	public static bool god; 
	[ClientVar] 
	public static bool specnet; 
	[ClientVar] 
	public static bool streamermode; 
	[ClientVar] 
	public static bool richPresence; 
	private static float _consoleScale; 

	[ServerVar] 
	[ClientVar] 
	public static int developer { get; set; }
	[ClientVar] 
	public static int censornudity { get; set; }
	[ClientVar] 
	public static bool censorsigns { get; set; }
	[ClientVar] 
	public static bool censorrecordings { get; set; }
	[ClientVar] 
	public static bool processMidiInput { get; set; }
	[ClientVar] 
	public static bool showBlood { get; set; }
	[ClientVar] 
	public static string language { get; set; }
	[ClientVar] 
	public static float consoleScale { get; set; }


	public static void set_developer(int value) { }

	public static int get_developer() { }

	public static void ApplyAsyncLoadingPreset() { }

	public static int get_censornudity() { }

	public static void set_censornudity(int value) { }

	private static bool ForceUnderwear() { }

	public static bool get_censorsigns() { }

	public static void set_censorsigns(bool value) { }

	public static bool get_censorrecordings() { }

	public static void set_censorrecordings(bool value) { }

	public static bool get_processMidiInput() { }

	public static void set_processMidiInput(bool value) { }

	public static bool get_showBlood() { }

	public static void set_showBlood(bool value) { }

	[ServerVar] 
	public static void restart(ConsoleSystem.Arg args) { }

	[ClientVar] 
	[ServerVar] 
	public static void quit(ConsoleSystem.Arg args) { }

	[ClientVar] 
	public static void writecfg() { }

	[ClientVar] 
	public static void readcfg(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void exec(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void report(ConsoleSystem.Arg args) { }

	[ServerVar] 
	[ClientVar] 
	public static void objects(ConsoleSystem.Arg args) { }

	[ServerVar] 
	[ClientVar] 
	public static void textures(ConsoleSystem.Arg args) { }

	[ServerVar] 
	[ClientVar] 
	public static void colliders(ConsoleSystem.Arg args) { }

	[ServerVar] 
	[ClientVar] 
	public static void error(ConsoleSystem.Arg args) { }

	[ServerVar] 
	[ClientVar] 
	public static void queue(ConsoleSystem.Arg args) { }

	[ClientVar] 
	public static void status_cl(ConsoleSystem.Arg args) { }

	[ServerVar] 
	public static void teleport(ConsoleSystem.Arg args) { }

	[ServerVar] 
	public static void teleport2me(ConsoleSystem.Arg args) { }

	[ServerVar] 
	public static void teleportany(ConsoleSystem.Arg args) { }

	[ServerVar] 
	public static void teleportpos(ConsoleSystem.Arg args) { }

	[ServerVar] 
	public static void teleportlos(ConsoleSystem.Arg args) { }

	[ServerVar] 
	public static void teleport2owneditem(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void teleport2autheditem(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void teleport2marker(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void teleport2death(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	[ClientVar] 
	public static void free(ConsoleSystem.Arg args) { }

	public static string get_language() { }

	public static void set_language(string value) { }

	public static float get_consoleScale() { }

	public static void set_consoleScale(float value) { }

	[ServerVar] 
	[ClientVar] 
	public static void version(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	[ClientVar] 
	public static void sysinfo(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	[ClientVar] 
	public static void sysuid(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void breakitem(ConsoleSystem.Arg args) { }

	[ServerVar] 
	public static void breakclothing(ConsoleSystem.Arg args) { }

	[ServerVar] 
	[ClientVar] 
	public static void subscriptions(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Global.<>c // TypeDefIndex: 13677
{
	public static readonly Global.<>c <>9; 
	public static Func<KeyValuePair<Type, long>, long> <>9__49_0; 
	public static Func<Collider, bool> <>9__51_0; 
	public static Func<Collider, bool> <>9__51_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal long <objects>b__49_0(KeyValuePair<Type, long> x) { }

	internal bool <colliders>b__51_0(Collider x) { }

	internal bool <colliders>b__51_1(Collider x) { }

}

