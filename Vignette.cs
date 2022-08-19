public sealed class Vignette : PostProcessEffectSettings // TypeDefIndex: 11811
{	// Fields
	[TooltipAttribute] // RVA: 0x777A0 Offset: 0x76BA0 VA: 0x1800777A0
	public VignetteModeParameter mode; // 0x30
	[TooltipAttribute] // RVA: 0x778A0 Offset: 0x76CA0 VA: 0x1800778A0
	public ColorParameter color; // 0x38
	[TooltipAttribute] // RVA: 0x77910 Offset: 0x76D10 VA: 0x180077910
	public Vector2Parameter center; // 0x40
	[RangeAttribute] // RVA: 0x77A50 Offset: 0x76E50 VA: 0x180077A50
	[TooltipAttribute] // RVA: 0x77A50 Offset: 0x76E50 VA: 0x180077A50
	public FloatParameter intensity; // 0x48
	[RangeAttribute] // RVA: 0x77C20 Offset: 0x77020 VA: 0x180077C20
	[TooltipAttribute] // RVA: 0x77C20 Offset: 0x77020 VA: 0x180077C20
	public FloatParameter smoothness; // 0x50
	[RangeAttribute] // RVA: 0x77DD0 Offset: 0x771D0 VA: 0x180077DD0
	[TooltipAttribute] // RVA: 0x77DD0 Offset: 0x771D0 VA: 0x180077DD0
	public FloatParameter roundness; // 0x58
	[TooltipAttribute] // RVA: 0x77FD0 Offset: 0x773D0 VA: 0x180077FD0
	public BoolParameter rounded; // 0x60
	[TooltipAttribute] // RVA: 0x780B0 Offset: 0x774B0 VA: 0x1800780B0
	public TextureParameter mask; // 0x68
	[RangeAttribute] // RVA: 0x78260 Offset: 0x77660 VA: 0x180078260
	[TooltipAttribute] // RVA: 0x78260 Offset: 0x77660 VA: 0x180078260
	public FloatParameter opacity; // 0x70

	// Methods

	// RVA: 0x11E5C80 Offset: 0x11E5080 VA: 0x1811E5C80 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x11E5D50 Offset: 0x11E5150 VA: 0x1811E5D50
	public void .ctor() { }

}

