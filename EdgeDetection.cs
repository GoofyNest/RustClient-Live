public class EdgeDetection : PostEffectsBase // TypeDefIndex: 8195
{
	public EdgeDetection.EdgeDetectMode mode; 
	public float sensitivityDepth; 
	public float sensitivityNormals; 
	public float lumThreshold; 
	public float edgeExp; 
	public float sampleDist; 
	public float edgesOnly; 
	public Color edgesOnlyBgColor; 
	public Shader edgeDetectShader; 
	private Material edgeDetectMaterial; 
	private EdgeDetection.EdgeDetectMode oldMode; 


	public override bool CheckResources() { }

	private void Start() { }

	private void SetCameraFlag() { }

	private void OnEnable() { }

	[ImageEffectOpaque] 
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum EdgeDetection.EdgeDetectMode // TypeDefIndex: 8196
{
	public int value__; 
	public const EdgeDetection.EdgeDetectMode TriangleDepthNormals = 0;
	public const EdgeDetection.EdgeDetectMode RobertsCrossDepthNormals = 1;
	public const EdgeDetection.EdgeDetectMode SobelDepth = 2;
	public const EdgeDetection.EdgeDetectMode SobelDepthThin = 3;
	public const EdgeDetection.EdgeDetectMode TriangleLuminance = 4;

}

