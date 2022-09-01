public class GameManifest : ScriptableObject // TypeDefIndex: 10734
{
	internal static GameManifest loadedManifest; 
	internal static Dictionary<string, string> guidToPath; 
	internal static Dictionary<string, string> pathToGuid; 
	internal static Dictionary<string, Object> guidToObject; 
	public GameManifest.PooledString[] pooledStrings; 
	public GameManifest.PrefabProperties[] prefabProperties; 
	public GameManifest.EffectCategory[] effectCategories; 
	public GameManifest.GuidPath[] guidPaths; 
	public string[] entities; 

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

public struct GameManifest.PooledString // TypeDefIndex: 10735
{
	[HideInInspector] 
	public string str; 
	public uint hash; 

}

public class GameManifest.PrefabProperties // TypeDefIndex: 10736
{
	[HideInInspector] 
	public string name; 
	public string guid; 
	public uint hash; 
	public bool pool; 


	public void .ctor() { }

}

public class GameManifest.EffectCategory // TypeDefIndex: 10737
{
	[HideInInspector] 
	public string folder; 
	public List<string> prefabs; 


	public void .ctor() { }

}

public class GameManifest.GuidPath // TypeDefIndex: 10738
{
	[HideInInspector] 
	public string name; 
	public string guid; 


	public void .ctor() { }

}

