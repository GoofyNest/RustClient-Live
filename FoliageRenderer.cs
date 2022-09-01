public class FoliageRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 9883
{
	public Material material; 
	public Mesh LOD0; 
	public Mesh LOD1; 
	private FoliageGroup batchGroup; 
	private MeshInstance batchInstance; 


	protected void OnEnable() { }

	protected void OnDisable() { }

	public void Add() { }

	public void Remove() { }

	public void Refresh() { }

	public void AddBatch(FoliageGroup batchGroup, float lod, uint seed) { }

	public void .ctor() { }

}

