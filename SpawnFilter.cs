public class SpawnFilter // TypeDefIndex: 10308
{	// Fields
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TerrainSplat.Enum SplatType; // 0x10
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TerrainBiome.Enum BiomeType; // 0x14
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TerrainTopology.Enum TopologyAny; // 0x18
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TerrainTopology.Enum TopologyAll; // 0x1C
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TerrainTopology.Enum TopologyNot; // 0x20

	// Methods

	// RVA: 0xA79020 Offset: 0xA78420 VA: 0x180A79020
	public bool Test(Vector3 worldPos) { }

	// RVA: 0xA790A0 Offset: 0xA784A0 VA: 0x180A790A0
	public bool Test(float normX, float normZ) { }

	// RVA: 0xA78FB0 Offset: 0xA783B0 VA: 0x180A78FB0
	public float GetFactor(Vector3 worldPos, bool checkPlacementMap = True) { }

	// RVA: 0xA78C40 Offset: 0xA78040 VA: 0x180A78C40
	public float GetFactor(float normX, float normZ, bool checkPlacementMap = True) { }

	// RVA: 0xA344C0 Offset: 0xA338C0 VA: 0x180A344C0
	public void .ctor() { }

}

