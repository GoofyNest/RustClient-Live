public class ContrastStretch : MonoBehaviour // TypeDefIndex: 8193
{
	public float adaptationSpeed; 
	public float limitMinimum; 
	public float limitMaximum; 
	private RenderTexture[] adaptRenderTex; 
	private int curAdaptIndex; 
	public Shader shaderLum; 
	private Material m_materialLum; 
	public Shader shaderReduce; 
	private Material m_materialReduce; 
	public Shader shaderAdapt; 
	private Material m_materialAdapt; 
	public Shader shaderApply; 
	private Material m_materialApply; 

	protected Material materialLum { get; }
	protected Material materialReduce { get; }
	protected Material materialAdapt { get; }
	protected Material materialApply { get; }


	protected Material get_materialLum() { }

	protected Material get_materialReduce() { }

	protected Material get_materialAdapt() { }

	protected Material get_materialApply() { }

	private void Start() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void CalculateAdaptation(Texture curTexture) { }

	public void .ctor() { }

}

