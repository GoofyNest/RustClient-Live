public sealed class Terrain : Behaviour // TypeDefIndex: 4088
{
// Namespace: UnityEngine
[RequireComponent] // RVA: 0x73BA0 Offset: 0x72FA0 VA: 0x180073BA0
[RequiredByNativeCodeAttribute] // RVA: 0x73BA0 Offset: 0x72FA0 VA: 0x180073BA0
[NativeHeaderAttribute] // RVA: 0x73BA0 Offset: 0x72FA0 VA: 0x180073BA0
public class Collider2D : Behaviour // TypeDefIndex: 4086

// Namespace: 
internal class <Module> // TypeDefIndex: 4087

// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x79E30 Offset: 0x79230 VA: 0x180079E30
[UsedByNativeCodeAttribute] // RVA: 0x79E30 Offset: 0x79230 VA: 0x180079E30
[StaticAccessorAttribute] // RVA: 0x79E30 Offset: 0x79230 VA: 0x180079E30
[NativeHeaderAttribute] // RVA: 0x79E30 Offset: 0x79230 VA: 0x180079E30
[NativeHeaderAttribute] // RVA: 0x79E30 Offset: 0x79230 VA: 0x180079E30
public sealed class Terrain : Behaviour // TypeDefIndex: 4088
	// Properties
	public TerrainData terrainData { get; }
	public float heightmapPixelError { set; }
	public float basemapDistance { set; }
	public ShadowCastingMode shadowCastingMode { set; }
	public ReflectionProbeUsage reflectionProbeUsage { get; set; }
	public Material materialTemplate { get; set; }
	public bool drawHeightmap { get; set; }
	public bool allowAutoConnect { get; }
	public int groupingID { get; }
	public bool drawInstanced { set; }
	public bool drawTreesAndFoliage { get; set; }
	public static Terrain activeTerrain { get; }
	[NativePropertyAttribute] // RVA: 0x7A4D0 Offset: 0x798D0 VA: 0x18007A4D0
	public static Terrain[] activeTerrains { get; }
	[ObsoleteAttribute] // RVA: 0x7A600 Offset: 0x79A00 VA: 0x18007A600
	public bool castShadows { set; }
	[ObsoleteAttribute] // RVA: 0x7A750 Offset: 0x79B50 VA: 0x18007A750
	public Terrain.MaterialType materialType { set; }

	// Methods

	// RVA: 0x22BDC20 Offset: 0x22BD020 VA: 0x1822BDC20
	public TerrainData get_terrainData() { }

	// RVA: 0x22BDDF0 Offset: 0x22BD1F0 VA: 0x1822BDDF0
	public void set_heightmapPixelError(float value) { }

	// RVA: 0x22BDC60 Offset: 0x22BD060 VA: 0x1822BDC60
	public void set_basemapDistance(float value) { }

	// RVA: 0x22BDED0 Offset: 0x22BD2D0 VA: 0x1822BDED0
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x22BDBE0 Offset: 0x22BCFE0 VA: 0x1822BDBE0
	public ReflectionProbeUsage get_reflectionProbeUsage() { }

	// RVA: 0x22BDE90 Offset: 0x22BD290 VA: 0x1822BDE90
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x22BDBA0 Offset: 0x22BCFA0 VA: 0x1822BDBA0
	public Material get_materialTemplate() { }

	// RVA: 0x22BDE40 Offset: 0x22BD240 VA: 0x1822BDE40
	public void set_materialTemplate(Material value) { }

	// RVA: 0x22BDAE0 Offset: 0x22BCEE0 VA: 0x1822BDAE0
	public bool get_drawHeightmap() { }

	// RVA: 0x22BDD00 Offset: 0x22BD100 VA: 0x1822BDD00
	public void set_drawHeightmap(bool value) { }

	// RVA: 0x22BDAA0 Offset: 0x22BCEA0 VA: 0x1822BDAA0
	public bool get_allowAutoConnect() { }

	// RVA: 0x22BDB60 Offset: 0x22BCF60 VA: 0x1822BDB60
	public int get_groupingID() { }

	// RVA: 0x22BDD50 Offset: 0x22BD150 VA: 0x1822BDD50
	public void set_drawInstanced(bool value) { }

	// RVA: 0x22BDB20 Offset: 0x22BCF20 VA: 0x1822BDB20
	public bool get_drawTreesAndFoliage() { }

	// RVA: 0x22BDDA0 Offset: 0x22BD1A0 VA: 0x1822BDDA0
	public void set_drawTreesAndFoliage(bool value) { }

	// RVA: 0x22BD980 Offset: 0x22BCD80 VA: 0x1822BD980
	public float SampleHeight(Vector3 worldPosition) { }

	// RVA: 0x22BD9D0 Offset: 0x22BCDD0 VA: 0x1822BD9D0
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	// RVA: 0x22BD8E0 Offset: 0x22BCCE0 VA: 0x1822BD8E0
	public Vector3 GetPosition() { }

	// RVA: 0x22BD850 Offset: 0x22BCC50 VA: 0x1822BD850
	public void Flush() { }

	// RVA: 0x22BDA40 Offset: 0x22BCE40 VA: 0x1822BDA40
	public static Terrain get_activeTerrain() { }

	// RVA: 0x22BDA70 Offset: 0x22BCE70 VA: 0x1822BDA70
	public static Terrain[] get_activeTerrains() { }

	[UsedByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22BD810 Offset: 0x22BCC10 VA: 0x1822BD810
	public static GameObject CreateTerrainGameObject(TerrainData assignTerrain) { }

	// RVA: 0x22BDCB0 Offset: 0x22BD0B0 VA: 0x1822BDCB0
	public void set_castShadows(bool value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void set_materialType(Terrain.MaterialType value) { }

	// RVA: 0x18F27E0 Offset: 0x18F1BE0 VA: 0x1818F27E0
	public void .ctor() { }

	// RVA: 0x22BD930 Offset: 0x22BCD30 VA: 0x1822BD930
	private float SampleHeight_Injected(ref Vector3 worldPosition) { }

	// RVA: 0x22BD890 Offset: 0x22BCC90 VA: 0x1822BD890
	private void GetPosition_Injected(out Vector3 ret) { }

}

public enum Terrain.MaterialType // TypeDefIndex: 4089
{	// Fields
	public int value__; // 0x0
	public const Terrain.MaterialType BuiltInStandard = 0;
	public const Terrain.MaterialType BuiltInLegacyDiffuse = 1;
	public const Terrain.MaterialType BuiltInLegacySpecular = 2;
	public const Terrain.MaterialType Custom = 3;

}

public class Terrain : ConsoleSystem // TypeDefIndex: 11963
{	// Fields
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float quality; // 0x1F840

	// Methods

	// RVA: 0x36A570 Offset: 0x369970 VA: 0x18036A570
	public void .ctor() { }

	// RVA: 0x36A530 Offset: 0x369930 VA: 0x18036A530
	private static void .cctor() { }

}

