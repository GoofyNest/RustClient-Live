public class Skin // TypeDefIndex: 7728
{	// Fields
	private string manifestName; // 0x10
	private string manifestContent; // 0x18
	private TextAsset manifestAsset; // 0x20
	private Skin.Manifest manifest; // 0x28
	private string iconName; // 0x30
	public Sprite sprite; // 0x38
	public int references; // 0x40
	public Skinnable Skinnable; // 0x48
	public Material[] Materials; // 0x50
	public Material[] DefaultMaterials; // 0x58
	public List<Texture> TextureAssets; // 0x60
	public List<Texture> TextureObjects; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <AssetsRequested>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IconRequested>k__BackingField; // 0x71
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <AssetsLoaded>k__BackingField; // 0x72
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IconLoaded>k__BackingField; // 0x73
	public Action OnLoaded; // 0x78
	public Action OnIconLoaded; // 0x80

	// Properties
	public bool AssetsRequested { get; set; }
	public bool IconRequested { get; set; }
	public bool AssetsLoaded { get; set; }
	public bool IconLoaded { get; set; }

	// Methods

	// RVA: 0xE88A30 Offset: 0xE87E30 VA: 0x180E88A30
	private void LoadManifestFromFile() { }

	// RVA: 0xE88580 Offset: 0xE87980 VA: 0x180E88580
	private void DeserializeManifest() { }

	[IteratorStateMachineAttribute] // RVA: 0xCABF0 Offset: 0xC9FF0 VA: 0x1800CABF0
	// RVA: 0xE88980 Offset: 0xE87D80 VA: 0x180E88980
	public IEnumerator LoadIcon(ulong workshopId, string directory, AssetBundle bundle) { }

	[IteratorStateMachineAttribute] // RVA: 0xCACF0 Offset: 0xCA0F0 VA: 0x1800CACF0
	// RVA: 0xE888D0 Offset: 0xE87CD0 VA: 0x180E888D0
	public IEnumerator LoadAssets(ulong workshopId, string directory, AssetBundle bundle) { }

	// RVA: 0xE88E80 Offset: 0xE88280 VA: 0x180E88E80
	public void UnloadAssets() { }

	// RVA: 0xE89140 Offset: 0xE88540 VA: 0x180E89140
	private void UpdateTextureMetadata(Texture2D texture, string textureName, bool anisoFiltering, bool trilinearFiltering) { }

	// RVA: 0xE88560 Offset: 0xE87960 VA: 0x180E88560
	internal void Apply(GameObject gameObject) { }

	// RVA: 0xE88600 Offset: 0xE87A00 VA: 0x180E88600
	public int GetSizeInBytes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC2CA80 Offset: 0xC2BE80 VA: 0x180C2CA80
	public bool get_AssetsRequested() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC2DBA0 Offset: 0xC2CFA0 VA: 0x180C2DBA0
	public void set_AssetsRequested(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE891D0 Offset: 0xE885D0 VA: 0x180E891D0
	public bool get_IconRequested() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE89200 Offset: 0xE88600 VA: 0x180E89200
	public void set_IconRequested(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE891B0 Offset: 0xE885B0 VA: 0x180E891B0
	public bool get_AssetsLoaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE891E0 Offset: 0xE885E0 VA: 0x180E891E0
	internal void set_AssetsLoaded(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE891C0 Offset: 0xE885C0 VA: 0x180E891C0
	public bool get_IconLoaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE891F0 Offset: 0xE885F0 VA: 0x180E891F0
	internal void set_IconLoaded(bool value) { }

	// RVA: 0xE88380 Offset: 0xE87780 VA: 0x180E88380
	public static void Apply(GameObject obj, Skinnable skinnable, Material[] Materials) { }

	// RVA: 0xE88A60 Offset: 0xE87E60 VA: 0x180E88A60
	internal void ReadDefaults() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class Skin.Manifest // TypeDefIndex: 7729
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Version>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <ItemType>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <AuthorId>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DateTime <PublishDate>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Skin.Manifest.Group[] <Groups>k__BackingField; // 0x30

	// Properties
	public int Version { get; set; }
	public string ItemType { get; set; }
	public ulong AuthorId { get; set; }
	public DateTime PublishDate { get; set; }
	public Skin.Manifest.Group[] Groups { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	public void set_Version(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_ItemType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_ItemType(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public ulong get_AuthorId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE87960 Offset: 0xE86D60 VA: 0x180E87960
	public void set_AuthorId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public DateTime get_PublishDate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE86650 Offset: 0xE85A50 VA: 0x180E86650
	public void set_PublishDate(DateTime value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public Skin.Manifest.Group[] get_Groups() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_Groups(Skin.Manifest.Group[] value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class Skin.Manifest.Group // TypeDefIndex: 7730
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Dictionary<string, string> <Textures>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Dictionary<string, float> <Floats>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Dictionary<string, Skin.Manifest.ColorEntry> <Colors>k__BackingField; // 0x20

	// Properties
	public Dictionary<string, string> Textures { get; set; }
	public Dictionary<string, float> Floats { get; set; }
	public Dictionary<string, Skin.Manifest.ColorEntry> Colors { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Dictionary<string, string> get_Textures() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Textures(Dictionary<string, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Dictionary<string, float> get_Floats() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Floats(Dictionary<string, float> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public Dictionary<string, Skin.Manifest.ColorEntry> get_Colors() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_Colors(Dictionary<string, Skin.Manifest.ColorEntry> value) { }

	// RVA: 0xE86EB0 Offset: 0xE862B0 VA: 0x180E86EB0
	public void .ctor() { }

}

public class Skin.Manifest.ColorEntry // TypeDefIndex: 7731
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <r>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <g>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <b>k__BackingField; // 0x18

	// Properties
	public float r { get; set; }
	public float g { get; set; }
	public float b { get; set; }

	// Methods

	// RVA: 0xE86660 Offset: 0xE85A60 VA: 0x180E86660
	public void .ctor(Color c) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9EF9F0 Offset: 0x9EEDF0 VA: 0x1809EF9F0
	public float get_r() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9EFA10 Offset: 0x9EEE10 VA: 0x1809EFA10
	public void set_r(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE866A0 Offset: 0xE85AA0 VA: 0x180E866A0
	public float get_g() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE866B0 Offset: 0xE85AB0 VA: 0x180E866B0
	public void set_g(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772410 Offset: 0x771810 VA: 0x180772410
	public float get_b() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772450 Offset: 0x771850 VA: 0x180772450
	public void set_b(float value) { }

}

private sealed class Skin.<>c__DisplayClass10_0 // TypeDefIndex: 7732
{	// Fields
	public InventoryDef[] definitions; // 0x10
	public string downloadUrl; // 0x18
	public Skin <>4__this; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xE94010 Offset: 0xE93410 VA: 0x180E94010
	internal void <LoadIcon>g__FindURL|0() { }

}

private sealed class Skin.<LoadIcon>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7733
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AssetBundle bundle; // 0x20
	public Skin <>4__this; // 0x28
	public ulong workshopId; // 0x30
	public string directory; // 0x38
	private Skin.<>c__DisplayClass10_0 <>8__1; // 0x40
	private AssetBundleRequest <textRequest>5__2; // 0x48
	private UnityWebRequest <request>5__3; // 0x50
	private AsyncTextureLoad <request>5__4; // 0x58

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE8F850 Offset: 0xE8EC50 VA: 0x180E8F850 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE90470 Offset: 0xE8F870 VA: 0x180E90470 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Skin.<LoadAssets>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7734
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Skin <>4__this; // 0x20
	public ulong workshopId; // 0x28
	public AssetBundle bundle; // 0x30
	public string directory; // 0x38
	private int <i>5__2; // 0x40
	private Material <material>5__3; // 0x48
	private Dictionary.Enumerator<string, string> <>7__wrap3; // 0x50
	private KeyValuePair<string, string> <mat>5__5; // 0x78
	private bool <isDiffuseMap>5__6; // 0x88
	private bool <isNormalMap>5__7; // 0x89
	private bool <isOcclusionMap>5__8; // 0x8A
	private string <textureName>5__9; // 0x90
	private AssetBundleRequest <textureRequest>5__10; // 0x98
	private AsyncTextureLoad <request>5__11; // 0xA0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE8F760 Offset: 0xE8EB60 VA: 0x180E8F760 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE8E680 Offset: 0xE8DA80 VA: 0x180E8E680 Slot: 6
	private bool MoveNext() { }

	// RVA: 0xE8F810 Offset: 0xE8EC10 VA: 0x180E8F810
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE8F710 Offset: 0xE8EB10 VA: 0x180E8F710 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

