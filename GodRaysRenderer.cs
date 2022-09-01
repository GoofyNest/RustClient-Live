public class GodRaysRenderer : PostProcessEffectRenderer<GodRays> // TypeDefIndex: 10267
{
	private const int PASS_SCREEN = 0;
	private const int PASS_ADD = 1;
	public Shader GodRayShader; 
	public Shader ScreenClearShader; 
	public Shader SkyMaskShader; 


	public override void Init() { }

	private void DrawBorder(PostProcessRenderContext context, RenderTargetIdentifier buffer1) { }

	private int GetSkyMask(PostProcessRenderContext context, ResolutionType resolution, Vector3 lightPos, int blurIterations, float blurRadius, float maxRadius) { }

	public override void Render(PostProcessRenderContext context) { }

	public void .ctor() { }

}

