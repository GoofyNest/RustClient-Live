public class LensDirtiness : MonoBehaviour, IImageEffect // TypeDefIndex: 8063
{
	private Shader Shader_Dirtiness; 
	private Material Material_Dirtiness; 
	private RenderTexture RTT_BloomThreshold; 
	private RenderTexture RTT_1; 
	private RenderTexture RTT_2; 
	private RenderTexture RTT_3; 
	private RenderTexture RTT_4; 
	private RenderTexture RTT_Bloom_1; 
	private RenderTexture RTT_Bloom_2; 
	private int ScreenX; 
	private int ScreenY; 
	public bool ShowScreenControls; 
	public bool SceneTintsBloom; 
	public Texture2D DirtinessTexture; 
	public float gain; 
	public float threshold; 
	public float BloomSize; 
	public float Dirtiness; 
	public Color BloomColor; 


private void OnEnable() { }

private void SetKeyword() { }

public bool IsActive() { }

public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

public void .ctor() { }

}

private enum LensDirtiness.Pass // TypeDefIndex: 8064
{
	public int value__; 
public const LensDirtiness.Pass Threshold = 0;
public const LensDirtiness.Pass Kawase = 1;
public const LensDirtiness.Pass Compose = 2;

}

