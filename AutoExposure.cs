public sealed class AutoExposure : PostProcessEffectSettings // TypeDefIndex: 11761
{	[MinMaxAttribute] // RVA: 0xE9EF0 Offset: 0xE92F0 VA: 0x1800E9EF0
	[DisplayNameAttribute] // RVA: 0xE9EF0 Offset: 0xE92F0 VA: 0x1800E9EF0
	[TooltipAttribute] // RVA: 0xE9EF0 Offset: 0xE92F0 VA: 0x1800E9EF0
	public Vector2Parameter filtering; // 0x30
	[RangeAttribute] // RVA: 0xE9FB0 Offset: 0xE93B0 VA: 0x1800E9FB0
	[DisplayNameAttribute] // RVA: 0xE9FB0 Offset: 0xE93B0 VA: 0x1800E9FB0
	[TooltipAttribute] // RVA: 0xE9FB0 Offset: 0xE93B0 VA: 0x1800E9FB0
	public FloatParameter minLuminance; // 0x38
	[RangeAttribute] // RVA: 0xEA1A0 Offset: 0xE95A0 VA: 0x1800EA1A0
	[DisplayNameAttribute] // RVA: 0xEA1A0 Offset: 0xE95A0 VA: 0x1800EA1A0
	[TooltipAttribute] // RVA: 0xEA1A0 Offset: 0xE95A0 VA: 0x1800EA1A0
	public FloatParameter maxLuminance; // 0x40
	[MinAttribute] // RVA: 0xEA430 Offset: 0xE9830 VA: 0x1800EA430
	[DisplayNameAttribute] // RVA: 0xEA430 Offset: 0xE9830 VA: 0x1800EA430
	[TooltipAttribute] // RVA: 0xEA430 Offset: 0xE9830 VA: 0x1800EA430
	public FloatParameter keyValue; // 0x48
	[DisplayNameAttribute] // RVA: 0xEA5B0 Offset: 0xE99B0 VA: 0x1800EA5B0
	[TooltipAttribute] // RVA: 0xEA5B0 Offset: 0xE99B0 VA: 0x1800EA5B0
	public EyeAdaptationParameter eyeAdaptation; // 0x50
	[MinAttribute] // RVA: 0xEA680 Offset: 0xE9A80 VA: 0x1800EA680
	[TooltipAttribute] // RVA: 0xEA680 Offset: 0xE9A80 VA: 0x1800EA680
	public FloatParameter speedUp; // 0x58
	[MinAttribute] // RVA: 0xEA820 Offset: 0xE9C20 VA: 0x1800EA820
	[TooltipAttribute] // RVA: 0xEA820 Offset: 0xE9C20 VA: 0x1800EA820
	public FloatParameter speedDown; // 0x60


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

