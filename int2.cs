public struct int2 : IEquatable<int2>, IFormattable // TypeDefIndex: 7110
{
// Namespace: Unity.Mathematics
[DefaultMemberAttribute] // RVA: 0x7F560 Offset: 0x7E960 VA: 0x18007F560
[DebuggerTypeProxyAttribute] // RVA: 0x7F560 Offset: 0x7E960 VA: 0x18007F560
[Serializable]
public struct int2 : IEquatable<int2>, IFormattable // TypeDefIndex: 7110
	// Fields
	public int x; // 0x0
	public int y; // 0x4

	// Methods

	// RVA: 0xF8460 Offset: 0xF7860 VA: 0x1800F8460
	public void .ctor(int x, int y) { }

	// RVA: 0x23A5D0 Offset: 0x2399D0 VA: 0x18023A5D0
	public void .ctor(int v) { }

	// RVA: 0x23A5E0 Offset: 0x2399E0 VA: 0x18023A5E0
	public void .ctor(float2 v) { }

	// RVA: 0x22A92D0 Offset: 0x22A86D0 VA: 0x1822A92D0
	public static int2 op_Implicit(int v) { }

	// RVA: 0x226C620 Offset: 0x226BA20 VA: 0x18226C620
	public static int2 op_Explicit(float2 v) { }

	// RVA: 0x22A92B0 Offset: 0x22A86B0 VA: 0x1822A92B0
	public static int2 op_Addition(int2 lhs, int rhs) { }

	// RVA: 0x22A92E0 Offset: 0x22A86E0 VA: 0x1822A92E0
	public static int2 op_Subtraction(int2 lhs, int rhs) { }

	// RVA: 0xFA450 Offset: 0xF9850 VA: 0x1800FA450 Slot: 4
	public bool Equals(int2 rhs) { }

	// RVA: 0x23A400 Offset: 0x239800 VA: 0x18023A400 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x23A490 Offset: 0x239890 VA: 0x18023A490 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23A550 Offset: 0x239950 VA: 0x18023A550 Slot: 3
	public override string ToString() { }

	// RVA: 0x23A4C0 Offset: 0x2398C0 VA: 0x18023A4C0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

}

