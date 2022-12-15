public class MonumentNavMesh : FacepunchBehaviour, IServerComponent // TypeDefIndex: 10695
{
	public int NavMeshAgentTypeIndex;
	[TooltipAttribute]
	public string DefaultAreaName;
	[TooltipAttribute]
	public int CellCount;
	[TooltipAttribute]
	public int CellSize;
	public int Height;
	public float NavmeshResolutionModifier;
	[TooltipAttribute]
	public bool overrideAutoBounds;
	[TooltipAttribute]
	public Bounds Bounds;
	public NavMeshData NavMeshData;
	public NavMeshDataInstance NavMeshDataInstance;
	public LayerMask LayerMask;
	public NavMeshCollectGeometry NavMeshCollectGeometry;
	public bool forceCollectTerrain;
	public bool shouldNotifyAIZones;
	public Transform CustomNavMeshRoot;


	public void .ctor() { }

}

