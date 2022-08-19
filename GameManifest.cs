public class GameManifest : ScriptableObject // TypeDefIndex: 10723
{	// Fields
	internal static GameManifest loadedManifest; // 0x0
	internal static Dictionary<string, string> guidToPath; // 0x8
	internal static Dictionary<string, string> pathToGuid; // 0x10
	internal static Dictionary<string, Object> guidToObject; // 0x18
	public GameManifest.PooledString[] pooledStrings; // 0x18
	public GameManifest.PrefabProperties[] prefabProperties; // 0x20
	public GameManifest.EffectCategory[] effectCategories; // 0x28
	public GameManifest.GuidPath[] guidPaths; // 0x30
	public string[] entities; // 0x38

	// Properties
	public static GameManifest Current { get; }

	// Methods

	// RVA: 0x6F56B0 Offset: 0x6F4AB0 VA: 0x1806F56B0
	public static GameManifest get_Current() { }

	// RVA: 0x6F51B0 Offset: 0x6F45B0 VA: 0x1806F51B0
	public static void Load() { }

	// RVA: 0x6F4E00 Offset: 0x6F4200 VA: 0x1806F4E00
	public static void LoadAssets() { }

	// RVA: 0x6F5090 Offset: 0x6F4490 VA: 0x1806F5090
	internal static Dictionary<string, string[]> LoadEffectDictionary() { }

	// RVA: 0x6F46D0 Offset: 0x6F3AD0 VA: 0x1806F46D0
	internal static string GUIDToPath(string guid) { }

	// RVA: 0x6F43D0 Offset: 0x6F37D0 VA: 0x1806F43D0
	internal static Object GUIDToObject(string guid) { }

	// RVA: 0x6F4C60 Offset: 0x6F4060 VA: 0x1806F4C60
	internal static void Invalidate(string path) { }

	// RVA: 0x6F4960 Offset: 0x6F3D60 VA: 0x1806F4960
	private static string GetMetadataStatus() { }

	// RVA: 0x6F4800 Offset: 0x6F3C00 VA: 0x1806F4800
	private static string GetAssetStatus() { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

	// RVA: 0x6F5550 Offset: 0x6F4950 VA: 0x1806F5550
	private static void .cctor() { }

}

public struct GameManifest.PooledString // TypeDefIndex: 10724
{	// Fields
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string str; // 0x0
	public uint hash; // 0x8

}

public class GameManifest.PrefabProperties // TypeDefIndex: 10725
{	// Fields
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string name; // 0x10
	public string guid; // 0x18
	public uint hash; // 0x20
	public bool pool; // 0x24

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class GameManifest.EffectCategory // TypeDefIndex: 10726
{	// Fields
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string folder; // 0x10
	public List<string> prefabs; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class GameManifest.GuidPath // TypeDefIndex: 10727
{	// Fields
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string name; // 0x10
	public string guid; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

