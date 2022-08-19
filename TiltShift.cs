internal class TiltShift : PostEffectsBase // TypeDefIndex: 8208
{	// Fields
	public TiltShift.TiltShiftMode mode; // 0x28
	public TiltShift.TiltShiftQuality quality; // 0x2C
	[RangeAttribute] // RVA: 0x9E6E0 Offset: 0x9DAE0 VA: 0x18009E6E0
	public float blurArea; // 0x30
	[RangeAttribute] // RVA: 0x9E750 Offset: 0x9DB50 VA: 0x18009E750
	public float maxBlurSize; // 0x34
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public int downsample; // 0x38
	public Shader tiltShiftShader; // 0x40
	private Material tiltShiftMaterial; // 0x48

	// Methods

	// RVA: 0x21E27D0 Offset: 0x21E1BD0 VA: 0x1821E27D0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21E2830 Offset: 0x21E1C30 VA: 0x1821E2830
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E2AE0 Offset: 0x21E1EE0 VA: 0x1821E2AE0
	public void .ctor() { }

}

public enum TiltShift.TiltShiftMode // TypeDefIndex: 8209
{	// Fields
	public int value__; // 0x0
	public const TiltShift.TiltShiftMode TiltShiftMode = 0;
	public const TiltShift.TiltShiftMode IrisMode = 1;

}

public enum TiltShift.TiltShiftQuality // TypeDefIndex: 8210
{	// Fields
	public int value__; // 0x0
	public const TiltShift.TiltShiftQuality Preview = 0;
	public const TiltShift.TiltShiftQuality Normal = 1;
	public const TiltShift.TiltShiftQuality High = 2;

}

