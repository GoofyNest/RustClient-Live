public class Frost : PostProcessEffectSettings // TypeDefIndex: 12000
{
	[RangeAttribute] 
	public FloatParameter scale; 
	public BoolParameter enableVignette; 
	[RangeAttribute] 
	public FloatParameter sharpness; 
	[RangeAttribute] 
	public FloatParameter darkness; 


	public void .ctor() { }

}

