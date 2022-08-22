public class MotionBlur : ImageEffectBase // TypeDefIndex: 8193
{	public float blurAmount; // 0x28
	public bool extraBlur; // 0x2C
	private RenderTexture accumTexture; // 0x30


	protected override void Start() { }

	protected override void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public sealed class MotionBlur : PostProcessEffectSettings // TypeDefIndex: 11788
{	[RangeAttribute] // RVA: 0x73840 Offset: 0x72C40 VA: 0x180073840
	[TooltipAttribute] // RVA: 0x73840 Offset: 0x72C40 VA: 0x180073840
	public FloatParameter shutterAngle; // 0x30
	[RangeAttribute] // RVA: 0x73A30 Offset: 0x72E30 VA: 0x180073A30
	[TooltipAttribute] // RVA: 0x73A30 Offset: 0x72E30 VA: 0x180073A30
	public IntParameter sampleCount; // 0x38


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

