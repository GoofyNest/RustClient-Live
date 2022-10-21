public class NoiseAndScratches : MonoBehaviour // TypeDefIndex: 8204
{
	public bool monochrome; 
	private bool rgbFallback; 
	public float grainIntensityMin; 
	public float grainIntensityMax; 
	public float grainSize; 
	public float scratchIntensityMin; 
	public float scratchIntensityMax; 
	public float scratchFPS; 
	public float scratchJitter; 
	public Texture grainTexture; 
	public Texture scratchTexture; 
	public Shader shaderRGB; 
	public Shader shaderYUV; 
	private Material m_MaterialRGB; 
	private Material m_MaterialYUV; 
	private float scratchTimeLeft; 
	private float scratchX; 
	private float scratchY; 

	protected Material material { get; }


	protected void Start() { }

	protected Material get_material() { }

	protected void OnDisable() { }

	private void SanitizeParameters() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

