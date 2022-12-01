public class SEScreenSpaceShadows : MonoBehaviour // TypeDefIndex: 13329
{
	private CommandBuffer blendShadowsCommandBuffer;
	private CommandBuffer renderShadowsCommandBuffer;
	private Camera attachedCamera;
	public Light sun;
	[RangeAttribute]
	public float blendStrength;
	[RangeAttribute]
	public float accumulation;
	[RangeAttribute]
	public float lengthFade;
	[RangeAttribute]
	public float range;
	[RangeAttribute]
	public float zThickness;
	[RangeAttribute]
	public int samples;
	[RangeAttribute]
	public float nearSampleQuality;
	[RangeAttribute]
	public float traceBias;
	public bool stochasticSampling;
	public bool leverageTemporalAA;
	public bool bilateralBlur;
	[RangeAttribute]
	public int blurPasses;
	[RangeAttribute]
	public float blurDepthTolerance;
	private Material material;
	private object initChecker;
	private bool sunInitialized;
	private int temporalJitterCounter;
	private bool previousBilateralBlurSetting;
	private int previousBlurPassesSetting;
	private Texture2D noBlendTex;


	private void AddCommandBufferClean(Light light, CommandBuffer commandBuffer, LightEvent lightEvent) { }

	private void AddCommandBufferClean(Camera camera, CommandBuffer commandBuffer, CameraEvent cameraEvent) { }

	private void RemoveCommandBuffer(Light light, CommandBuffer commandBuffer, LightEvent lightEvent) { }

	private void RemoveCommandBuffer(Camera camera, CommandBuffer commandBuffer, CameraEvent cameraEvent) { }

	private void RemoveCommandBuffers() { }

	public bool GetCompatibleRenderPath() { }

	private void Init() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void OnPreRender() { }

	private void OnPostRender() { }

	public void .ctor() { }

}

