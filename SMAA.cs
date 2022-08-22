public class SMAA : MonoBehaviour // TypeDefIndex: 11562
{	public DebugPass DebugPass; // 0x18
	public QualityPreset Quality; // 0x1C
	public EdgeDetectionMethod DetectionMethod; // 0x20
	public bool UsePredication; // 0x24
	public Preset CustomPreset; // 0x28
	public PredicationPreset CustomPredicationPreset; // 0x30
	public Shader Shader; // 0x38
	public Texture2D AreaTex; // 0x40
	public Texture2D SearchTex; // 0x48
	protected Camera m_Camera; // 0x50
	protected Preset m_LowPreset; // 0x58
	protected Preset m_MediumPreset; // 0x60
	protected Preset m_HighPreset; // 0x68
	protected Preset m_UltraPreset; // 0x70
	protected Material m_Material; // 0x78

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

