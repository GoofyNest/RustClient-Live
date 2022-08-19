internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure> // TypeDefIndex: 11762
{	// Fields
	private const int k_NumEyes = 2;
	private const int k_NumAutoExposureTextures = 2;
	private readonly RenderTexture[][] m_AutoExposurePool; // 0x20
	private int[] m_AutoExposurePingPong; // 0x28
	private RenderTexture m_CurrentAutoExposure; // 0x30

	// Methods

	// RVA: 0x9CC6D0 Offset: 0x9CBAD0 VA: 0x1809CC6D0
	public void .ctor() { }

	// RVA: 0x9CBA50 Offset: 0x9CAE50 VA: 0x1809CBA50
	private void CheckTexture(int eye, int id) { }

	// RVA: 0x9CBDC0 Offset: 0x9CB1C0 VA: 0x1809CBDC0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9CBCD0 Offset: 0x9CB0D0 VA: 0x1809CBCD0 Slot: 7
	public override void Release() { }

}

