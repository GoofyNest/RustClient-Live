public class GameManifest : ScriptableObject // TypeDefIndex: 10723
{	internal static GameManifest loadedManifest; // 0x0
	internal static Dictionary<string, string> guidToPath; // 0x8
	internal static Dictionary<string, string> pathToGuid; // 0x10
	internal static Dictionary<string, Object> guidToObject; // 0x18
	public GameManifest.PooledString[] pooledStrings; // 0x18
	public GameManifest.PrefabProperties[] prefabProperties; // 0x20
	public GameManifest.EffectCategory[] effectCategories; // 0x28
	public GameManifest.GuidPath[] guidPaths; // 0x30
	public string[] entities; // 0x38

	public static GameManifest Current { get; }


	public static GameManifest get_Current() { }

	public static void Load() { }

	public static void LoadAssets() { }

	internal static Dictionary<string, string[]> LoadEffectDictionary() { }

	internal static string GUIDToPath(string guid) { }

	internal static Object GUIDToObject(string guid) { }

	internal static void Invalidate(string path) { }

	private static string GetMetadataStatus() { }

	private static string GetAssetStatus() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct GameManifest.PooledString // TypeDefIndex: 10724
{	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string str; // 0x0
	public uint hash; // 0x8

}

public class GameManifest.PrefabProperties // TypeDefIndex: 10725
{	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string name; // 0x10
	public string guid; // 0x18
	public uint hash; // 0x20
	public bool pool; // 0x24


	public void .ctor() { }

}

public class GameManifest.EffectCategory // TypeDefIndex: 10726
{	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string folder; // 0x10
	public List<string> prefabs; // 0x18


	public void .ctor() { }

}

public class GameManifest.GuidPath // TypeDefIndex: 10727
{	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string name; // 0x10
	public string guid; // 0x18


	public void .ctor() { }

}

