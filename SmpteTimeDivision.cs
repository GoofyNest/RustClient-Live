public sealed class SmpteTimeDivision : TimeDivision // TypeDefIndex: 7611
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly SmpteFormat <Format>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly byte <Resolution>k__BackingField; // 0x11

	// Properties
	public SmpteFormat Format { get; }
	public byte Resolution { get; }

	// Methods

	// RVA: 0x13A1EA0 Offset: 0x13A12A0 VA: 0x1813A1EA0
	public void .ctor(SmpteFormat format, byte resolution) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public SmpteFormat get_Format() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF86260 Offset: 0xF85660 VA: 0x180F86260
	public byte get_Resolution() { }

	// RVA: 0x13A1F10 Offset: 0x13A1310 VA: 0x1813A1F10
	public static bool op_Equality(SmpteTimeDivision timeDivision1, SmpteTimeDivision timeDivision2) { }

	// RVA: 0x13A1E20 Offset: 0x13A1220 VA: 0x1813A1E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A1D40 Offset: 0x13A1140 VA: 0x1813A1D40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A1DD0 Offset: 0x13A11D0 VA: 0x1813A1DD0 Slot: 2
	public override int GetHashCode() { }

}

