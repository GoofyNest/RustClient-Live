public class Frost : PostProcessEffectSettings // TypeDefIndex: 12018
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

