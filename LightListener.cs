public class LightListener : BaseEntity // TypeDefIndex: 9635
{	// Fields
	public string onMessage; // 0x168
	public string offMessage; // 0x170
	[TooltipAttribute] // RVA: 0x7CC00 Offset: 0x7C000 VA: 0x18007CC00
	public LightGroupAtTime onLights; // 0x178
	[TooltipAttribute] // RVA: 0x7CC00 Offset: 0x7C000 VA: 0x18007CC00
	public LightGroupAtTime offLights; // 0x180

	// Methods

	// RVA: 0x4EEE90 Offset: 0x4EE290 VA: 0x1804EEE90 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x4EF020 Offset: 0x4EE420 VA: 0x1804EF020
	public void SetLightsOn(bool wantsOn) { }

	// RVA: 0x4EF1A0 Offset: 0x4EE5A0 VA: 0x1804EF1A0
	public void .ctor() { }

}

