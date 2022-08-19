public class SMAA : MonoBehaviour // TypeDefIndex: 11562
{	// Fields
	public DebugPass DebugPass; // 0x18
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

	// Properties
	public Material Material { get; }

	// Methods

	// RVA: 0x5BF340 Offset: 0x5BE740 VA: 0x1805BF340
	public Material get_Material() { }

	// RVA: 0x5BEB30 Offset: 0x5BDF30 VA: 0x1805BEB30
	private void OnEnable() { }

	// RVA: 0x5BF230 Offset: 0x5BE630 VA: 0x1805BF230
	private void Start() { }

	// RVA: 0x5BEA90 Offset: 0x5BDE90 VA: 0x1805BEA90
	private void OnDisable() { }

	// RVA: 0x5BEC40 Offset: 0x5BE040 VA: 0x1805BEC40
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x5BE7D0 Offset: 0x5BDBD0 VA: 0x1805BE7D0
	private void Clear(RenderTexture rt) { }

	// RVA: 0x5BF2F0 Offset: 0x5BE6F0 VA: 0x1805BF2F0
	private RenderTexture TempRT(int width, int height) { }

	// RVA: 0x5BE850 Offset: 0x5BDC50 VA: 0x1805BE850
	private void CreatePresets() { }

	// RVA: 0x5BF320 Offset: 0x5BE720 VA: 0x1805BF320
	public void .ctor() { }

}

