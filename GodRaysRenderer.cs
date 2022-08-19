public class GodRaysRenderer : PostProcessEffectRenderer<GodRays> // TypeDefIndex: 10260
{	// Fields
	private const int PASS_SCREEN = 0;
	private const int PASS_ADD = 1;
	public Shader GodRayShader; // 0x20
	public Shader ScreenClearShader; // 0x28
	public Shader SkyMaskShader; // 0x30

	// Methods

	// RVA: 0xC82540 Offset: 0xC81940 VA: 0x180C82540 Slot: 4
	public override void Init() { }

	// RVA: 0xC81780 Offset: 0xC80B80 VA: 0x180C81780
	private void DrawBorder(PostProcessRenderContext context, RenderTargetIdentifier buffer1) { }

	// RVA: 0xC81C10 Offset: 0xC81010 VA: 0x180C81C10
	private int GetSkyMask(PostProcessRenderContext context, ResolutionType resolution, Vector3 lightPos, int blurIterations, float blurRadius, float maxRadius) { }

	// RVA: 0xC82670 Offset: 0xC81A70 VA: 0x180C82670 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0xC82B40 Offset: 0xC81F40 VA: 0x180C82B40
	public void .ctor() { }

}

