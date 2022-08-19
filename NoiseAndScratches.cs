public class NoiseAndScratches : MonoBehaviour // TypeDefIndex: 8195
{	// Fields
	public bool monochrome; // 0x18
	private bool rgbFallback; // 0x19
	public float grainIntensityMin; // 0x1C
	public float grainIntensityMax; // 0x20
	public float grainSize; // 0x24
	public float scratchIntensityMin; // 0x28
	public float scratchIntensityMax; // 0x2C
	public float scratchFPS; // 0x30
	public float scratchJitter; // 0x34
	public Texture grainTexture; // 0x38
	public Texture scratchTexture; // 0x40
	public Shader shaderRGB; // 0x48
	public Shader shaderYUV; // 0x50
	private Material m_MaterialRGB; // 0x58
	private Material m_MaterialYUV; // 0x60
	private float scratchTimeLeft; // 0x68
	private float scratchX; // 0x6C
	private float scratchY; // 0x70

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x21DDDA0 Offset: 0x21DD1A0 VA: 0x1821DDDA0
	protected void Start() { }

	// RVA: 0x21DDF00 Offset: 0x21DD300 VA: 0x1821DDF00
	protected Material get_material() { }

	// RVA: 0x21DD550 Offset: 0x21DC950 VA: 0x1821DD550
	protected void OnDisable() { }

	// RVA: 0x21DDC70 Offset: 0x21DD070 VA: 0x1821DDC70
	private void SanitizeParameters() { }

	// RVA: 0x21DD640 Offset: 0x21DCA40 VA: 0x1821DD640
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DDEC0 Offset: 0x21DD2C0 VA: 0x1821DDEC0
	public void .ctor() { }

}

