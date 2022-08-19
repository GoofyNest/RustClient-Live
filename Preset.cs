public class Preset // TypeDefIndex: 11558
{	// Fields
	public bool DiagDetection; // 0x10
	public bool CornerDetection; // 0x11
	[RangeAttribute] // RVA: 0xC63F0 Offset: 0xC57F0 VA: 0x1800C63F0
	public float Threshold; // 0x14
	[MinAttribute] // RVA: 0xC62C0 Offset: 0xC56C0 VA: 0x1800C62C0
	public float DepthThreshold; // 0x18
	[RangeAttribute] // RVA: 0xC6550 Offset: 0xC5950 VA: 0x1800C6550
	public int MaxSearchSteps; // 0x1C
	[RangeAttribute] // RVA: 0xC65C0 Offset: 0xC59C0 VA: 0x1800C65C0
	public int MaxSearchStepsDiag; // 0x20
	[RangeAttribute] // RVA: 0x77CA0 Offset: 0x770A0 VA: 0x180077CA0
	public int CornerRounding; // 0x24
	[MinAttribute] // RVA: 0xC6920 Offset: 0xC5D20 VA: 0x1800C6920
	public float LocalContrastAdaptationFactor; // 0x28

	// Methods

	// RVA: 0x5BE790 Offset: 0x5BDB90 VA: 0x1805BE790
	public void .ctor() { }

}

