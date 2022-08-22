internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 3263
{
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 3260

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 // TypeDefIndex: 3261

internal class <Module> // TypeDefIndex: 3262

[VisibleToOtherModulesAttribute] // RVA: 0xD9FC0 Offset: 0xD93C0 VA: 0x1800D9FC0
[AttributeUsageAttribute] // RVA: 0xD9FC0 Offset: 0xD93C0 VA: 0x1800D9FC0
internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 3263
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private readonly string <preferredExtension>k__BackingField; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private readonly IEnumerable<string> <otherExtensions>k__BackingField; // 0x18


	public void .ctor(string preferredExtension, string[] otherExtensions) { }

}

public class AssetBundle : Object // TypeDefIndex: 3992
{
[NativeHeaderAttribute] // RVA: 0xAB910 Offset: 0xAAD10 VA: 0x1800AB910
[NativeHeaderAttribute] // RVA: 0xAB910 Offset: 0xAAD10 VA: 0x1800AB910
[NativeHeaderAttribute] // RVA: 0xAB910 Offset: 0xAAD10 VA: 0x1800AB910
[NativeHeaderAttribute] // RVA: 0xAB910 Offset: 0xAAD10 VA: 0x1800AB910
[NativeHeaderAttribute] // RVA: 0xAB910 Offset: 0xAAD10 VA: 0x1800AB910
[NativeHeaderAttribute] // RVA: 0xAB910 Offset: 0xAAD10 VA: 0x1800AB910
[NativeHeaderAttribute] // RVA: 0xAB910 Offset: 0xAAD10 VA: 0x1800AB910
[NativeHeaderAttribute] // RVA: 0xAB910 Offset: 0xAAD10 VA: 0x1800AB910
[NativeHeaderAttribute] // RVA: 0xAB910 Offset: 0xAAD10 VA: 0x1800AB910
[ExcludeFromPresetAttribute] // RVA: 0xAB910 Offset: 0xAAD10 VA: 0x1800AB910
[NativeHeaderAttribute] // RVA: 0xAB910 Offset: 0xAAD10 VA: 0x1800AB910
[NativeHeaderAttribute] // RVA: 0xAB910 Offset: 0xAAD10 VA: 0x1800AB910
public class AssetBundle : Object // TypeDefIndex: 3992

	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xABED0 Offset: 0xAB2D0 VA: 0x1800ABED0
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	[FreeFunctionAttribute] // RVA: 0xABF50 Offset: 0xAB350 VA: 0x1800ABF50
	internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) { }

	public static AssetBundle LoadFromFile(string path) { }

	[NativeMethodAttribute] // RVA: 0xAC060 Offset: 0xAB460 VA: 0x1800AC060
	public bool Contains(string name) { }

	public T LoadAsset<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A3DC0 Offset: 0x14A31C0 VA: 0x1814A3DC0
	|-AssetBundle.LoadAsset<WorkshopSkinBase>
	|-AssetBundle.LoadAsset<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xAC110 Offset: 0xAB510 VA: 0x1800AC110
	public Object LoadAsset(string name, Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC1D0 Offset: 0xAB5D0 VA: 0x1800AC1D0
	[TypeInferenceRuleAttribute] // RVA: 0xAC1D0 Offset: 0xAB5D0 VA: 0x1800AC1D0
	[NativeMethodAttribute] // RVA: 0xAC1D0 Offset: 0xAB5D0 VA: 0x1800AC1D0
	private Object LoadAsset_Internal(string name, Type type) { }

	public AssetBundleRequest LoadAssetAsync(string name) { }

	public AssetBundleRequest LoadAssetAsync<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9E050 Offset: 0x1A9D450 VA: 0x181A9E050
	|-AssetBundle.LoadAssetAsync<object>
	|-AssetBundle.LoadAssetAsync<Sprite>
	|-AssetBundle.LoadAssetAsync<TextAsset>
	|-AssetBundle.LoadAssetAsync<Texture2D>
	*/

	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9DE80 Offset: 0x1A9D280 VA: 0x181A9DE80
	|-AssetBundle.ConvertObjects<object>
	*/

	public T[] LoadAllAssets<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9DFB0 Offset: 0x1A9D3B0 VA: 0x181A9DFB0
	|-AssetBundle.LoadAllAssets<AssetBundleManifest>
	|-AssetBundle.LoadAllAssets<object>
	*/

	public Object[] LoadAllAssets(Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC3B0 Offset: 0xAB7B0 VA: 0x1800AC3B0
	[NativeMethodAttribute] // RVA: 0xAC3B0 Offset: 0xAB7B0 VA: 0x1800AC3B0
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeMethodAttribute] // RVA: 0xAC610 Offset: 0xABA10 VA: 0x1800AC610
	public void Unload(bool unloadAllLoadedObjects) { }

	[NativeMethodAttribute] // RVA: 0xAC6D0 Offset: 0xABAD0 VA: 0x1800AC6D0
	public string[] GetAllAssetNames() { }

	[NativeThrowsAttribute] // RVA: 0xAC880 Offset: 0xABC80 VA: 0x1800AC880
	[NativeMethodAttribute] // RVA: 0xAC880 Offset: 0xABC80 VA: 0x1800AC880
	internal Object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

}

public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 3993
{	public AssetBundle assetBundle { get; }


	[NativeMethodAttribute] // RVA: 0xACAF0 Offset: 0xABEF0 VA: 0x1800ACAF0
	public AssetBundle get_assetBundle() { }

	public void .ctor() { }

}

public class AssetBundleManifest : Object // TypeDefIndex: 3994
{
	[NativeMethodAttribute] // RVA: 0xACCD0 Offset: 0xAC0D0 VA: 0x1800ACCD0
	public string[] GetAllAssetBundles() { }

}

public class AssetBundleRequest : AsyncOperation // TypeDefIndex: 3996
{
[NativeHeaderAttribute] // RVA: 0xACF80 Offset: 0xAC380 VA: 0x1800ACF80
[RequiredByNativeCodeAttribute] // RVA: 0xACF80 Offset: 0xAC380 VA: 0x1800ACF80
public class AssetBundleRequest : AsyncOperation // TypeDefIndex: 3996
	public Object asset { get; }


	[NativeMethodAttribute] // RVA: 0xAE380 Offset: 0xAD780 VA: 0x1800AE380
	public Object get_asset() { }

	public void .ctor() { }

}

public static class AssetPool // TypeDefIndex: 6562
{	public static Dictionary<Type, AssetPool.Pool> storage; // 0x2A80


	public static T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E37C0 Offset: 0x5E2BC0 VA: 0x1805E37C0
	|-AssetPool.Get<Mesh>
	|-AssetPool.Get<object>
	*/

	public static void Free(ref Mesh mesh) { }

	private static AssetPool.Pool GetPool<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257000 Offset: 0x1256400 VA: 0x181257000
	|-AssetPool.GetPool<object>
	|-AssetPool.GetPool<Mesh>
	*/

	public static void Clear() { }

	private static void .cctor() { }

}

public class AssetPool.Pool // TypeDefIndex: 6563
{	public Stack<Object> stack; // 0x10
	public int allocated; // 0x18
	public int available; // 0x1C
	public string name; // 0x20


	public void .ctor(string name) { }

	public T Pop<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5ED140 Offset: 0x5EC540 VA: 0x1805ED140
	|-AssetPool.Pool.Pop<object>
	*/

	public void Push<T>(ref T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1548100 Offset: 0x1547500 VA: 0x181548100
	|-AssetPool.Pool.Push<object>
	|-AssetPool.Pool.Push<Mesh>
	*/

	public void Clear() { }

}

public class AssetBundleBackend : FileSystemBackend, IDisposable // TypeDefIndex: 6651
{
public class AssetBundleBackend : FileSystemBackend, IDisposable // TypeDefIndex: 6651
	private AssetBundle rootBundle; // 0x28
	private AssetBundleManifest manifest; // 0x30
	private Dictionary<string, AssetBundle> bundles; // 0x38
	private Dictionary<string, AssetBundle> files; // 0x40
	private string assetPath; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <LoadProgress>k__BackingField; // 0x50

	public static bool Enabled { get; }
	public float LoadProgress { get; set; }


	public static bool get_Enabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_LoadProgress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_LoadProgress(float value) { }

	public void Load(string assetRoot) { }

	private AssetBundle LoadBundle(string bundleName) { }

	public void BuildFileIndex() { }

	public void Dispose() { }

	public override List<string> UnloadBundles(string partialName) { }

	protected override T LoadAsset<T>(string filePath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E3720 Offset: 0x5E2B20 VA: 0x1805E3720
	|-AssetBundleBackend.LoadAsset<object>
	*/

	protected override LoadAssetsResult LoadAssetsAsync(List<string> filePaths, int maxConcurrency, int priority) { }

	protected override string[] LoadAssetList(string folder, string search) { }

	public override T[] LoadAllFromBundle<T>(string bundleName, string editorSearch) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A3B30 Offset: 0x14A2F30 VA: 0x1814A3B30
	|-AssetBundleBackend.LoadAllFromBundle<object>
	*/

	public void .ctor() { }

}

private sealed class AssetBundleBackend.<>c__DisplayClass17_0 // TypeDefIndex: 6652
{	public AssetBundleBackend <>4__this; // 0x10
	public int maxConcurrency; // 0x18
	public int priority; // 0x1C


	public void .ctor() { }

	internal bool <LoadAssetsAsync>b__0(string p) { }

	internal AssetBundle <LoadAssetsAsync>b__1(string p) { }

	internal LoadAssetsResult <LoadAssetsAsync>b__2(IGrouping<AssetBundle, string> g) { }

}

private sealed class AssetBundleBackend.<>c // TypeDefIndex: 6653
{	public static readonly AssetBundleBackend.<>c <>9; // 0x0
	public static Func<string, string> <>9__17_3; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal string <LoadAssetsAsync>b__17_3(string p) { }

}

private sealed class AssetBundleBackend.<>c__DisplayClass18_0 // TypeDefIndex: 6654
{	public string folder; // 0x10
	public Func<KeyValuePair<string, AssetBundle>, bool> <>9__0; // 0x18


	public void .ctor() { }

	internal bool <LoadAssetList>b__0(KeyValuePair<string, AssetBundle> x) { }

}

internal class AssetBundleLoadAssetsResult : LoadAssetsResult // TypeDefIndex: 6655
{	private readonly AssetBundle _bundle; // 0x20
	private readonly List<string> _filePaths; // 0x28
	private readonly int _maxConcurrency; // 0x30
	private readonly int _priority; // 0x34
	private readonly List<AssetBundleRequest> _requests; // 0x38
	[TupleElementNamesAttribute] // RVA: 0xC0680 Offset: 0xBFA80 VA: 0x1800C0680
	private readonly List<ValueTuple<string, AssetBundleRequest>> _pendingRequests; // 0x40
	private int _index; // 0x48

	public override int TotalCount { get; }
	public override bool keepWaiting { get; }


	public override int get_TotalCount() { }

	internal void .ctor(AssetBundle bundle, List<string> filePaths, int maxConcurrency, int priority) { }

	public override bool get_keepWaiting() { }

	private bool Update() { }

	public override Dictionary<string, Object> GetResult() { }

}

public class AssetPreloadResult : CustomYieldInstruction // TypeDefIndex: 6656
{	private readonly FileSystemBackend _backend; // 0x10
	private readonly LoadAssetsResult _load; // 0x18
	private readonly List<ValueTuple<string, Object>> _loaded; // 0x20
	private readonly int _alreadyLoadedCount; // 0x28

	public int TotalCount { get; }
	public int CompletedCount { get; }
	[TupleElementNamesAttribute] // RVA: 0xC0AF0 Offset: 0xBFEF0 VA: 0x1800C0AF0
	public IReadOnlyList<ValueTuple<string, Object>> Results { get; }
	public override bool keepWaiting { get; }


	internal void .ctor(FileSystemBackend backend, LoadAssetsResult load, List<ValueTuple<string, Object>> loaded) { }

	public int get_TotalCount() { }

	public int get_CompletedCount() { }

	public IReadOnlyList<ValueTuple<string, Object>> get_Results() { }

	public override bool get_keepWaiting() { }

	private void OnAssetLoaded(string path, Object obj) { }

}

public static class AssetNameCache // TypeDefIndex: 10715
{	private static Dictionary<Object, string> mixed; // 0x0
	private static Dictionary<Object, string> lower; // 0x8
	private static Dictionary<Object, string> upper; // 0x10


	private static string LookupName(Object obj) { }

	private static string LookupNameLower(Object obj) { }

	private static string LookupNameUpper(Object obj) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static string GetName(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static string GetNameLower(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static string GetNameUpper(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static string GetName(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static string GetNameLower(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static string GetNameUpper(Material mat) { }

	private static void .cctor() { }

}

public static class AssetStorage // TypeDefIndex: 11362
{
	public static void Save<T>(ref T asset, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1537240 Offset: 0x1536640 VA: 0x181537240
	|-AssetStorage.Save<object>
	*/

	public static void Save(ref Texture2D asset) { }

	public static void Save(ref Texture2D asset, string path, bool linear, bool compress) { }

	public static void Load<T>(ref T asset, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	|-AssetStorage.Load<object>
	*/

	public static void Delete<T>(ref T asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15371A0 Offset: 0x15365A0 VA: 0x1815371A0
	|-AssetStorage.Delete<object>
	*/

}

