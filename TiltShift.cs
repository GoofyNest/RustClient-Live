internal class TiltShift : PostEffectsBase // TypeDefIndex: 8208
{	public TiltShift.TiltShiftMode mode; // 0x28
	public TiltShift.TiltShiftQuality quality; // 0x2C
	[RangeAttribute] // RVA: 0x9E6E0 Offset: 0x9DAE0 VA: 0x18009E6E0
	public float blurArea; // 0x30
	[RangeAttribute] // RVA: 0x9E750 Offset: 0x9DB50 VA: 0x18009E750
	public float maxBlurSize; // 0x34
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public int downsample; // 0x38
	public Shader tiltShiftShader; // 0x40
	private Material tiltShiftMaterial; // 0x48


	public override bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum TiltShift.TiltShiftMode // TypeDefIndex: 8209
{	public int value__; // 0x0
	public const TiltShift.TiltShiftMode TiltShiftMode = 0;
	public const TiltShift.TiltShiftMode IrisMode = 1;

}

public enum TiltShift.TiltShiftQuality // TypeDefIndex: 8210
{	public int value__; // 0x0
	public const TiltShift.TiltShiftQuality Preview = 0;
	public const TiltShift.TiltShiftQuality Normal = 1;
	public const TiltShift.TiltShiftQuality High = 2;

}

