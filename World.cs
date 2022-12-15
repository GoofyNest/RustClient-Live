public static class World // TypeDefIndex: 12084
{
	[CompilerGeneratedAttribute]
	private static uint <Seed>k__BackingField;
	[CompilerGeneratedAttribute]
	private static uint <Size>k__BackingField;
	[CompilerGeneratedAttribute]
	private static string <Checksum>k__BackingField;
	[CompilerGeneratedAttribute]
	private static string <Url>k__BackingField;
	[CompilerGeneratedAttribute]
	private static bool <Procedural>k__BackingField;
	[CompilerGeneratedAttribute]
	private static bool <Cached>k__BackingField;
	[CompilerGeneratedAttribute]
	private static bool <Networked>k__BackingField;
	[CompilerGeneratedAttribute]
	private static bool <Receiving>k__BackingField;
	[CompilerGeneratedAttribute]
	private static bool <Transfer>k__BackingField;
	[CompilerGeneratedAttribute]
	private static bool <LoadedFromSave>k__BackingField;
	[CompilerGeneratedAttribute]
	private static int <SpawnIndex>k__BackingField;
	[CompilerGeneratedAttribute]
	private static WorldSerialization <Serialization>k__BackingField;

	public static uint Seed { get; set; }
	public static uint Size { get; set; }
	public static string Checksum { get; set; }
	public static string Url { get; set; }
	public static bool Procedural { get; set; }
	public static bool Cached { get; set; }
	public static bool Networked { get; set; }
	public static bool Receiving { get; set; }
	public static bool Transfer { get; set; }
	public static bool LoadedFromSave { get; set; }
	public static int SpawnIndex { get; set; }
	public static WorldSerialization Serialization { get; set; }
	public static string Name { get; }
	public static string MapFileName { get; }
	public static string MapFolderName { get; }


	[CompilerGeneratedAttribute]
	public static uint get_Seed() { }

	[CompilerGeneratedAttribute]
	public static void set_Seed(uint value) { }

	[CompilerGeneratedAttribute]
	public static uint get_Size() { }

	[CompilerGeneratedAttribute]
	public static void set_Size(uint value) { }

	[CompilerGeneratedAttribute]
	public static string get_Checksum() { }

	[CompilerGeneratedAttribute]
	public static void set_Checksum(string value) { }

	[CompilerGeneratedAttribute]
	public static string get_Url() { }

	[CompilerGeneratedAttribute]
	public static void set_Url(string value) { }

	[CompilerGeneratedAttribute]
	public static bool get_Procedural() { }

	[CompilerGeneratedAttribute]
	public static void set_Procedural(bool value) { }

	[CompilerGeneratedAttribute]
	public static bool get_Cached() { }

	[CompilerGeneratedAttribute]
	public static void set_Cached(bool value) { }

	[CompilerGeneratedAttribute]
	public static bool get_Networked() { }

	[CompilerGeneratedAttribute]
	public static void set_Networked(bool value) { }

	[CompilerGeneratedAttribute]
	public static bool get_Receiving() { }

	[CompilerGeneratedAttribute]
	public static void set_Receiving(bool value) { }

	[CompilerGeneratedAttribute]
	public static bool get_Transfer() { }

	[CompilerGeneratedAttribute]
	public static void set_Transfer(bool value) { }

	[CompilerGeneratedAttribute]
	public static bool get_LoadedFromSave() { }

	[CompilerGeneratedAttribute]
	public static void set_LoadedFromSave(bool value) { }

	[CompilerGeneratedAttribute]
	public static int get_SpawnIndex() { }

	[CompilerGeneratedAttribute]
	public static void set_SpawnIndex(int value) { }

	[CompilerGeneratedAttribute]
	public static WorldSerialization get_Serialization() { }

	[CompilerGeneratedAttribute]
	public static void set_Serialization(WorldSerialization value) { }

	public static string get_Name() { }

	public static string GetServerBrowserMapName() { }

	public static bool CanLoadFromUrl() { }

	public static bool CanLoadFromDisk() { }

	public static void CleanupOldFiles() { }

	public static string get_MapFileName() { }

	public static string get_MapFolderName() { }

	public static byte[] GetMap(string name) { }

	public static int GetCachedHeightMapResolution() { }

	public static int GetCachedSplatMapResolution() { }

	public static void AddMap(string name, byte[] data) { }

	public static void AddPrefab(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	public static PathData PathListToPathData(PathList src) { }

	public static PathList PathDataToPathList(PathData src) { }

	public static Vector3[] VectorListToArray(List<VectorData> src) { }

	public static List<VectorData> VectorArrayToList(Vector3[] src) { }

	public static IEnumerable<PathList> GetPaths(string name) { }

	public static void AddPaths(IEnumerable<PathList> paths) { }

	public static void AddPath(PathList path) { }

	[IteratorStateMachineAttribute]
	public static IEnumerator SpawnAsync(float deltaTime, Action<string> statusFunction) { }

	[IteratorStateMachineAttribute]
	public static IEnumerator Spawn(float deltaTime, Action<string> statusFunction) { }

	public static void Spawn() { }

	public static void Spawn(string category, string folder) { }

	public static void Spawn(string category, string[] folders) { }

	private static void Spawn(PrefabData prefab) { }

	private static void Spawn(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	private static void Status(Action<string> statusFunction, string status, object obj1) { }

	private static void Status(Action<string> statusFunction, string status, object obj1, object obj2) { }

	private static void Status(Action<string> statusFunction, string status, object obj1, object obj2, object obj3) { }

	private static void Status(Action<string> statusFunction, string status, object[] objs) { }

}

private sealed class World.<>c__DisplayClass53_0 // TypeDefIndex: 12085
{
	public Regex regex1;
	public Regex regex2;


	public void .ctor() { }

	internal bool <CleanupOldFiles>

}

private sealed class World.<>c // TypeDefIndex: 12086
{
	public static readonly World.<>c <>9;
	public static Func<PathData, PathList> <>9__67_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal PathList <GetPaths>

}

private sealed class World.<SpawnAsync>d__70 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12087
{
	private int <>1__state;
	private object <>2__current;
	public float deltaTime;
	public Action<string> statusFunction;
	private int <totalCount>5__2;
	private Dictionary<string, List<PrefabData>> <assetGroups>5__3;
	private int <spawnedCount>5__4;
	private int <resultIndex>5__5;
	private Stopwatch <sw>5__6;
	private AssetPreloadResult <load>5__7;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class World.<Spawn>d__71 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12088
{
	private int <>1__state;
	private object <>2__current;
	public float deltaTime;
	public Action<string> statusFunction;
	private Stopwatch <sw>5__2;
	private int <i>5__3;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

public class World : ConsoleSystem // TypeDefIndex: 13794
{
	[ServerVar]
	[ClientVar]
	public static bool cache;
	[ClientVar]
	public static bool streaming;


	[ClientVar]
	[ServerVar]
	public static void monuments(ConsoleSystem.Arg arg) { }

	[ServerVar]
	public static void rendermap(ConsoleSystem.Arg arg) { }

	[ServerVar]
	public static void rendertunnels(ConsoleSystem.Arg arg) { }

	[ServerVar]
	public static void renderlabs(ConsoleSystem.Arg arg) { }

	private static void RenderMapLayerToFile(ConsoleSystem.Arg arg, string name, MapLayer layer) { }

	public void .ctor() { }

	private static void .cctor() { }

}

