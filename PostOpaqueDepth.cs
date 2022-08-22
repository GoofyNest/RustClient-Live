public class PostOpaqueDepth : MonoBehaviour // TypeDefIndex: 10688
{	public RenderTexture postOpaqueDepth; // 0x18
	private Camera camera; // 0x20
	private CommandBufferManager commandBufferManager; // 0x28
	private CommandBufferDesc commandBufferDesc; // 0x30
	private Material copyDepthMat; // 0x38
	public RenderTexture cameraDepth; // 0x40

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

