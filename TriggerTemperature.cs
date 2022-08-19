public class TriggerTemperature : TriggerBase // TypeDefIndex: 10048
{	// Fields
	public float Temperature; // 0x30
	public float triggerSize; // 0x34
	public float minSize; // 0x38
	public bool sunlightBlocker; // 0x3C
	public float sunlightBlockAmount; // 0x40
	[RangeAttribute] // RVA: 0xB0690 Offset: 0xAFA90 VA: 0x1800B0690
	public float blockMinHour; // 0x44
	[RangeAttribute] // RVA: 0xB0690 Offset: 0xAFA90 VA: 0x1800B0690
	public float blockMaxHour; // 0x48

	// Methods

	// RVA: 0x4D0260 Offset: 0x4CF660 VA: 0x1804D0260
	private void OnValidate() { }

	// RVA: 0x4D0420 Offset: 0x4CF820 VA: 0x1804D0420
	public void .ctor() { }

}

