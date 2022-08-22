public class FlashbangEffectRenderer : PostProcessEffectRenderer<FlashbangEffect> // TypeDefIndex: 10252
{	public static bool needsCapture; // 0x0
	private Shader flashbangEffectShader; // 0x20
	private RenderTexture screenRT; // 0x28


	public override void Init() { }

	public override void Render(PostProcessRenderContext context) { }

	public override void Release() { }

	private static void CheckCreateRenderTexture(ref RenderTexture rt, string name, int width, int height, RenderTextureFormat format) { }

	private static void SafeDestroyRenderTexture(ref RenderTexture rt) { }

	public void .ctor() { }

}

