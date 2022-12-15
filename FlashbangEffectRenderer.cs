public class FlashbangEffectRenderer : PostProcessEffectRenderer<FlashbangEffect> // TypeDefIndex: 12017
{
	public static bool needsCapture;
	private Shader flashbangEffectShader;
	private RenderTexture screenRT;


	public override void Init() { }

	public override void Render(PostProcessRenderContext context) { }

	public override void Release() { }

	private static void CheckCreateRenderTexture(ref RenderTexture rt, string name, int width, int height, RenderTextureFormat format) { }

	private static void SafeDestroyRenderTexture(ref RenderTexture rt) { }

	public void .ctor() { }

}

