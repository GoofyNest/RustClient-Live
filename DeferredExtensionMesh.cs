public class DeferredExtensionMesh : MonoBehaviour // TypeDefIndex: 12389
{
	public SubsurfaceProfile subsurfaceProfile; 
	private bool isVisible; 
	private List<DeferredExtensionMesh.MaterialLink> materialLinks; 
	private MaterialPropertyBlock _block; 
	private Renderer _renderer; 

	private MaterialPropertyBlock block { get; }
	private Renderer renderer { get; }


	private MaterialPropertyBlock get_block() { }

	private Renderer get_renderer() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void UpdatePropertyBlock() { }

	private void OnBecameVisible() { }

	private void OnBecameInvisible() { }

	private void CleanupMaterials() { }

	private void PrepareMaterials(Material[] mats) { }

	public void AddToCommandBuffer(CommandBuffer cb) { }

	public void .ctor() { }

}

public struct DeferredExtensionMesh.MaterialLink // TypeDefIndex: 12390
{
	public Material material; 
	public int submeshIndex; 
	public int passIndex; 


	public void .ctor(Material material, int submeshIndex, int passIndex) { }

}

