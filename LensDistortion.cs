public sealed class LensDistortion : PostProcessEffectSettings // TypeDefIndex: 11786
{	[RangeAttribute] // RVA: 0x714E0 Offset: 0x708E0 VA: 0x1800714E0
	[TooltipAttribute] // RVA: 0x714E0 Offset: 0x708E0 VA: 0x1800714E0
	public FloatParameter intensity; // 0x30
	[RangeAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[DisplayNameAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[TooltipAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	public FloatParameter intensityX; // 0x38
	[RangeAttribute] // RVA: 0x71880 Offset: 0x70C80 VA: 0x180071880
	[DisplayNameAttribute] // RVA: 0x71880 Offset: 0x70C80 VA: 0x180071880
	[TooltipAttribute] // RVA: 0x71880 Offset: 0x70C80 VA: 0x180071880
	public FloatParameter intensityY; // 0x40
	[SpaceAttribute] // RVA: 0x71AC0 Offset: 0x70EC0 VA: 0x180071AC0
	[RangeAttribute] // RVA: 0x71AC0 Offset: 0x70EC0 VA: 0x180071AC0
	[TooltipAttribute] // RVA: 0x71AC0 Offset: 0x70EC0 VA: 0x180071AC0
	public FloatParameter centerX; // 0x48
	[RangeAttribute] // RVA: 0x71C90 Offset: 0x71090 VA: 0x180071C90
	[TooltipAttribute] // RVA: 0x71C90 Offset: 0x71090 VA: 0x180071C90
	public FloatParameter centerY; // 0x50
	[SpaceAttribute] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	[RangeAttribute] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	[TooltipAttribute] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	public FloatParameter scale; // 0x58


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

