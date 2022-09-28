public sealed class LensDistortion : PostProcessEffectSettings // TypeDefIndex: 13482
{
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter intensity; 
	[RangeAttribute] 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	public FloatParameter intensityX; 
	[RangeAttribute] 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	public FloatParameter intensityY; 
	[SpaceAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter centerX; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter centerY; 
	[SpaceAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter scale; 


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

