internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 3263
{

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024

internal class <Module>

[VisibleToOtherModulesAttribute] 
[AttributeUsageAttribute] 
internal sealed class AssetFileNameExtensionAttribute : Attribute
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private readonly string <preferredExtension>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private readonly IEnumerable<string> <otherExtensions>k__BackingField; 


	public void .ctor(string preferredExtension, string[] otherExtensions) { }

}

public class AssetBundle : Object // TypeDefIndex: 3997
{

[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
[ExcludeFromPresetAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
public class AssetBundle : Object

	private void .ctor() { }

	[FreeFunctionAttribute] 
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	[FreeFunctionAttribute] 
	internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) { }

	public static AssetBundle LoadFromFile(string path) { }

	[NativeMethodAttribute] 
	public bool Contains(string name) { }

	public T LoadAsset<T>(string name) { }
	/* GenericInstMethod :
	|
	|-AssetBundle.LoadAsset<WorkshopSkinBase>
	|-AssetBundle.LoadAsset<object>
	*/

	[TypeInferenceRuleAttribute] 
	public Object LoadAsset(string name, Type type) { }

	[NativeThrowsAttribute] 
	[TypeInferenceRuleAttribute] 
	[NativeMethodAttribute] 
	private Object LoadAsset_Internal(string name, Type type) { }

	public AssetBundleRequest LoadAssetAsync(string name) { }

	public AssetBundleRequest LoadAssetAsync<T>(string name) { }
	/* GenericInstMethod :
	|
	|-AssetBundle.LoadAssetAsync<object>
	|-AssetBundle.LoadAssetAsync<Sprite>
	|-AssetBundle.LoadAssetAsync<TextAsset>
	|-AssetBundle.LoadAssetAsync<Texture2D>
	*/

	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-AssetBundle.ConvertObjects<object>
	*/

	public T[] LoadAllAssets<T>() { }
	/* GenericInstMethod :
	|
	|-AssetBundle.LoadAllAssets<AssetBundleManifest>
	|-AssetBundle.LoadAllAssets<object>
	*/

	public Object[] LoadAllAssets(Type type) { }

	[NativeThrowsAttribute] 
	[NativeMethodAttribute] 
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeMethodAttribute] 
	public void Unload(bool unloadAllLoadedObjects) { }

	[NativeMethodAttribute] 
	public string[] GetAllAssetNames() { }

	[NativeThrowsAttribute] 
	[NativeMethodAttribute] 
	internal Object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

}

public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 3998
{
	public AssetBundle assetBundle { get; }


	[NativeMethodAttribute] 
	public AssetBundle get_assetBundle() { }

	public void .ctor() { }

}

public class AssetBundleManifest : Object // TypeDefIndex: 3999
{

	[NativeMethodAttribute] 
	public string[] GetAllAssetBundles() { }

}

public class AssetBundleRequest : AsyncOperation // TypeDefIndex: 4001
{

[NativeHeaderAttribute] 
[RequiredByNativeCodeAttribute] 
public class AssetBundleRequest : AsyncOperation
	public Object asset { get; }


	[NativeMethodAttribute] 
	public Object get_asset() { }

	public void .ctor() { }

}

public static class AssetPool // TypeDefIndex: 6572
{
	public static Dictionary<Type, AssetPool.Pool> storage; 


	public static T Get<T>() { }
	/* GenericInstMethod :
	|
	|-AssetPool.Get<Mesh>
	|-AssetPool.Get<object>
	*/

	public static void Free(ref Mesh mesh) { }

	private static AssetPool.Pool GetPool<T>() { }
	/* GenericInstMethod :
	|
	|-AssetPool.GetPool<object>
	|-AssetPool.GetPool<Mesh>
	*/

	public static void Clear() { }

	private static void .cctor() { }

}

public class AssetPool.Pool // TypeDefIndex: 6573
{
	public Stack<Object> stack; 
	public int allocated; 
	public int available; 
	public string name; 


	public void .ctor(string name) { }

	public T Pop<T>() { }
	/* GenericInstMethod :
	|
	|-AssetPool.Pool.Pop<object>
	*/

	public void Push<T>(ref T instance) { }
	/* GenericInstMethod :
	|
	|-AssetPool.Pool.Push<object>
	|-AssetPool.Pool.Push<Mesh>
	*/

	public void Clear() { }

}

public class AssetBundleBackend : FileSystemBackend, IDisposable // TypeDefIndex: 6661
{

public class AssetBundleBackend : FileSystemBackend, IDisposable
	private AssetBundle rootBundle; 
	private AssetBundleManifest manifest; 
	private Dictionary<string, AssetBundle> bundles; 
	private Dictionary<string, AssetBundle> files; 
	private string assetPath; 
	[CompilerGeneratedAttribute] 
	private float <LoadProgress>k__BackingField; 

	public static bool Enabled { get; }
	public float LoadProgress { get; set; }


	public static bool get_Enabled() { }

	[CompilerGeneratedAttribute] 
	public float get_LoadProgress() { }

	[CompilerGeneratedAttribute] 
	private void set_LoadProgress(float value) { }

	public void Load(string assetRoot) { }

	private AssetBundle LoadBundle(string bundleName) { }

	public void BuildFileIndex() { }

	public void Dispose() { }

	public override List<string> UnloadBundles(string partialName) { }

	protected override T LoadAsset<T>(string filePath) { }
	/* GenericInstMethod :
	|
	|-AssetBundleBackend.LoadAsset<object>
	*/

	protected override LoadAssetsResult LoadAssetsAsync(List<string> filePaths, int maxConcurrency, int priority) { }

	protected override string[] LoadAssetList(string folder, string search) { }

	public override T[] LoadAllFromBundle<T>(string bundleName, string editorSearch) { }
	/* GenericInstMethod :
	|
	|-AssetBundleBackend.LoadAllFromBundle<object>
	*/

	public void .ctor() { }

}

private sealed class AssetBundleBackend.<>c__DisplayClass17_0 // TypeDefIndex: 6662
{
	public AssetBundleBackend <>4__this; 
	public int maxConcurrency; 
	public int priority; 


	public void .ctor() { }

	internal bool <LoadAssetsAsync>

	internal AssetBundle <LoadAssetsAsync>

	internal LoadAssetsResult <LoadAssetsAsync>

}

private sealed class AssetBundleBackend.<>c // TypeDefIndex: 6663
{
	public static readonly AssetBundleBackend.<>c <>9; 
	public static Func<string, string> <>9__17_3; 


	private static void .cctor() { }

	public void .ctor() { }

	internal string <LoadAssetsAsync>

}

private sealed class AssetBundleBackend.<>c__DisplayClass18_0 // TypeDefIndex: 6664
{
	public string folder; 
	public Func<KeyValuePair<string, AssetBundle>, bool> <>9__0; 


	public void .ctor() { }

	internal bool <LoadAssetList>

}

internal class AssetBundleLoadAssetsResult : LoadAssetsResult // TypeDefIndex: 6665
{
	private readonly AssetBundle _bundle; 
	private readonly List<string> _filePaths; 
	private readonly int _maxConcurrency; 
	private readonly int _priority; 
	private readonly List<AssetBundleRequest> _requests; 
	[TupleElementNamesAttribute] 
	private readonly List<ValueTuple<string, AssetBundleRequest>> _pendingRequests; 
	private int _index; 

	public override int TotalCount { get; }
	public override bool keepWaiting { get; }


	public override int get_TotalCount() { }

	internal void .ctor(AssetBundle bundle, List<string> filePaths, int maxConcurrency, int priority) { }

	public override bool get_keepWaiting() { }

	private bool Update() { }

	public override Dictionary<string, Object> GetResult() { }

}

public class AssetPreloadResult : CustomYieldInstruction // TypeDefIndex: 6666
{
	private readonly FileSystemBackend _backend; 
	private readonly LoadAssetsResult _load; 
	private readonly List<ValueTuple<string, Object>> _loaded; 
	private readonly int _alreadyLoadedCount; 

	public int TotalCount { get; }
	public int CompletedCount { get; }
	[TupleElementNamesAttribute] 
	public IReadOnlyList<ValueTuple<string, Object>> Results { get; }
	public override bool keepWaiting { get; }


	internal void .ctor(FileSystemBackend backend, LoadAssetsResult load, List<ValueTuple<string, Object>> loaded) { }

	public int get_TotalCount() { }

	public int get_CompletedCount() { }

	public IReadOnlyList<ValueTuple<string, Object>> get_Results() { }

	public override bool get_keepWaiting() { }

	private void OnAssetLoaded(string path, Object obj) { }

}

public static class AssetNameCache // TypeDefIndex: 12466
{
	private static Dictionary<Object, string> mixed; 
	private static Dictionary<Object, string> lower; 
	private static Dictionary<Object, string> upper; 


	private static string LookupName(Object obj) { }

	private static string LookupNameLower(Object obj) { }

	private static string LookupNameUpper(Object obj) { }

	[ExtensionAttribute] 
	public static string GetName(PhysicMaterial mat) { }

	[ExtensionAttribute] 
	public static string GetNameLower(PhysicMaterial mat) { }

	[ExtensionAttribute] 
	public static string GetNameUpper(PhysicMaterial mat) { }

	[ExtensionAttribute] 
	public static string GetName(Material mat) { }

	[ExtensionAttribute] 
	public static string GetNameLower(Material mat) { }

	[ExtensionAttribute] 
	public static string GetNameUpper(Material mat) { }

	private static void .cctor() { }

}

public static class AssetStorage // TypeDefIndex: 13155
{

	public static void Save<T>(ref T asset, string path) { }
	/* GenericInstMethod :
	|
	|-AssetStorage.Save<object>
	*/

	public static void Save(ref Texture2D asset) { }

	public static void Save(ref Texture2D asset, string path, bool linear, bool compress) { }

	public static void Load<T>(ref T asset, string path) { }
	/* GenericInstMethod :
	|
	|-AssetStorage.Load<object>
	*/

	public static void Delete<T>(ref T asset) { }
	/* GenericInstMethod :
	|
	|-AssetStorage.Delete<object>
	*/

}

