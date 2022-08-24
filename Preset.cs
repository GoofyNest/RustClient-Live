public class Preset // TypeDefIndex: 11558
{
	public bool DiagDetection; 
	public bool CornerDetection; 
	[RangeAttribute] 
	public float Threshold; 
	[MinAttribute] 
	public float DepthThreshold; 
	[RangeAttribute] 
	public int MaxSearchSteps; 
	[RangeAttribute] 
	public int MaxSearchStepsDiag; 
	[RangeAttribute] 
	public int CornerRounding; 
	[MinAttribute] 
	public float LocalContrastAdaptationFactor; 


public void .ctor() { }

}

