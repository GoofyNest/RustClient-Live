public class DepthOfFieldEffectRenderer : PostProcessEffectRenderer<DepthOfFieldEffect> // TypeDefIndex: 10248
{	// Fields
	private float focalDistance01; // 0x20
	private float internalBlurWidth; // 0x24
	private Shader dofShader; // 0x28

	// Methods

	// RVA: 0x9BA960 Offset: 0x9B9D60 VA: 0x1809BA960 Slot: 4
	public override void Init() { }

	// RVA: 0x9BA7C0 Offset: 0x9B9BC0 VA: 0x1809BA7C0
	private float FocalDistance01(Camera cam, float worldDist) { }

	// RVA: 0x9BB0B0 Offset: 0x9BA4B0 VA: 0x1809BB0B0
	private void WriteCoc(PostProcessRenderContext context, PropertySheet sheet) { }

	// RVA: 0x9BA9B0 Offset: 0x9B9DB0 VA: 0x1809BA9B0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9BB610 Offset: 0x9BAA10 VA: 0x1809BB610
	public void .ctor() { }

}

