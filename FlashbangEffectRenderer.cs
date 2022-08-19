public class FlashbangEffectRenderer : PostProcessEffectRenderer<FlashbangEffect> // TypeDefIndex: 10252
{	// Fields
	public static bool needsCapture; // 0x0
	private Shader flashbangEffectShader; // 0x20
	private RenderTexture screenRT; // 0x28

	// Methods

	// RVA: 0x78E550 Offset: 0x78D950 VA: 0x18078E550 Slot: 4
	public override void Init() { }

	// RVA: 0x78E5C0 Offset: 0x78D9C0 VA: 0x18078E5C0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x78E5A0 Offset: 0x78D9A0 VA: 0x18078E5A0 Slot: 7
	public override void Release() { }

	// RVA: 0x78E3E0 Offset: 0x78D7E0 VA: 0x18078E3E0
	private static void CheckCreateRenderTexture(ref RenderTexture rt, string name, int width, int height, RenderTextureFormat format) { }

	// RVA: 0x78EAC0 Offset: 0x78DEC0 VA: 0x18078EAC0
	private static void SafeDestroyRenderTexture(ref RenderTexture rt) { }

	// RVA: 0x78EB80 Offset: 0x78DF80 VA: 0x18078EB80
	public void .ctor() { }

}

