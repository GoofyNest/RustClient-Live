public class MotionBlur : ImageEffectBase // TypeDefIndex: 8193
{	// Fields
	public float blurAmount; // 0x28
	public bool extraBlur; // 0x2C
	private RenderTexture accumTexture; // 0x30

	// Methods

	// RVA: 0x21DC350 Offset: 0x21DB750 VA: 0x1821DC350 Slot: 4
	protected override void Start() { }

	// RVA: 0x21DBEC0 Offset: 0x21DB2C0 VA: 0x1821DBEC0 Slot: 5
	protected override void OnDisable() { }

	// RVA: 0x21DBFA0 Offset: 0x21DB3A0 VA: 0x1821DBFA0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DC400 Offset: 0x21DB800 VA: 0x1821DC400
	public void .ctor() { }

}

public sealed class MotionBlur : PostProcessEffectSettings // TypeDefIndex: 11788
{	// Fields
	[RangeAttribute] // RVA: 0x73840 Offset: 0x72C40 VA: 0x180073840
	[TooltipAttribute] // RVA: 0x73840 Offset: 0x72C40 VA: 0x180073840
	public FloatParameter shutterAngle; // 0x30
	[RangeAttribute] // RVA: 0x73A30 Offset: 0x72E30 VA: 0x180073A30
	[TooltipAttribute] // RVA: 0x73A30 Offset: 0x72E30 VA: 0x180073A30
	public IntParameter sampleCount; // 0x38

	// Methods

	// RVA: 0x1015200 Offset: 0x1014600 VA: 0x181015200 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x10152D0 Offset: 0x10146D0 VA: 0x1810152D0
	public void .ctor() { }

}

