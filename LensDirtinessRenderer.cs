public class LensDirtinessRenderer : PostProcessEffectRenderer<LensDirtinessEffect> // TypeDefIndex: 10264
{	private int dataProperty; // 0x20
	private Shader lensDirtinessShader; // 0x28


	public override void Init() { }

	public override void Render(PostProcessRenderContext context) { }

	public void .ctor() { }

}

private enum LensDirtinessRenderer.Pass // TypeDefIndex: 10265
{	public int value__; // 0x0
	public const LensDirtinessRenderer.Pass Threshold = 0;
	public const LensDirtinessRenderer.Pass Kawase = 1;
	public const LensDirtinessRenderer.Pass Compose = 2;

}

