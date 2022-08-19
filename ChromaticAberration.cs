public sealed class ChromaticAberration : PostProcessEffectSettings // TypeDefIndex: 11767
{	// Fields
	[TooltipAttribute] // RVA: 0xEC7F0 Offset: 0xEBBF0 VA: 0x1800EC7F0
	public TextureParameter spectralLut; // 0x30
	[RangeAttribute] // RVA: 0xEC8A0 Offset: 0xEBCA0 VA: 0x1800EC8A0
	[TooltipAttribute] // RVA: 0xEC8A0 Offset: 0xEBCA0 VA: 0x1800EC8A0
	public FloatParameter intensity; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xEC950 Offset: 0xEBD50 VA: 0x1800EC950
	[TooltipAttribute] // RVA: 0xEC950 Offset: 0xEBD50 VA: 0x1800EC950
	public BoolParameter fastMode; // 0x40

	// Methods

	// RVA: 0x9D0690 Offset: 0x9CFA90 VA: 0x1809D0690 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9D06D0 Offset: 0x9CFAD0 VA: 0x1809D06D0
	public void .ctor() { }

}

