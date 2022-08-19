internal sealed class LogHistogram // TypeDefIndex: 11859
{	// Fields
	public const int rangeMin = -9;
	public const int rangeMax = 9;
	private const int k_Bins = 128;
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ComputeBuffer <data>k__BackingField; // 0x10

	// Properties
	public ComputeBuffer data { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public ComputeBuffer get_data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_data(ComputeBuffer value) { }

	// RVA: 0x1013840 Offset: 0x1012C40 VA: 0x181013840
	public void Generate(PostProcessRenderContext context) { }

	// RVA: 0x1013BF0 Offset: 0x1012FF0 VA: 0x181013BF0
	public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context) { }

	// RVA: 0x1013C60 Offset: 0x1013060 VA: 0x181013C60
	public void Release() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

