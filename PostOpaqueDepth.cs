public class PostOpaqueDepth : MonoBehaviour // TypeDefIndex: 10688
{	// Fields
	public RenderTexture postOpaqueDepth; // 0x18
	private Camera camera; // 0x20
	private CommandBufferManager commandBufferManager; // 0x28
	private CommandBufferDesc commandBufferDesc; // 0x30
	private Material copyDepthMat; // 0x38
	public RenderTexture cameraDepth; // 0x40

	// Properties
	public RenderTexture PostOpaque { get; }
	public Material CopyDepthMat { get; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public RenderTexture get_PostOpaque() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public Material get_CopyDepthMat() { }

	// RVA: 0x97C0F0 Offset: 0x97B4F0 VA: 0x18097C0F0
	private void OnEnable() { }

	// RVA: 0x97BF40 Offset: 0x97B340 VA: 0x18097BF40
	private void OnDisable() { }

	// RVA: 0x97B890 Offset: 0x97AC90 VA: 0x18097B890
	private void CheckCommandBuffer() { }

	// RVA: 0x97BA10 Offset: 0x97AE10 VA: 0x18097BA10
	private void CleanupCommandBuffer() { }

	// RVA: 0x97BAD0 Offset: 0x97AED0 VA: 0x18097BAD0
	private void CreateMaterial() { }

	// RVA: 0x97BB70 Offset: 0x97AF70 VA: 0x18097BB70
	private void DestroyMaterial() { }

	// RVA: 0x97BC20 Offset: 0x97B020 VA: 0x18097BC20
	private void DestroyRenderTextures() { }

	// RVA: 0x97B510 Offset: 0x97A910 VA: 0x18097B510
	private bool CheckBindRenderTextures() { }

	// RVA: 0x97BD70 Offset: 0x97B170 VA: 0x18097BD70
	private void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x97C1D0 Offset: 0x97B5D0 VA: 0x18097C1D0
	public void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

