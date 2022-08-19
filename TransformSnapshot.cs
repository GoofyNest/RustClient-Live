public struct TransformSnapshot : ISnapshot<TransformSnapshot> // TypeDefIndex: 12120
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Time>k__BackingField; // 0x0
	public Vector3 pos; // 0x4
	public Quaternion rot; // 0x10

	// Properties
	public float Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2270 Offset: 0xF1670 VA: 0x1800F2270 Slot: 4
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2280 Offset: 0xF1680 VA: 0x1800F2280 Slot: 5
	public void set_Time(float value) { }

	// RVA: 0xF2430 Offset: 0xF1830 VA: 0x1800F2430
	public void .ctor(float time, Vector3 pos, Quaternion rot) { }

	// RVA: 0xF2400 Offset: 0xF1800 VA: 0x1800F2400 Slot: 6
	public void MatchValuesTo(TransformSnapshot entry) { }

	// RVA: 0xF22A0 Offset: 0xF16A0 VA: 0x1800F22A0 Slot: 7
	public void Lerp(TransformSnapshot prev, TransformSnapshot next, float delta) { }

	// RVA: 0xF2290 Offset: 0xF1690 VA: 0x1800F2290 Slot: 8
	public TransformSnapshot GetNew() { }

}

