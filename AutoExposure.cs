public sealed class AutoExposure : PostProcessEffectSettings // TypeDefIndex: 13553
{
	[MinMaxAttribute] 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	public Vector2Parameter filtering; 
	[RangeAttribute] 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	public FloatParameter minLuminance; 
	[RangeAttribute] 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	public FloatParameter maxLuminance; 
	[MinAttribute] 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	public FloatParameter keyValue; 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	public EyeAdaptationParameter eyeAdaptation; 
	[MinAttribute] 
	[TooltipAttribute] 
	public FloatParameter speedUp; 
	[MinAttribute] 
	[TooltipAttribute] 
	public FloatParameter speedDown; 


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

