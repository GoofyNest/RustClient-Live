public class DeferredMeshDecalRenderer : MonoBehaviour // TypeDefIndex: 10669
{	private Camera targetCamera; // 0x18
	private const string commandBufferName = "DeferredMeshDecals";
	private CameraEvent commandBufferEvent; // 0x20
	private CommandBuffer commandBuffer; // 0x28
	private RenderTargetIdentifier[] targets; // 0x30
	private Material multiCopyMat; // 0x38
	private MaterialPropertyBlock block; // 0x40
	private static HashSet<DeferredMeshDecal> registered; // 0x0
	private static HashSet<DeferredMeshDecal> visible; // 0x8
	private static Dictionary<DeferredMeshDecal.InstanceData, SimpleList<Matrix4x4>> batches; // 0x10

	public Camera TargetCamera { get; }


	public Camera get_TargetCamera() { }

	public static void Register(DeferredMeshDecal decal) { }

	public static void Unregister(DeferredMeshDecal decal) { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void CreateCommandBuffer() { }

	private void CleanupCommandBuffer() { }

	private void CreateMaterials() { }

	private void CleanupMaterials() { }

	public static void BecameVisible(DeferredMeshDecal decal) { }

	public static void BecameInvisible(DeferredMeshDecal decal) { }

	private void CleanupBatches() { }

	private void UpdateBatches() { }

	public void FillCommandBuffer(CommandBuffer cb) { }

	private void OnPreRender() { }

	public void .ctor() { }

	private static void .cctor() { }

}

