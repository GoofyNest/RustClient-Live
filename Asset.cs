internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 3263
{
// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 3260

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 // TypeDefIndex: 3261

// Namespace: 
internal class <Module> // TypeDefIndex: 3262

// Namespace: UnityEngine
[VisibleToOtherModulesAttribute] // RVA: 0xD9FC0 Offset: 0xD93C0 VA: 0x1800D9FC0
[AttributeUsageAttribute] // RVA: 0xD9FC0 Offset: 0xD93C0 VA: 0x1800D9FC0
internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 3263
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private readonly string <preferredExtension>k__BackingField; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private readonly IEnumerable<string> <otherExtensions>k__BackingField; // 0x18

	// Methods

	// RVA: 0x805420 Offset: 0x804820 VA: 0x180805420
	public void .ctor(string preferredExtension, string[] otherExtensions) { }

}

public class AssetBundle : Object // TypeDefIndex: 3992
{
// Namespace: UnityEngine
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
	// Methods

	// RVA: 0x231AAE0 Offset: 0x2319EE0 VA: 0x18231AAE0
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xABED0 Offset: 0xAB2D0 VA: 0x1800ABED0
	// RVA: 0x231A970 Offset: 0x2319D70 VA: 0x18231A970
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x231A9C0 Offset: 0x2319DC0 VA: 0x18231A9C0
	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	[FreeFunctionAttribute] // RVA: 0xABF50 Offset: 0xAB350 VA: 0x1800ABF50
	// RVA: 0x231AA00 Offset: 0x2319E00 VA: 0x18231AA00
	internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x231AA50 Offset: 0x2319E50 VA: 0x18231AA50
	public static AssetBundle LoadFromFile(string path) { }

	[NativeMethodAttribute] // RVA: 0xAC060 Offset: 0xAB460 VA: 0x1800AC060
	// RVA: 0x231A370 Offset: 0x2319770 VA: 0x18231A370
	public bool Contains(string name) { }

	// RVA: -1 Offset: -1
	public T LoadAsset<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A3DC0 Offset: 0x14A31C0 VA: 0x1814A3DC0
	|-AssetBundle.LoadAsset<WorkshopSkinBase>
	|-AssetBundle.LoadAsset<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xAC110 Offset: 0xAB510 VA: 0x1800AC110
	// RVA: 0x231A850 Offset: 0x2319C50 VA: 0x18231A850
	public Object LoadAsset(string name, Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC1D0 Offset: 0xAB5D0 VA: 0x1800AC1D0
	[TypeInferenceRuleAttribute] // RVA: 0xAC1D0 Offset: 0xAB5D0 VA: 0x1800AC1D0
	[NativeMethodAttribute] // RVA: 0xAC1D0 Offset: 0xAB5D0 VA: 0x1800AC1D0
	// RVA: 0x231A7F0 Offset: 0x2319BF0 VA: 0x18231A7F0
	private Object LoadAsset_Internal(string name, Type type) { }

	// RVA: 0x231A630 Offset: 0x2319A30 VA: 0x18231A630
	public AssetBundleRequest LoadAssetAsync(string name) { }

	// RVA: -1 Offset: -1
	public AssetBundleRequest LoadAssetAsync<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9E050 Offset: 0x1A9D450 VA: 0x181A9E050
	|-AssetBundle.LoadAssetAsync<object>
	|-AssetBundle.LoadAssetAsync<Sprite>
	|-AssetBundle.LoadAssetAsync<TextAsset>
	|-AssetBundle.LoadAssetAsync<Texture2D>
	*/

	// RVA: 0x231A510 Offset: 0x2319910 VA: 0x18231A510
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: -1 Offset: -1
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9DE80 Offset: 0x1A9D280 VA: 0x181A9DE80
	|-AssetBundle.ConvertObjects<object>
	*/

	// RVA: -1 Offset: -1
	public T[] LoadAllAssets<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9DFB0 Offset: 0x1A9D3B0 VA: 0x181A9DFB0
	|-AssetBundle.LoadAllAssets<AssetBundleManifest>
	|-AssetBundle.LoadAllAssets<object>
	*/

	// RVA: 0x231A400 Offset: 0x2319800 VA: 0x18231A400
	public Object[] LoadAllAssets(Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC3B0 Offset: 0xAB7B0 VA: 0x1800AC3B0
	[NativeMethodAttribute] // RVA: 0xAC3B0 Offset: 0xAB7B0 VA: 0x1800AC3B0
	// RVA: 0x231A4B0 Offset: 0x23198B0 VA: 0x18231A4B0
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeMethodAttribute] // RVA: 0xAC610 Offset: 0xABA10 VA: 0x1800AC610
	// RVA: 0x231AA90 Offset: 0x2319E90 VA: 0x18231AA90
	public void Unload(bool unloadAllLoadedObjects) { }

	[NativeMethodAttribute] // RVA: 0xAC6D0 Offset: 0xABAD0 VA: 0x1800AC6D0
	// RVA: 0x231A3C0 Offset: 0x23197C0 VA: 0x18231A3C0
	public string[] GetAllAssetNames() { }

	[NativeThrowsAttribute] // RVA: 0xAC880 Offset: 0xABC80 VA: 0x1800AC880
	[NativeMethodAttribute] // RVA: 0xAC880 Offset: 0xABC80 VA: 0x1800AC880
	// RVA: 0x231A790 Offset: 0x2319B90 VA: 0x18231A790
	internal Object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

}

public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 3993
{	// Properties
	public AssetBundle assetBundle { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0xACAF0 Offset: 0xABEF0 VA: 0x1800ACAF0
	// RVA: 0x231A2B0 Offset: 0x23196B0 VA: 0x18231A2B0
	public AssetBundle get_assetBundle() { }

	// RVA: 0x531100 Offset: 0x530500 VA: 0x180531100
	public void .ctor() { }

}

public class AssetBundleManifest : Object // TypeDefIndex: 3994
{	// Methods

	[NativeMethodAttribute] // RVA: 0xACCD0 Offset: 0xAC0D0 VA: 0x1800ACCD0
	// RVA: 0x231A2F0 Offset: 0x23196F0 VA: 0x18231A2F0
	public string[] GetAllAssetBundles() { }

}

public class AssetBundleRequest : AsyncOperation // TypeDefIndex: 3996
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xACF80 Offset: 0xAC380 VA: 0x1800ACF80
[RequiredByNativeCodeAttribute] // RVA: 0xACF80 Offset: 0xAC380 VA: 0x1800ACF80
public class AssetBundleRequest : AsyncOperation // TypeDefIndex: 3996
	// Properties
	public Object asset { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0xAE380 Offset: 0xAD780 VA: 0x1800AE380
	// RVA: 0x231A330 Offset: 0x2319730 VA: 0x18231A330
	public Object get_asset() { }

	// RVA: 0x531100 Offset: 0x530500 VA: 0x180531100
	public void .ctor() { }

}

public static class AssetPool // TypeDefIndex: 6562
{	// Fields
	public static Dictionary<Type, AssetPool.Pool> storage; // 0x2A80

	// Methods

	// RVA: -1 Offset: -1
	public static T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E37C0 Offset: 0x5E2BC0 VA: 0x1805E37C0
	|-AssetPool.Get<Mesh>
	|-AssetPool.Get<object>
	*/

	// RVA: 0x1B985B0 Offset: 0x1B979B0 VA: 0x181B985B0
	public static void Free(ref Mesh mesh) { }

	// RVA: -1 Offset: -1
	private static AssetPool.Pool GetPool<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257000 Offset: 0x1256400 VA: 0x181257000
	|-AssetPool.GetPool<object>
	|-AssetPool.GetPool<Mesh>
	*/

	// RVA: 0x1B98450 Offset: 0x1B97850 VA: 0x181B98450
	public static void Clear() { }

	// RVA: 0x1B98630 Offset: 0x1B97A30 VA: 0x181B98630
	private static void .cctor() { }

}

public class AssetPool.Pool // TypeDefIndex: 6563
{	// Fields
	public Stack<Object> stack; // 0x10
	public int allocated; // 0x18
	public int available; // 0x1C
	public string name; // 0x20

	// Methods

	// RVA: 0x1BA40E0 Offset: 0x1BA34E0 VA: 0x181BA40E0
	public void .ctor(string name) { }

	// RVA: -1 Offset: -1
	public T Pop<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5ED140 Offset: 0x5EC540 VA: 0x1805ED140
	|-AssetPool.Pool.Pop<object>
	*/

	// RVA: -1 Offset: -1
	public void Push<T>(ref T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1548100 Offset: 0x1547500 VA: 0x181548100
	|-AssetPool.Pool.Push<object>
	|-AssetPool.Pool.Push<Mesh>
	*/

	// RVA: 0x1BA3F80 Offset: 0x1BA3380 VA: 0x181BA3F80
	public void Clear() { }

}

public class AssetBundleBackend : FileSystemBackend, IDisposable // TypeDefIndex: 6651
{
// Namespace: 
public class AssetBundleBackend : FileSystemBackend, IDisposable // TypeDefIndex: 6651
	// Fields
	private AssetBundle rootBundle; // 0x28
	private AssetBundleManifest manifest; // 0x30
	private Dictionary<string, AssetBundle> bundles; // 0x38
	private Dictionary<string, AssetBundle> files; // 0x40
	private string assetPath; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <LoadProgress>k__BackingField; // 0x50

	// Properties
	public static bool Enabled { get; }
	public float LoadProgress { get; set; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	public static bool get_Enabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6BA1C0 Offset: 0x6B95C0 VA: 0x1806BA1C0
	public float get_LoadProgress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22B6A20 Offset: 0x22B5E20 VA: 0x1822B6A20
	private void set_LoadProgress(float value) { }

	// RVA: 0x22B6290 Offset: 0x22B5690 VA: 0x1822B6290
	public void Load(string assetRoot) { }

	// RVA: 0x22B6130 Offset: 0x22B5530 VA: 0x1822B6130
	private AssetBundle LoadBundle(string bundleName) { }

	// RVA: 0x22B5830 Offset: 0x22B4C30 VA: 0x1822B5830
	public void BuildFileIndex() { }

	// RVA: 0x22B5A20 Offset: 0x22B4E20 VA: 0x1822B5A20 Slot: 9
	public void Dispose() { }

	// RVA: 0x22B6520 Offset: 0x22B5920 VA: 0x1822B6520 Slot: 4
	public override List<string> UnloadBundles(string partialName) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected override T LoadAsset<T>(string filePath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E3720 Offset: 0x5E2B20 VA: 0x1805E3720
	|-AssetBundleBackend.LoadAsset<object>
	*/

	// RVA: 0x22B5FB0 Offset: 0x22B53B0 VA: 0x1822B5FB0 Slot: 6
	protected override LoadAssetsResult LoadAssetsAsync(List<string> filePaths, int maxConcurrency, int priority) { }

	// RVA: 0x22B5C30 Offset: 0x22B5030 VA: 0x1822B5C30 Slot: 7
	protected override string[] LoadAssetList(string folder, string search) { }

	// RVA: -1 Offset: -1 Slot: 8
	public override T[] LoadAllFromBundle<T>(string bundleName, string editorSearch) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A3B30 Offset: 0x14A2F30 VA: 0x1814A3B30
	|-AssetBundleBackend.LoadAllFromBundle<object>
	*/

	// RVA: 0x22B67E0 Offset: 0x22B5BE0 VA: 0x1822B67E0
	public void .ctor() { }

}

private sealed class AssetBundleBackend.<>c__DisplayClass17_0 // TypeDefIndex: 6652
{	// Fields
	public AssetBundleBackend <>4__this; // 0x10
	public int maxConcurrency; // 0x18
	public int priority; // 0x1C

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22B8CF0 Offset: 0x22B80F0 VA: 0x1822B8CF0
	internal bool <LoadAssetsAsync>b__0(string p) { }

	// RVA: 0x22B8D50 Offset: 0x22B8150 VA: 0x1822B8D50
	internal AssetBundle <LoadAssetsAsync>b__1(string p) { }

	// RVA: 0x22B8DB0 Offset: 0x22B81B0 VA: 0x1822B8DB0
	internal LoadAssetsResult <LoadAssetsAsync>b__2(IGrouping<AssetBundle, string> g) { }

}

private sealed class AssetBundleBackend.<>c // TypeDefIndex: 6653
{	// Fields
	public static readonly AssetBundleBackend.<>c <>9; // 0x0
	public static Func<string, string> <>9__17_3; // 0x8

	// Methods

	// RVA: 0x22B9070 Offset: 0x22B8470 VA: 0x1822B9070
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	internal string <LoadAssetsAsync>b__17_3(string p) { }

}

private sealed class AssetBundleBackend.<>c__DisplayClass18_0 // TypeDefIndex: 6654
{	// Fields
	public string folder; // 0x10
	public Func<KeyValuePair<string, AssetBundle>, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22B9010 Offset: 0x22B8410 VA: 0x1822B9010
	internal bool <LoadAssetList>b__0(KeyValuePair<string, AssetBundle> x) { }

}

internal class AssetBundleLoadAssetsResult : LoadAssetsResult // TypeDefIndex: 6655
{	// Fields
	private readonly AssetBundle _bundle; // 0x20
	private readonly List<string> _filePaths; // 0x28
	private readonly int _maxConcurrency; // 0x30
	private readonly int _priority; // 0x34
	private readonly List<AssetBundleRequest> _requests; // 0x38
	[TupleElementNamesAttribute] // RVA: 0xC0680 Offset: 0xBFA80 VA: 0x1800C0680
	private readonly List<ValueTuple<string, AssetBundleRequest>> _pendingRequests; // 0x40
	private int _index; // 0x48

	// Properties
	public override int TotalCount { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x22B7360 Offset: 0x22B6760 VA: 0x1822B7360 Slot: 8
	public override int get_TotalCount() { }

	// RVA: 0x22B7060 Offset: 0x22B6460 VA: 0x1822B7060
	internal void .ctor(AssetBundle bundle, List<string> filePaths, int maxConcurrency, int priority) { }

	// RVA: 0x22B73A0 Offset: 0x22B67A0 VA: 0x1822B73A0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x22B6BB0 Offset: 0x22B5FB0 VA: 0x1822B6BB0
	private bool Update() { }

	// RVA: 0x22B6A30 Offset: 0x22B5E30 VA: 0x1822B6A30 Slot: 11
	public override Dictionary<string, Object> GetResult() { }

}

public class AssetPreloadResult : CustomYieldInstruction // TypeDefIndex: 6656
{	// Fields
	private readonly FileSystemBackend _backend; // 0x10
	private readonly LoadAssetsResult _load; // 0x18
	private readonly List<ValueTuple<string, Object>> _loaded; // 0x20
	private readonly int _alreadyLoadedCount; // 0x28

	// Properties
	public int TotalCount { get; }
	public int CompletedCount { get; }
	[TupleElementNamesAttribute] // RVA: 0xC0AF0 Offset: 0xBFEF0 VA: 0x1800C0AF0
	public IReadOnlyList<ValueTuple<string, Object>> Results { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x22B7540 Offset: 0x22B6940 VA: 0x1822B7540
	internal void .ctor(FileSystemBackend backend, LoadAssetsResult load, List<ValueTuple<string, Object>> loaded) { }

	// RVA: 0x22B7740 Offset: 0x22B6B40 VA: 0x1822B7740
	public int get_TotalCount() { }

	// RVA: 0x22B7710 Offset: 0x22B6B10 VA: 0x1822B7710
	public int get_CompletedCount() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public IReadOnlyList<ValueTuple<string, Object>> get_Results() { }

	// RVA: 0x13CD2B0 Offset: 0x13CC6B0 VA: 0x1813CD2B0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x22B73C0 Offset: 0x22B67C0 VA: 0x1822B73C0
	private void OnAssetLoaded(string path, Object obj) { }

}

public static class AssetNameCache // TypeDefIndex: 10715
{	// Fields
	private static Dictionary<Object, string> mixed; // 0x0
	private static Dictionary<Object, string> lower; // 0x8
	private static Dictionary<Object, string> upper; // 0x10

	// Methods

	// RVA: 0x82E640 Offset: 0x82DA40 VA: 0x18082E640
	private static string LookupName(Object obj) { }

	// RVA: 0x82E380 Offset: 0x82D780 VA: 0x18082E380
	private static string LookupNameLower(Object obj) { }

	// RVA: 0x82E4E0 Offset: 0x82D8E0 VA: 0x18082E4E0
	private static string LookupNameUpper(Object obj) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x82E2C0 Offset: 0x82D6C0 VA: 0x18082E2C0
	public static string GetName(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x82E140 Offset: 0x82D540 VA: 0x18082E140
	public static string GetNameLower(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x82E200 Offset: 0x82D600 VA: 0x18082E200
	public static string GetNameUpper(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x82E320 Offset: 0x82D720 VA: 0x18082E320
	public static string GetName(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x82E1A0 Offset: 0x82D5A0 VA: 0x18082E1A0
	public static string GetNameLower(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x82E260 Offset: 0x82D660 VA: 0x18082E260
	public static string GetNameUpper(Material mat) { }

	// RVA: 0x82E780 Offset: 0x82DB80 VA: 0x18082E780
	private static void .cctor() { }

}

public static class AssetStorage // TypeDefIndex: 11362
{	// Methods

	// RVA: -1 Offset: -1
	public static void Save<T>(ref T asset, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1537240 Offset: 0x1536640 VA: 0x181537240
	|-AssetStorage.Save<object>
	*/

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void Save(ref Texture2D asset) { }

	// RVA: 0x82E860 Offset: 0x82DC60 VA: 0x18082E860
	public static void Save(ref Texture2D asset, string path, bool linear, bool compress) { }

	// RVA: -1 Offset: -1
	public static void Load<T>(ref T asset, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	|-AssetStorage.Load<object>
	*/

	// RVA: -1 Offset: -1
	public static void Delete<T>(ref T asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15371A0 Offset: 0x15365A0 VA: 0x1815371A0
	|-AssetStorage.Delete<object>
	*/

}

