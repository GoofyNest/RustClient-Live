public class MonumentNavMesh : FacepunchBehaviour, IServerComponent // TypeDefIndex: 8958
{	public int NavMeshAgentTypeIndex; // 0x18
	[TooltipAttribute] // RVA: 0xC6D40 Offset: 0xC6140 VA: 0x1800C6D40
	public string DefaultAreaName; // 0x20
	[TooltipAttribute] // RVA: 0xC86C0 Offset: 0xC7AC0 VA: 0x1800C86C0
	public int CellCount; // 0x28
	[TooltipAttribute] // RVA: 0xC87B0 Offset: 0xC7BB0 VA: 0x1800C87B0
	public int CellSize; // 0x2C
	public int Height; // 0x30
	public float NavmeshResolutionModifier; // 0x34
	[TooltipAttribute] // RVA: 0xC8880 Offset: 0xC7C80 VA: 0x1800C8880
	public bool overrideAutoBounds; // 0x38
	[TooltipAttribute] // RVA: 0xC6DE0 Offset: 0xC61E0 VA: 0x1800C6DE0
	public Bounds Bounds; // 0x3C
	public NavMeshData NavMeshData; // 0x58
	public NavMeshDataInstance NavMeshDataInstance; // 0x60
	public LayerMask LayerMask; // 0x64
	public NavMeshCollectGeometry NavMeshCollectGeometry; // 0x68
	public bool forceCollectTerrain; // 0x6C
	public Transform CustomNavMeshRoot; // 0x70


	public void .ctor() { }

}

