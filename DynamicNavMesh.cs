public class DynamicNavMesh : SingletonComponent<DynamicNavMesh>, IServerComponent // TypeDefIndex: 8957
{
	public int NavMeshAgentTypeIndex; 
	[TooltipAttribute] 
	public string DefaultAreaName; 
	public int AsyncTerrainNavMeshBakeCellSize; 
	public int AsyncTerrainNavMeshBakeCellHeight; 
	public Bounds Bounds; 
	public NavMeshData NavMeshData; 
	public NavMeshDataInstance NavMeshDataInstance; 
	public LayerMask LayerMask; 
	public NavMeshCollectGeometry NavMeshCollectGeometry; 


	public void .ctor() { }

}

