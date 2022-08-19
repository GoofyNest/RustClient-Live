public class TerrainAtlasSet : ScriptableObject // TypeDefIndex: 10381
{	// Fields
	public const int SplatCount = 8;
	public const int SplatSize = 2048;
	public const int MaxSplatSize = 2047;
	public const int SplatPadding = 256;
	public const int AtlasSize = 8192;
	public const int RegionSize = 2560;
	public const int SplatsPerLine = 3;
	public const int SourceTypeCount = 3;
	public const int AtlasMipCount = 10;
	public static string[] sourceTypeNames; // 0x0
	public static string[] sourceTypeNamesExt; // 0x8
	public static string[] sourceTypePostfix; // 0x10
	public string[] splatNames; // 0x18
	public bool[] albedoHighpass; // 0x20
	public string[] albedoPaths; // 0x28
	public Color[] defaultValues; // 0x30
	public TerrainAtlasSet.SourceMapSet[] sourceMaps; // 0x38
	public bool highQualityCompression; // 0x40
	public bool generateTextureAtlases; // 0x41
	public bool generateTextureArrays; // 0x42
	public string splatSearchPrefix; // 0x48
	public string splatSearchFolder; // 0x50
	public string albedoAtlasSavePath; // 0x58
	public string normalAtlasSavePath; // 0x60
	public string albedoArraySavePath; // 0x68
	public string normalArraySavePath; // 0x70

	// Methods

	// RVA: 0x1132AF0 Offset: 0x1131EF0 VA: 0x181132AF0
	public void CheckReset() { }

	// RVA: 0x1133650 Offset: 0x1132A50 VA: 0x181133650
	public void .ctor() { }

	// RVA: 0x11331F0 Offset: 0x11325F0 VA: 0x1811331F0
	private static void .cctor() { }

}

public enum TerrainAtlasSet.SourceType // TypeDefIndex: 10382
{	// Fields
	public int value__; // 0x0
	public const TerrainAtlasSet.SourceType ALBEDO = 0;
	public const TerrainAtlasSet.SourceType NORMAL = 1;
	public const TerrainAtlasSet.SourceType PACKED = 2;
	public const TerrainAtlasSet.SourceType COUNT = 3;

}

public class TerrainAtlasSet.SourceMapSet // TypeDefIndex: 10383
{	// Fields
	public Texture2D[] maps; // 0x10

	// Methods

	// RVA: 0x112F7E0 Offset: 0x112EBE0 VA: 0x18112F7E0
	internal void CheckReset() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

