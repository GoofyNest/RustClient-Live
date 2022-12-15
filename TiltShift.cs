internal class TiltShift : PostEffectsBase // TypeDefIndex: 8230
{
	public TiltShift.TiltShiftMode mode;
	public TiltShift.TiltShiftQuality quality;
	[RangeAttribute]
	public float blurArea;
	[RangeAttribute]
	public float maxBlurSize;
	[RangeAttribute]
	public int downsample;
	public Shader tiltShiftShader;
	private Material tiltShiftMaterial;


	public override bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum TiltShift.TiltShiftMode // TypeDefIndex: 8231
{
	public int value__;
	public const TiltShift.TiltShiftMode TiltShiftMode = 0;
	public const TiltShift.TiltShiftMode IrisMode = 1;

}

public enum TiltShift.TiltShiftQuality // TypeDefIndex: 8232
{
	public int value__;
	public const TiltShift.TiltShiftQuality Preview = 0;
	public const TiltShift.TiltShiftQuality Normal = 1;
	public const TiltShift.TiltShiftQuality High = 2;

}

