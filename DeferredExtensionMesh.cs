public class DeferredExtensionMesh : MonoBehaviour // TypeDefIndex: 10658
{	// Fields
	public SubsurfaceProfile subsurfaceProfile; // 0x18
	private bool isVisible; // 0x20
	private List<DeferredExtensionMesh.MaterialLink> materialLinks; // 0x28
	private MaterialPropertyBlock _block; // 0x30
	private Renderer _renderer; // 0x38

	// Properties
	private MaterialPropertyBlock block { get; }
	private Renderer renderer { get; }

	// Methods

	// RVA: 0x8EE370 Offset: 0x8ED770 VA: 0x1808EE370
	private MaterialPropertyBlock get_block() { }

	// RVA: 0x8EE3E0 Offset: 0x8ED7E0 VA: 0x1808EE3E0
	private Renderer get_renderer() { }

	// RVA: 0x8EDE20 Offset: 0x8ED220 VA: 0x1808EDE20
	private void OnEnable() { }

	// RVA: 0x8EDCF0 Offset: 0x8ED0F0 VA: 0x1808EDCF0
	private void OnDisable() { }

	// RVA: 0x8EE1E0 Offset: 0x8ED5E0 VA: 0x1808EE1E0
	public void UpdatePropertyBlock() { }

	// RVA: 0x8EDC10 Offset: 0x8ED010 VA: 0x1808EDC10
	private void OnBecameVisible() { }

	// RVA: 0x8EDB40 Offset: 0x8ECF40 VA: 0x1808EDB40
	private void OnBecameInvisible() { }

	// RVA: 0x8EDAF0 Offset: 0x8ECEF0 VA: 0x1808EDAF0
	private void CleanupMaterials() { }

	// RVA: 0x8EE020 Offset: 0x8ED420 VA: 0x1808EE020
	private void PrepareMaterials(Material[] mats) { }

	// RVA: 0x8ED980 Offset: 0x8ECD80 VA: 0x1808ED980
	public void AddToCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x8EE300 Offset: 0x8ED700 VA: 0x1808EE300
	public void .ctor() { }

}

public struct DeferredExtensionMesh.MaterialLink // TypeDefIndex: 10659
{	// Fields
	public Material material; // 0x0
	public int submeshIndex; // 0x8
	public int passIndex; // 0xC

	// Methods

	// RVA: 0xF9C90 Offset: 0xF9090 VA: 0x1800F9C90
	public void .ctor(Material material, int submeshIndex, int passIndex) { }

}

