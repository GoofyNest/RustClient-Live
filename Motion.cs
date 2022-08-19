public class Motion : Object // TypeDefIndex: 4494
{	// Methods

	// RVA: 0x22D7FA0 Offset: 0x22D73A0 VA: 0x1822D7FA0
	protected void .ctor() { }

}

public class Motion : MonoBehaviour // TypeDefIndex: 8133
{	// Fields
	[SerializeField] // RVA: 0x93320 Offset: 0x92720 VA: 0x180093320
	[TooltipAttribute] // RVA: 0x93320 Offset: 0x92720 VA: 0x180093320
	private Motion.ExposureMode _exposureMode; // 0x18
	[SerializeField] // RVA: 0x933F0 Offset: 0x927F0 VA: 0x1800933F0
	[TooltipAttribute] // RVA: 0x933F0 Offset: 0x927F0 VA: 0x1800933F0
	private int _shutterSpeed; // 0x1C
	[SerializeField] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	[TooltipAttribute] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	private float _exposureTimeScale; // 0x20
	[SerializeField] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	[TooltipAttribute] // RVA: 0x935D0 Offset: 0x929D0 VA: 0x1800935D0
	private Motion.SampleCount _sampleCount; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int _sampleCountValue; // 0x28
	[SerializeField] // RVA: 0x93820 Offset: 0x92C20 VA: 0x180093820
	[RangeAttribute] // RVA: 0x93820 Offset: 0x92C20 VA: 0x180093820
	[TooltipAttribute] // RVA: 0x93820 Offset: 0x92C20 VA: 0x180093820
	private float _maxBlurRadius; // 0x2C
	[SerializeField] // RVA: 0x93880 Offset: 0x92C80 VA: 0x180093880
	[TooltipAttribute] // RVA: 0x93880 Offset: 0x92C80 VA: 0x180093880
	private Motion.DebugMode _debugMode; // 0x30
	private Material _prefilterMaterial; // 0x38
	private Material _reconstructionMaterial; // 0x40

	// Properties
	public Motion.ExposureMode exposureMode { get; set; }
	public int shutterSpeed { get; set; }
	public float exposureTimeScale { get; set; }
	public Motion.SampleCount sampleCount { get; set; }
	public int sampleCountValue { get; set; }
	public float maxBlurRadius { get; set; }
	private float VelocityScale { get; }

	// Methods

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public Motion.ExposureMode get_exposureMode() { }

	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	public void set_exposureMode(Motion.ExposureMode value) { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public int get_shutterSpeed() { }

	// RVA: 0x95B2E0 Offset: 0x95A6E0 VA: 0x18095B2E0
	public void set_shutterSpeed(int value) { }

	// RVA: 0x772400 Offset: 0x771800 VA: 0x180772400
	public float get_exposureTimeScale() { }

	// RVA: 0x772440 Offset: 0x771840 VA: 0x180772440
	public void set_exposureTimeScale(float value) { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public Motion.SampleCount get_sampleCount() { }

	// RVA: 0x7E8E00 Offset: 0x7E8200 VA: 0x1807E8E00
	public void set_sampleCount(Motion.SampleCount value) { }

	// RVA: 0x106B2D0 Offset: 0x106A6D0 VA: 0x18106B2D0
	public int get_sampleCountValue() { }

	// RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	public void set_sampleCountValue(int value) { }

	// RVA: 0x106B250 Offset: 0x106A650 VA: 0x18106B250
	public float get_maxBlurRadius() { }

	// RVA: 0x93F190 Offset: 0x93E590 VA: 0x18093F190
	public void set_maxBlurRadius(float value) { }

	// RVA: 0x106B200 Offset: 0x106A600 VA: 0x18106B200
	private float get_VelocityScale() { }

	// RVA: 0x106A990 Offset: 0x1069D90 VA: 0x18106A990
	private RenderTexture GetTemporaryRT(Texture source, int divider, RenderTextureFormat format, RenderTextureReadWrite rw) { }

	// RVA: 0x691420 Offset: 0x690820 VA: 0x180691420
	private void ReleaseTemporaryRT(RenderTexture rt) { }

	// RVA: 0x106AB40 Offset: 0x1069F40 VA: 0x18106AB40
	private void OnEnable() { }

	// RVA: 0x106AAA0 Offset: 0x1069EA0 VA: 0x18106AAA0
	private void OnDisable() { }

	// RVA: 0x106AC60 Offset: 0x106A060 VA: 0x18106AC60
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106B1C0 Offset: 0x106A5C0 VA: 0x18106B1C0
	public void .ctor() { }

}

public enum Motion.ExposureMode // TypeDefIndex: 8134
{	// Fields
	public int value__; // 0x0
	public const Motion.ExposureMode Constant = 0;
	public const Motion.ExposureMode DeltaTime = 1;

}

public enum Motion.SampleCount // TypeDefIndex: 8135
{	// Fields
	public int value__; // 0x0
	public const Motion.SampleCount Low = 0;
	public const Motion.SampleCount Medium = 1;
	public const Motion.SampleCount High = 2;
	public const Motion.SampleCount Variable = 3;

}

private enum Motion.DebugMode // TypeDefIndex: 8136
{	// Fields
	public int value__; // 0x0
	public const Motion.DebugMode Off = 0;
	public const Motion.DebugMode Velocity = 1;
	public const Motion.DebugMode NeighborMax = 2;
	public const Motion.DebugMode Depth = 3;

}

