public class Skin // TypeDefIndex: 7701
{
	private string manifestName; 
	private string manifestContent; 
	private TextAsset manifestAsset; 
	private Skin.Manifest manifest; 
	private string iconName; 
	public Sprite sprite; 
	public int references; 
	public Skinnable Skinnable; 
	public Material[] Materials; 
	public Material[] DefaultMaterials; 
	public List<Texture> TextureAssets; 
	public List<Texture> TextureObjects; 
	[CompilerGeneratedAttribute] 
	private bool <AssetsRequested>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IconRequested>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <AssetsLoaded>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IconLoaded>k__BackingField; 
	public Action OnLoaded; 
	public Action OnIconLoaded; 

	public bool AssetsRequested { get; set; }
	public bool IconRequested { get; set; }
	public bool AssetsLoaded { get; set; }
	public bool IconLoaded { get; set; }


	private void LoadManifestFromFile() { }

	private void DeserializeManifest() { }

	[IteratorStateMachineAttribute] 
	public IEnumerator LoadIcon(ulong workshopId, string directory, AssetBundle bundle) { }

	[IteratorStateMachineAttribute] 
	public IEnumerator LoadAssets(ulong workshopId, string directory, AssetBundle bundle) { }

	public void UnloadAssets() { }

	private void UpdateTextureMetadata(Texture2D texture, string textureName, bool anisoFiltering, bool trilinearFiltering) { }

	internal void Apply(GameObject gameObject) { }

	public int GetSizeInBytes() { }

	[CompilerGeneratedAttribute] 
	public bool get_AssetsRequested() { }

	[CompilerGeneratedAttribute] 
	public void set_AssetsRequested(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IconRequested() { }

	[CompilerGeneratedAttribute] 
	public void set_IconRequested(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_AssetsLoaded() { }

	[CompilerGeneratedAttribute] 
	internal void set_AssetsLoaded(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IconLoaded() { }

	[CompilerGeneratedAttribute] 
	internal void set_IconLoaded(bool value) { }

	public static void Apply(GameObject obj, Skinnable skinnable, Material[] Materials) { }

	internal void ReadDefaults() { }

	public void .ctor() { }

}

public class Skin.Manifest // TypeDefIndex: 7702
{
	[CompilerGeneratedAttribute] 
	private int <Version>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <ItemType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <AuthorId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private DateTime <PublishDate>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Skin.Manifest.Group[] <Groups>k__BackingField; 

	public int Version { get; set; }
	public string ItemType { get; set; }
	public ulong AuthorId { get; set; }
	public DateTime PublishDate { get; set; }
	public Skin.Manifest.Group[] Groups { get; set; }


	[CompilerGeneratedAttribute] 
	public int get_Version() { }

	[CompilerGeneratedAttribute] 
	public void set_Version(int value) { }

	[CompilerGeneratedAttribute] 
	public string get_ItemType() { }

	[CompilerGeneratedAttribute] 
	public void set_ItemType(string value) { }

	[CompilerGeneratedAttribute] 
	public ulong get_AuthorId() { }

	[CompilerGeneratedAttribute] 
	public void set_AuthorId(ulong value) { }

	[CompilerGeneratedAttribute] 
	public DateTime get_PublishDate() { }

	[CompilerGeneratedAttribute] 
	public void set_PublishDate(DateTime value) { }

	[CompilerGeneratedAttribute] 
	public Skin.Manifest.Group[] get_Groups() { }

	[CompilerGeneratedAttribute] 
	public void set_Groups(Skin.Manifest.Group[] value) { }

	public void .ctor() { }

}

public class Skin.Manifest.Group // TypeDefIndex: 7703
{
	[CompilerGeneratedAttribute] 
	private Dictionary<string, string> <Textures>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Dictionary<string, float> <Floats>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Dictionary<string, Skin.Manifest.ColorEntry> <Colors>k__BackingField; 

	public Dictionary<string, string> Textures { get; set; }
	public Dictionary<string, float> Floats { get; set; }
	public Dictionary<string, Skin.Manifest.ColorEntry> Colors { get; set; }


	[CompilerGeneratedAttribute] 
	public Dictionary<string, string> get_Textures() { }

	[CompilerGeneratedAttribute] 
	public void set_Textures(Dictionary<string, string> value) { }

	[CompilerGeneratedAttribute] 
	public Dictionary<string, float> get_Floats() { }

	[CompilerGeneratedAttribute] 
	public void set_Floats(Dictionary<string, float> value) { }

	[CompilerGeneratedAttribute] 
	public Dictionary<string, Skin.Manifest.ColorEntry> get_Colors() { }

	[CompilerGeneratedAttribute] 
	public void set_Colors(Dictionary<string, Skin.Manifest.ColorEntry> value) { }

	public void .ctor() { }

}

public class Skin.Manifest.ColorEntry // TypeDefIndex: 7704
{
	[CompilerGeneratedAttribute] 
	private float <r>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <g>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <b>k__BackingField; 

	public float r { get; set; }
	public float g { get; set; }
	public float b { get; set; }


	public void .ctor(Color c) { }

	[CompilerGeneratedAttribute] 
	public float get_r() { }

	[CompilerGeneratedAttribute] 
	public void set_r(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_g() { }

	[CompilerGeneratedAttribute] 
	public void set_g(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_b() { }

	[CompilerGeneratedAttribute] 
	public void set_b(float value) { }

}

private sealed class Skin.<>c__DisplayClass10_0 // TypeDefIndex: 7705
{
	public InventoryDef[] definitions; 
	public string downloadUrl; 
	public Skin <>4__this; 


	public void .ctor() { }

	internal void <LoadIcon>g__FindURL|0() { }

}

private sealed class Skin.<LoadIcon>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7706
{
	private int <>1__state; 
	private object <>2__current; 
	public AssetBundle bundle; 
	public Skin <>4__this; 
	public ulong workshopId; 
	public string directory; 
	private Skin.<>c__DisplayClass10_0 <>8__1; 
	private AssetBundleRequest <textRequest>5__2; 
	private UnityWebRequest <request>5__3; 
	private AsyncTextureLoad <request>5__4; 

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

private sealed class Skin.<LoadAssets>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7707
{
	private int <>1__state; 
	private object <>2__current; 
	public Skin <>4__this; 
	public ulong workshopId; 
	public AssetBundle bundle; 
	public string directory; 
	private int <i>5__2; 
	private Material <material>5__3; 
	private Dictionary.Enumerator<string, string> <>7__wrap3; 
	private KeyValuePair<string, string> <mat>5__5; 
	private bool <isDiffuseMap>5__6; 
	private bool <isNormalMap>5__7; 
	private bool <isOcclusionMap>5__8; 
	private string <textureName>5__9; 
	private AssetBundleRequest <textureRequest>5__10; 
	private AsyncTextureLoad <request>5__11; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

