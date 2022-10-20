public sealed class ChromaticAberration : PostProcessEffectSettings // TypeDefIndex: 13519
{
	[TooltipAttribute] 
	public TextureParameter spectralLut; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter intensity; 
	[FormerlySerializedAsAttribute] 
	[TooltipAttribute] 
	public BoolParameter fastMode; 


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

