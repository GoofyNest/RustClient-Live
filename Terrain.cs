public sealed class Terrain : Behaviour // TypeDefIndex: 4093
{

[RequireComponent]
[RequiredByNativeCodeAttribute]
[NativeHeaderAttribute]
public class Collider2D : Behaviour

internal class <Module>

[NativeHeaderAttribute]
[UsedByNativeCodeAttribute]
[StaticAccessorAttribute]
[NativeHeaderAttribute]
[NativeHeaderAttribute]
public sealed class Terrain : Behaviour
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
	[NativePropertyAttribute]
	public static Terrain[] activeTerrains { get; }
	[ObsoleteAttribute]
	public bool castShadows { set; }
	[ObsoleteAttribute]
	public Terrain.MaterialType materialType { set; }


	public TerrainData get_terrainData() { }

	public void set_heightmapPixelError(float value) { }

	public void set_basemapDistance(float value) { }

	public void set_shadowCastingMode(ShadowCastingMode value) { }

	public ReflectionProbeUsage get_reflectionProbeUsage() { }

	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	public Material get_materialTemplate() { }

	public void set_materialTemplate(Material value) { }

	public bool get_drawHeightmap() { }

	public void set_drawHeightmap(bool value) { }

	public bool get_allowAutoConnect() { }

	public int get_groupingID() { }

	public void set_drawInstanced(bool value) { }

	public bool get_drawTreesAndFoliage() { }

	public void set_drawTreesAndFoliage(bool value) { }

	public float SampleHeight(Vector3 worldPosition) { }

	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	public Vector3 GetPosition() { }

	public void Flush() { }

	public static Terrain get_activeTerrain() { }

	public static Terrain[] get_activeTerrains() { }

	[UsedByNativeCodeAttribute]
	public static GameObject CreateTerrainGameObject(TerrainData assignTerrain) { }

	public void set_castShadows(bool value) { }

	public void set_materialType(Terrain.MaterialType value) { }

	public void .ctor() { }

	private float SampleHeight_Injected(ref Vector3 worldPosition) { }

	private void GetPosition_Injected(out Vector3 ret) { }

}

public enum Terrain.MaterialType // TypeDefIndex: 4094
{
	public int value__;
	public const Terrain.MaterialType BuiltInStandard = 0;
	public const Terrain.MaterialType BuiltInLegacyDiffuse = 1;
	public const Terrain.MaterialType BuiltInLegacySpecular = 2;
	public const Terrain.MaterialType Custom = 3;

}

public class Terrain : ConsoleSystem // TypeDefIndex: 13782
{
	[ClientVar]
	public static float quality;


	public void .ctor() { }

	private static void .cctor() { }

}

