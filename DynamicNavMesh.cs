public class DynamicNavMesh : SingletonComponent<DynamicNavMesh>, IServerComponent // TypeDefIndex: 8957
{	public int NavMeshAgentTypeIndex; // 0x18
	[TooltipAttribute] // RVA: 0xC6D40 Offset: 0xC6140 VA: 0x1800C6D40
	public string DefaultAreaName; // 0x20
	public int AsyncTerrainNavMeshBakeCellSize; // 0x28
	public int AsyncTerrainNavMeshBakeCellHeight; // 0x2C
	public Bounds Bounds; // 0x30
	public NavMeshData NavMeshData; // 0x48
	public NavMeshDataInstance NavMeshDataInstance; // 0x50
	public LayerMask LayerMask; // 0x54
	public NavMeshCollectGeometry NavMeshCollectGeometry; // 0x58


	public void .ctor() { }

}

