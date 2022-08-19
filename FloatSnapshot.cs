public struct FloatSnapshot : ISnapshot<FloatSnapshot> // TypeDefIndex: 12121
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Time>k__BackingField; // 0x0
	public float value; // 0x4

	// Properties
	public float Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2270 Offset: 0xF1670 VA: 0x1800F2270 Slot: 4
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2280 Offset: 0xF1680 VA: 0x1800F2280 Slot: 5
	public void set_Time(float value) { }

	// RVA: 0xF2260 Offset: 0xF1660 VA: 0x1800F2260
	public void .ctor(float time, float value) { }

	// RVA: 0xF2240 Offset: 0xF1640 VA: 0x1800F2240 Slot: 6
	public void MatchValuesTo(FloatSnapshot entry) { }

	// RVA: 0xF21C0 Offset: 0xF15C0 VA: 0x1800F21C0 Slot: 7
	public void Lerp(FloatSnapshot prev, FloatSnapshot next, float delta) { }

	// RVA: 0xF21A0 Offset: 0xF15A0 VA: 0x1800F21A0 Slot: 8
	public FloatSnapshot GetNew() { }

}

