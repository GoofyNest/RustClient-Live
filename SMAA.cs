public class SMAA : MonoBehaviour // TypeDefIndex: 13316
{
	public DebugPass DebugPass; 
	public QualityPreset Quality; 
	public EdgeDetectionMethod DetectionMethod; 
	public bool UsePredication; 
	public Preset CustomPreset; 
	public PredicationPreset CustomPredicationPreset; 
	public Shader Shader; 
	public Texture2D AreaTex; 
	public Texture2D SearchTex; 
	protected Camera m_Camera; 
	protected Preset m_LowPreset; 
	protected Preset m_MediumPreset; 
	protected Preset m_HighPreset; 
	protected Preset m_UltraPreset; 
	protected Material m_Material; 

	public Material Material { get; }


	public Material get_Material() { }

	private void OnEnable() { }

	private void Start() { }

	private void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Clear(RenderTexture rt) { }

	private RenderTexture TempRT(int width, int height) { }

	private void CreatePresets() { }

	public void .ctor() { }

}

