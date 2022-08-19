public struct float2 : IEquatable<float2>, IFormattable // TypeDefIndex: 7101
{	// Fields
	public float x; // 0x0
	public float y; // 0x4

	// Methods

	// RVA: 0xF2260 Offset: 0xF1660 VA: 0x1800F2260
	public void .ctor(float x, float y) { }

	// RVA: 0x239B00 Offset: 0x238F00 VA: 0x180239B00
	public void .ctor(int2 v) { }

	// RVA: 0x239B20 Offset: 0x238F20 VA: 0x180239B20
	public void .ctor(half2 v) { }

	// RVA: 0x22A8820 Offset: 0x22A7C20 VA: 0x1822A8820
	public static float2 op_Implicit(int2 v) { }

	// RVA: 0x96C530 Offset: 0x96B930 VA: 0x18096C530
	public static float2 op_Implicit(half2 v) { }

	// RVA: 0x217D300 Offset: 0x217C700 VA: 0x18217D300
	public static float2 op_Subtraction(float2 lhs, float2 rhs) { }

	// RVA: 0x2359A0 Offset: 0x234DA0 VA: 0x1802359A0 Slot: 4
	public bool Equals(float2 rhs) { }

	// RVA: 0x239900 Offset: 0x238D00 VA: 0x180239900 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x239990 Offset: 0x238D90 VA: 0x180239990 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x239A70 Offset: 0x238E70 VA: 0x180239A70 Slot: 3
	public override string ToString() { }

	// RVA: 0x2399E0 Offset: 0x238DE0 VA: 0x1802399E0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

}

