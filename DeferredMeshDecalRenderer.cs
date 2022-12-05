public class DeferredMeshDecalRenderer : MonoBehaviour // TypeDefIndex: 12429
{
	private Camera targetCamera;
	private const string commandBufferName = "DeferredMeshDecals";
	private CameraEvent commandBufferEvent;
	private CommandBuffer commandBuffer;
	private RenderTargetIdentifier[] targets;
	private Material multiCopyMat;
	private MaterialPropertyBlock block;
	private static HashSet<DeferredMeshDecal> registered;
	private static HashSet<DeferredMeshDecal> visible;
	private static Dictionary<DeferredMeshDecal.InstanceData, SimpleList<Matrix4x4>> batches;

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

