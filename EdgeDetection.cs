public class EdgeDetection : PostEffectsBase // TypeDefIndex: 8186
{	// Fields
	public EdgeDetection.EdgeDetectMode mode; // 0x28
	public float sensitivityDepth; // 0x2C
	public float sensitivityNormals; // 0x30
	public float lumThreshold; // 0x34
	public float edgeExp; // 0x38
	public float sampleDist; // 0x3C
	public float edgesOnly; // 0x40
	public Color edgesOnlyBgColor; // 0x44
	public Shader edgeDetectShader; // 0x58
	private Material edgeDetectMaterial; // 0x60
	private EdgeDetection.EdgeDetectMode oldMode; // 0x68

	// Methods

	// RVA: 0x21DA2D0 Offset: 0x21D96D0 VA: 0x1821DA2D0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21DA650 Offset: 0x21D9A50 VA: 0x1821DA650
	private void Start() { }

	// RVA: 0x21DA5A0 Offset: 0x21D99A0 VA: 0x1821DA5A0
	private void SetCameraFlag() { }

	// RVA: 0x21DA350 Offset: 0x21D9750 VA: 0x1821DA350
	private void OnEnable() { }

	[ImageEffectOpaque] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21DA360 Offset: 0x21D9760 VA: 0x1821DA360
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DA660 Offset: 0x21D9A60 VA: 0x1821DA660
	public void .ctor() { }

}

public enum EdgeDetection.EdgeDetectMode // TypeDefIndex: 8187
{	// Fields
	public int value__; // 0x0
	public const EdgeDetection.EdgeDetectMode TriangleDepthNormals = 0;
	public const EdgeDetection.EdgeDetectMode RobertsCrossDepthNormals = 1;
	public const EdgeDetection.EdgeDetectMode SobelDepth = 2;
	public const EdgeDetection.EdgeDetectMode SobelDepthThin = 3;
	public const EdgeDetection.EdgeDetectMode TriangleLuminance = 4;

}

