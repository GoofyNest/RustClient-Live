public class PostOpaqueDepth : MonoBehaviour // TypeDefIndex: 12447
{
	public RenderTexture postOpaqueDepth;
	private Camera camera;
	private CommandBufferManager commandBufferManager;
	private CommandBufferDesc commandBufferDesc;
	private Material copyDepthMat;
	public RenderTexture cameraDepth;

	public RenderTexture PostOpaque { get; }
	public Material CopyDepthMat { get; }


	public RenderTexture get_PostOpaque() { }

	public Material get_CopyDepthMat() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void CheckCommandBuffer() { }

	private void CleanupCommandBuffer() { }

	private void CreateMaterial() { }

	private void DestroyMaterial() { }

	private void DestroyRenderTextures() { }

	private bool CheckBindRenderTextures() { }

	private void FillCommandBuffer(CommandBuffer cb) { }

	public void Update() { }

	public void .ctor() { }

}

