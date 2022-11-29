public class TerrainAtlasSet : ScriptableObject // TypeDefIndex: 12132
{
	public const int SplatCount = 8;
	public const int SplatSize = 2048;
	public const int MaxSplatSize = 2047;
	public const int SplatPadding = 256;
	public const int AtlasSize = 8192;
	public const int RegionSize = 2560;
	public const int SplatsPerLine = 3;
	public const int SourceTypeCount = 3;
	public const int AtlasMipCount = 10;
	public static string[] sourceTypeNames; 
	public static string[] sourceTypeNamesExt; 
	public static string[] sourceTypePostfix; 
	public string[] splatNames; 
	public bool[] albedoHighpass; 
	public string[] albedoPaths; 
	public Color[] defaultValues; 
	public TerrainAtlasSet.SourceMapSet[] sourceMaps; 
	public bool highQualityCompression; 
	public bool generateTextureAtlases; 
	public bool generateTextureArrays; 
	public string splatSearchPrefix; 
	public string splatSearchFolder; 
	public string albedoAtlasSavePath; 
	public string normalAtlasSavePath; 
	public string albedoArraySavePath; 
	public string normalArraySavePath; 


	public void CheckReset() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum TerrainAtlasSet.SourceType // TypeDefIndex: 12133
{
	public int value__; 
	public const TerrainAtlasSet.SourceType ALBEDO = 0;
	public const TerrainAtlasSet.SourceType NORMAL = 1;
	public const TerrainAtlasSet.SourceType PACKED = 2;
	public const TerrainAtlasSet.SourceType COUNT = 3;

}

public class TerrainAtlasSet.SourceMapSet // TypeDefIndex: 12134
{
	public Texture2D[] maps; 


	internal void CheckReset() { }

	public void .ctor() { }

}

