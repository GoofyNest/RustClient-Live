public class SpawnFilter // TypeDefIndex: 12025
{
	[InspectorFlagsAttribute] 
	public TerrainSplat.Enum SplatType; 
	[InspectorFlagsAttribute] 
	public TerrainBiome.Enum BiomeType; 
	[InspectorFlagsAttribute] 
	public TerrainTopology.Enum TopologyAny; 
	[InspectorFlagsAttribute] 
	public TerrainTopology.Enum TopologyAll; 
	[InspectorFlagsAttribute] 
	public TerrainTopology.Enum TopologyNot; 


	public bool Test(Vector3 worldPos) { }

	public bool Test(float normX, float normZ) { }

	public float GetFactor(Vector3 worldPos, bool checkPlacementMap = True) { }

	public float GetFactor(float normX, float normZ, bool checkPlacementMap = True) { }

	public void .ctor() { }

}

