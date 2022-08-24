internal sealed class LogHistogram // TypeDefIndex: 11859
{
public const int rangeMin = -9;
public const int rangeMax = 9;
private const int k_Bins = 128;
	[CompilerGeneratedAttribute] 
	private ComputeBuffer <data>k__BackingField; 

public ComputeBuffer data { get; set; }


	[CompilerGeneratedAttribute] 
public ComputeBuffer get_data() { }

	[CompilerGeneratedAttribute] 
private void set_data(ComputeBuffer value) { }

public void Generate(PostProcessRenderContext context) { }

public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context) { }

public void Release() { }

public void .ctor() { }

}

