public sealed class Vignette : PostProcessEffectSettings // TypeDefIndex: 13565
{
	[TooltipAttribute] 
	public VignetteModeParameter mode; 
	[TooltipAttribute] 
	public ColorParameter color; 
	[TooltipAttribute] 
	public Vector2Parameter center; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter intensity; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter smoothness; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter roundness; 
	[TooltipAttribute] 
	public BoolParameter rounded; 
	[TooltipAttribute] 
	public TextureParameter mask; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter opacity; 


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

