internal struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket> // TypeDefIndex: 5521
{	// Fields
	public uint Value; // 0x0

	// Methods

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static HAuthTicket op_Implicit(uint value) { }

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static uint op_Implicit(HAuthTicket value) { }

	// RVA: 0x1D7B50 Offset: 0x1D6F50 VA: 0x1801D7B50 Slot: 3
	public override string ToString() { }

	// RVA: 0x14C360 Offset: 0x14B760 VA: 0x18014C360 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E9380 Offset: 0x1E8780 VA: 0x1801E9380 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D7B40 Offset: 0x1D6F40 VA: 0x1801D7B40 Slot: 4
	public bool Equals(HAuthTicket p) { }

	// RVA: 0x1D7AC0 Offset: 0x1D6EC0 VA: 0x1801D7AC0 Slot: 5
	public int CompareTo(HAuthTicket other) { }

}

