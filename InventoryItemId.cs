public struct InventoryItemId : IEquatable<InventoryItemId>, IComparable<InventoryItemId> // TypeDefIndex: 5537
{	// Fields
	public ulong Value; // 0x0

	// Methods

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	public static InventoryItemId op_Implicit(ulong value) { }

	// RVA: 0x123050 Offset: 0x122450 VA: 0x180123050 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D8A40 Offset: 0x1D7E40 VA: 0x1801D8A40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EAD00 Offset: 0x1EA100 VA: 0x1801EAD00 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D89C0 Offset: 0x1D7DC0 VA: 0x1801D89C0 Slot: 4
	public bool Equals(InventoryItemId p) { }

	// RVA: 0x128C380 Offset: 0x128B780 VA: 0x18128C380
	public static bool op_Equality(InventoryItemId a, InventoryItemId b) { }

	// RVA: 0x1D89B0 Offset: 0x1D7DB0 VA: 0x1801D89B0 Slot: 5
	public int CompareTo(InventoryItemId other) { }

}

