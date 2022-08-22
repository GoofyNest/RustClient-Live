public class DeferredExtensionMesh : MonoBehaviour // TypeDefIndex: 10658
{	public SubsurfaceProfile subsurfaceProfile; // 0x18
	private bool isVisible; // 0x20
	private List<DeferredExtensionMesh.MaterialLink> materialLinks; // 0x28
	private MaterialPropertyBlock _block; // 0x30
	private Renderer _renderer; // 0x38

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

public struct DeferredExtensionMesh.MaterialLink // TypeDefIndex: 10659
{	public Material material; // 0x0
	public int submeshIndex; // 0x8
	public int passIndex; // 0xC


	public void .ctor(Material material, int submeshIndex, int passIndex) { }

}

