public class GodRaysRenderer : PostProcessEffectRenderer<GodRays> // TypeDefIndex: 10260
{	private const int PASS_SCREEN = 0;
	private const int PASS_ADD = 1;
	public Shader GodRayShader; // 0x20
	public Shader ScreenClearShader; // 0x28
	public Shader SkyMaskShader; // 0x30


	public override void Init() { }

	private void DrawBorder(PostProcessRenderContext context, RenderTargetIdentifier buffer1) { }

	private int GetSkyMask(PostProcessRenderContext context, ResolutionType resolution, Vector3 lightPos, int blurIterations, float blurRadius, float maxRadius) { }

	public override void Render(PostProcessRenderContext context) { }

	public void .ctor() { }

}

