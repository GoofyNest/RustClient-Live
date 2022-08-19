public class SEScreenSpaceShadows : MonoBehaviour // TypeDefIndex: 11522
{	// Fields
	private CommandBuffer blendShadowsCommandBuffer; // 0x18
	private CommandBuffer renderShadowsCommandBuffer; // 0x20
	private Camera attachedCamera; // 0x28
	public Light sun; // 0x30
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float blendStrength; // 0x38
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float accumulation; // 0x3C
	[RangeAttribute] // RVA: 0xB98E0 Offset: 0xB8CE0 VA: 0x1800B98E0
	public float lengthFade; // 0x40
	[RangeAttribute] // RVA: 0xB9A10 Offset: 0xB8E10 VA: 0x1800B9A10
	public float range; // 0x44
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float zThickness; // 0x48
	[RangeAttribute] // RVA: 0xB9B10 Offset: 0xB8F10 VA: 0x1800B9B10
	public int samples; // 0x4C
	[RangeAttribute] // RVA: 0xB9BD0 Offset: 0xB8FD0 VA: 0x1800B9BD0
	public float nearSampleQuality; // 0x50
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float traceBias; // 0x54
	public bool stochasticSampling; // 0x58
	public bool leverageTemporalAA; // 0x59
	public bool bilateralBlur; // 0x5A
	[RangeAttribute] // RVA: 0xA42D0 Offset: 0xA36D0 VA: 0x1800A42D0
	public int blurPasses; // 0x5C
	[RangeAttribute] // RVA: 0xB9CD0 Offset: 0xB90D0 VA: 0x1800B9CD0
	public float blurDepthTolerance; // 0x60
	private Material material; // 0x68
	private object initChecker; // 0x70
	private bool sunInitialized; // 0x78
	private int temporalJitterCounter; // 0x7C
	private bool previousBilateralBlurSetting; // 0x80
	private int previousBlurPassesSetting; // 0x84
	private Texture2D noBlendTex; // 0x88

	// Methods

	// RVA: 0x499390 Offset: 0x498790 VA: 0x180499390
	private void AddCommandBufferClean(Light light, CommandBuffer commandBuffer, LightEvent lightEvent) { }

	// RVA: 0x4992A0 Offset: 0x4986A0 VA: 0x1804992A0
	private void AddCommandBufferClean(Camera camera, CommandBuffer commandBuffer, CameraEvent cameraEvent) { }

	// RVA: 0x49A7A0 Offset: 0x499BA0 VA: 0x18049A7A0
	private void RemoveCommandBuffer(Light light, CommandBuffer commandBuffer, LightEvent lightEvent) { }

	// RVA: 0x49A570 Offset: 0x499970 VA: 0x18049A570
	private void RemoveCommandBuffer(Camera camera, CommandBuffer commandBuffer, CameraEvent cameraEvent) { }

	// RVA: 0x49A9D0 Offset: 0x499DD0 VA: 0x18049A9D0
	private void RemoveCommandBuffers() { }

	// RVA: 0x499480 Offset: 0x498880 VA: 0x180499480
	public bool GetCompatibleRenderPath() { }

	// RVA: 0x499520 Offset: 0x498920 VA: 0x180499520
	private void Init() { }

	// RVA: 0x499EC0 Offset: 0x4992C0 VA: 0x180499EC0
	private void OnEnable() { }

	// RVA: 0x499E90 Offset: 0x499290 VA: 0x180499E90
	private void OnDisable() { }

	// RVA: 0x499F10 Offset: 0x499310 VA: 0x180499F10
	private void OnPreRender() { }

	// RVA: 0x499ED0 Offset: 0x4992D0 VA: 0x180499ED0
	private void OnPostRender() { }

	// RVA: 0x49AA80 Offset: 0x499E80 VA: 0x18049AA80
	public void .ctor() { }

}

