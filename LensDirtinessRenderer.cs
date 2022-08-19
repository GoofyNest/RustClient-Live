public class LensDirtinessRenderer : PostProcessEffectRenderer<LensDirtinessEffect> // TypeDefIndex: 10264
{	// Fields
	private int dataProperty; // 0x20
	private Shader lensDirtinessShader; // 0x28

	// Methods

	// RVA: 0x6C03A0 Offset: 0x6BF7A0 VA: 0x1806C03A0 Slot: 4
	public override void Init() { }

	// RVA: 0x6C03F0 Offset: 0x6BF7F0 VA: 0x1806C03F0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x6C10E0 Offset: 0x6C04E0 VA: 0x1806C10E0
	public void .ctor() { }

}

private enum LensDirtinessRenderer.Pass // TypeDefIndex: 10265
{	// Fields
	public int value__; // 0x0
	public const LensDirtinessRenderer.Pass Threshold = 0;
	public const LensDirtinessRenderer.Pass Kawase = 1;
	public const LensDirtinessRenderer.Pass Compose = 2;

}

