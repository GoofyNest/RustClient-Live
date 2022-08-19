public class ContrastStretch : MonoBehaviour // TypeDefIndex: 8175
{	// Fields
	public float adaptationSpeed; // 0x18
	public float limitMinimum; // 0x1C
	public float limitMaximum; // 0x20
	private RenderTexture[] adaptRenderTex; // 0x28
	private int curAdaptIndex; // 0x30
	public Shader shaderLum; // 0x38
	private Material m_materialLum; // 0x40
	public Shader shaderReduce; // 0x48
	private Material m_materialReduce; // 0x50
	public Shader shaderAdapt; // 0x58
	private Material m_materialAdapt; // 0x60
	public Shader shaderApply; // 0x68
	private Material m_materialApply; // 0x70

	// Properties
	protected Material materialLum { get; }
	protected Material materialReduce { get; }
	protected Material materialAdapt { get; }
	protected Material materialApply { get; }

	// Methods

	// RVA: 0x21D4CD0 Offset: 0x21D40D0 VA: 0x1821D4CD0
	protected Material get_materialLum() { }

	// RVA: 0x21D4D90 Offset: 0x21D4190 VA: 0x1821D4D90
	protected Material get_materialReduce() { }

	// RVA: 0x21D4B50 Offset: 0x21D3F50 VA: 0x1821D4B50
	protected Material get_materialAdapt() { }

	// RVA: 0x21D4C10 Offset: 0x21D4010 VA: 0x1821D4C10
	protected Material get_materialApply() { }

	// RVA: 0x21D4A50 Offset: 0x21D3E50 VA: 0x1821D4A50
	private void Start() { }

	// RVA: 0x21D45E0 Offset: 0x21D39E0 VA: 0x1821D45E0
	private void OnEnable() { }

	// RVA: 0x21D4370 Offset: 0x21D3770 VA: 0x1821D4370
	private void OnDisable() { }

	// RVA: 0x21D4740 Offset: 0x21D3B40 VA: 0x1821D4740
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21D4110 Offset: 0x21D3510 VA: 0x1821D4110
	private void CalculateAdaptation(Texture curTexture) { }

	// RVA: 0x21D4AE0 Offset: 0x21D3EE0 VA: 0x1821D4AE0
	public void .ctor() { }

}

