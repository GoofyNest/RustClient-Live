public class Blur : MonoBehaviour, IImageEffect // TypeDefIndex: 8165
{	// Fields
	public int iterations; // 0x18
	public float blurSpread; // 0x1C
	public Shader blurShader; // 0x20
	private static Material m_Material; // 0x0

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x12C2680 Offset: 0x12C1A80 VA: 0x1812C2680
	protected Material get_material() { }

	// RVA: 0x12C2350 Offset: 0x12C1750 VA: 0x1812C2350
	protected void OnDisable() { }

	// RVA: 0x12C25A0 Offset: 0x12C19A0 VA: 0x1812C25A0
	protected void Start() { }

	// RVA: 0x12C2130 Offset: 0x12C1530 VA: 0x1812C2130
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration) { }

	// RVA: 0x12C1F20 Offset: 0x12C1320 VA: 0x1812C1F20
	private void DownSample4x(RenderTexture source, RenderTexture dest) { }

	// RVA: 0x8C5D70 Offset: 0x8C5170 VA: 0x1808C5D70 Slot: 4
	public bool IsActive() { }

	// RVA: 0x12C2440 Offset: 0x12C1840 VA: 0x1812C2440 Slot: 5
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12C2660 Offset: 0x12C1A60 VA: 0x1812C2660
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

