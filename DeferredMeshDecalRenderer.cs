public class DeferredMeshDecalRenderer : MonoBehaviour // TypeDefIndex: 10669
{	// Fields
	private Camera targetCamera; // 0x18
	private const string commandBufferName = "DeferredMeshDecals";
	private CameraEvent commandBufferEvent; // 0x20
	private CommandBuffer commandBuffer; // 0x28
	private RenderTargetIdentifier[] targets; // 0x30
	private Material multiCopyMat; // 0x38
	private MaterialPropertyBlock block; // 0x40
	private static HashSet<DeferredMeshDecal> registered; // 0x0
	private static HashSet<DeferredMeshDecal> visible; // 0x8
	private static Dictionary<DeferredMeshDecal.InstanceData, SimpleList<Matrix4x4>> batches; // 0x10

	// Properties
	public Camera TargetCamera { get; }

	// Methods

	// RVA: 0x8F1C70 Offset: 0x8F1070 VA: 0x1808F1C70
	public Camera get_TargetCamera() { }

	// RVA: 0x8F1610 Offset: 0x8F0A10 VA: 0x1808F1610
	public static void Register(DeferredMeshDecal decal) { }

	// RVA: 0x8F1690 Offset: 0x8F0A90 VA: 0x1808F1690
	public static void Unregister(DeferredMeshDecal decal) { }

	// RVA: 0x8F1450 Offset: 0x8F0850 VA: 0x1808F1450
	private void OnEnable() { }

	// RVA: 0x8F13C0 Offset: 0x8F07C0 VA: 0x1808F13C0
	private void OnDisable() { }

	// RVA: 0x8F0B10 Offset: 0x8EFF10 VA: 0x1808F0B10
	private void CreateCommandBuffer() { }

	// RVA: 0x8F0950 Offset: 0x8EFD50 VA: 0x1808F0950
	private void CleanupCommandBuffer() { }

	// RVA: 0x8F0BC0 Offset: 0x8EFFC0 VA: 0x1808F0BC0
	private void CreateMaterials() { }

	// RVA: 0x8F0A60 Offset: 0x8EFE60 VA: 0x1808F0A60
	private void CleanupMaterials() { }

	// RVA: 0x8F0710 Offset: 0x8EFB10 VA: 0x1808F0710
	public static void BecameVisible(DeferredMeshDecal decal) { }

	// RVA: 0x8F0690 Offset: 0x8EFA90 VA: 0x1808F0690
	public static void BecameInvisible(DeferredMeshDecal decal) { }

	// RVA: 0x8F0790 Offset: 0x8EFB90 VA: 0x1808F0790
	private void CleanupBatches() { }

	// RVA: 0x8F1710 Offset: 0x8F0B10 VA: 0x1808F1710
	private void UpdateBatches() { }

	// RVA: 0x8F0C60 Offset: 0x8F0060 VA: 0x1808F0C60
	public void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x8F1580 Offset: 0x8F0980 VA: 0x1808F1580
	private void OnPreRender() { }

	// RVA: 0x8F1C10 Offset: 0x8F1010 VA: 0x1808F1C10
	public void .ctor() { }

	// RVA: 0x8F1B30 Offset: 0x8F0F30 VA: 0x1808F1B30
	private static void .cctor() { }

}

