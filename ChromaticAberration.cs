public sealed class ChromaticAberration : PostProcessEffectSettings // TypeDefIndex: 11767
{	[TooltipAttribute] // RVA: 0xEC7F0 Offset: 0xEBBF0 VA: 0x1800EC7F0
	public TextureParameter spectralLut; // 0x30
	[RangeAttribute] // RVA: 0xEC8A0 Offset: 0xEBCA0 VA: 0x1800EC8A0
	[TooltipAttribute] // RVA: 0xEC8A0 Offset: 0xEBCA0 VA: 0x1800EC8A0
	public FloatParameter intensity; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xEC950 Offset: 0xEBD50 VA: 0x1800EC950
	[TooltipAttribute] // RVA: 0xEC950 Offset: 0xEBD50 VA: 0x1800EC950
	public BoolParameter fastMode; // 0x40


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

