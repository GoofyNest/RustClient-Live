public struct Length : IEquatable<Length> // TypeDefIndex: 4709
{	// Fields
	private float m_Value; // 0x0
	private LengthUnit m_Unit; // 0x4

	// Properties
	public float value { get; }
	public LengthUnit unit { get; }

	// Methods

	// RVA: 0x13A270 Offset: 0x139670 VA: 0x18013A270
	public float get_value() { }

	// RVA: 0x13A260 Offset: 0x139660 VA: 0x18013A260
	public LengthUnit get_unit() { }

	// RVA: 0x13A240 Offset: 0x139640 VA: 0x18013A240
	public void .ctor(float value) { }

	// RVA: 0x13A250 Offset: 0x139650 VA: 0x18013A250
	public void .ctor(float value, LengthUnit unit) { }

	// RVA: 0xEC66A0 Offset: 0xEC5AA0 VA: 0x180EC66A0
	public static bool op_Equality(Length lhs, Length rhs) { }

	// RVA: 0x13A000 Offset: 0x139400 VA: 0x18013A000 Slot: 4
	public bool Equals(Length other) { }

	// RVA: 0x13A030 Offset: 0x139430 VA: 0x18013A030 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A0F0 Offset: 0x1394F0 VA: 0x18013A0F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A130 Offset: 0x139530 VA: 0x18013A130 Slot: 3
	public override string ToString() { }

}

