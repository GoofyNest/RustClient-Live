public class Motion : Object // TypeDefIndex: 4499
{

	protected void .ctor() { }

}

public class Motion : MonoBehaviour // TypeDefIndex: 8153
{
	[SerializeField]
	[TooltipAttribute]
	private Motion.ExposureMode _exposureMode;
	[SerializeField]
	[TooltipAttribute]
	private int _shutterSpeed;
	[SerializeField]
	[TooltipAttribute]
	private float _exposureTimeScale;
	[SerializeField]
	[TooltipAttribute]
	private Motion.SampleCount _sampleCount;
	[SerializeField]
	private int _sampleCountValue;
	[SerializeField]
	[RangeAttribute]
	[TooltipAttribute]
	private float _maxBlurRadius;
	[SerializeField]
	[TooltipAttribute]
	private Motion.DebugMode _debugMode;
	private Material _prefilterMaterial;
	private Material _reconstructionMaterial;

	public Motion.ExposureMode exposureMode { get; set; }
	public int shutterSpeed { get; set; }
	public float exposureTimeScale { get; set; }
	public Motion.SampleCount sampleCount { get; set; }
	public int sampleCountValue { get; set; }
	public float maxBlurRadius { get; set; }
	private float VelocityScale { get; }


	public Motion.ExposureMode get_exposureMode() { }

	public void set_exposureMode(Motion.ExposureMode value) { }

	public int get_shutterSpeed() { }

	public void set_shutterSpeed(int value) { }

	public float get_exposureTimeScale() { }

	public void set_exposureTimeScale(float value) { }

	public Motion.SampleCount get_sampleCount() { }

	public void set_sampleCount(Motion.SampleCount value) { }

	public int get_sampleCountValue() { }

	public void set_sampleCountValue(int value) { }

	public float get_maxBlurRadius() { }

	public void set_maxBlurRadius(float value) { }

	private float get_VelocityScale() { }

	private RenderTexture GetTemporaryRT(Texture source, int divider, RenderTextureFormat format, RenderTextureReadWrite rw) { }

	private void ReleaseTemporaryRT(RenderTexture rt) { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum Motion.ExposureMode // TypeDefIndex: 8154
{
	public int value__;
	public const Motion.ExposureMode Constant = 0;
	public const Motion.ExposureMode DeltaTime = 1;

}

public enum Motion.SampleCount // TypeDefIndex: 8155
{
	public int value__;
	public const Motion.SampleCount Low = 0;
	public const Motion.SampleCount Medium = 1;
	public const Motion.SampleCount High = 2;
	public const Motion.SampleCount Variable = 3;

}

private enum Motion.DebugMode // TypeDefIndex: 8156
{
	public int value__;
	public const Motion.DebugMode Off = 0;
	public const Motion.DebugMode Velocity = 1;
	public const Motion.DebugMode NeighborMax = 2;
	public const Motion.DebugMode Depth = 3;

}

