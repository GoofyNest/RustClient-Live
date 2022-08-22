public class SharpenAndVignette : PostProcessEffectSettings // TypeDefIndex: 10272
{	[HeaderAttribute] // RVA: 0xC3900 Offset: 0xC2D00 VA: 0x1800C3900
	public BoolParameter applySharpen; // 0x30
	[RangeAttribute] // RVA: 0x75910 Offset: 0x74D10 VA: 0x180075910
	public FloatParameter strength; // 0x38
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public FloatParameter clamp; // 0x40
	[HeaderAttribute] // RVA: 0xC4E20 Offset: 0xC4220 VA: 0x1800C4E20
	public BoolParameter applyVignette; // 0x48
	[RangeAttribute] // RVA: 0xC4F20 Offset: 0xC4320 VA: 0x1800C4F20
	public FloatParameter sharpness; // 0x50
	[RangeAttribute] // RVA: 0x77CA0 Offset: 0x770A0 VA: 0x180077CA0
	public FloatParameter darkness; // 0x58


	public void .ctor() { }

}

