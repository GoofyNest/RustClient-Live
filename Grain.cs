public sealed class Grain : PostProcessEffectSettings // TypeDefIndex: 11784
{	// Fields
	[TooltipAttribute] // RVA: 0x70B00 Offset: 0x6FF00 VA: 0x180070B00
	public BoolParameter colored; // 0x30
	[RangeAttribute] // RVA: 0x70C50 Offset: 0x70050 VA: 0x180070C50
	[TooltipAttribute] // RVA: 0x70C50 Offset: 0x70050 VA: 0x180070C50
	public FloatParameter intensity; // 0x38
	[RangeAttribute] // RVA: 0x70D80 Offset: 0x70180 VA: 0x180070D80
	[TooltipAttribute] // RVA: 0x70D80 Offset: 0x70180 VA: 0x180070D80
	public FloatParameter size; // 0x40
	[RangeAttribute] // RVA: 0x70FC0 Offset: 0x703C0 VA: 0x180070FC0
	[DisplayNameAttribute] // RVA: 0x70FC0 Offset: 0x703C0 VA: 0x180070FC0
	[TooltipAttribute] // RVA: 0x70FC0 Offset: 0x703C0 VA: 0x180070FC0
	public FloatParameter lumContrib; // 0x48

	// Methods

	// RVA: 0x9D0690 Offset: 0x9CFA90 VA: 0x1809D0690 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x1011590 Offset: 0x1010990 VA: 0x181011590
	public void .ctor() { }

}

